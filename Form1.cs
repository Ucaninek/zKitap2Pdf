using iText.Kernel.Geom;
using System.Diagnostics;
using System.Drawing.Imaging;
using Transitions;
using Path = System.IO.Path;
using Point = System.Drawing.Point;
using Rectangle = System.Drawing.Rectangle;

namespace zKitap2Pdf
{


    public partial class Form1 : Form
    {
        bool showMousePos = false;
        Point? TopLeft, BottomRight, NextPage, _pickedPoint;
        enum CurrentlyPicking { None, TopLeft, BottomRight, NextPage }

        public Form1()
        {
            InitializeComponent();
            MouseHook.PointPicked += MouseHook_PointPicked;
            MouseHook.MouseMoved += MouseHook_MouseMoved;
        }

        private void MouseHook_MouseMoved(object? sender, Point e)
        {
            if (showMousePos)
            {
                L_Picker.Text = $"Picking (X: {e.X}, Y: {e.Y})";
            }
        }

        private async Task<Point?> PickXY()
        {
            _pickedPoint = null;
            MouseHook.StartPicking();
            while (_pickedPoint == null)
            {
                await Task.Delay(100);
            }

            return _pickedPoint;
        }

        private async Task PickCorner(CurrentlyPicking picking)
        {
            if (picking == CurrentlyPicking.None) return;

            L_Picker.Text = "Picking...";
            showMousePos = true;

            Point picked = (await PickXY()).Value;

            switch (picking)
            {
                case CurrentlyPicking.TopLeft:
                    TopLeft = picked;
                    break;
                case CurrentlyPicking.BottomRight:
                    BottomRight = picked;
                    break;
                case CurrentlyPicking.NextPage:
                    NextPage = picked;
                    break;
            }

            showMousePos = false;
            L_Picker.Text = $"Picked {picking}";
        }

        private async Task CaptureScreenshots(Rectangle roi, IProgress<int>? progress = null)
        {
            bool isTmpDirectoryEmpty = !Directory.EnumerateFileSystemEntries("tmp").Any();
            if(!isTmpDirectoryEmpty) Directory.EnumerateFiles("tmp", "*.png").ToList().ForEach(File.Delete); // Clear tmp directory
            Directory.CreateDirectory("tmp");
            int pageCount = (int)NUD_PageCount.Value;

            for (int i = 0; i < pageCount; i++)
            {
                Bitmap screenshot = ScreenshotHelper.CaptureScreenshot(roi);
                screenshot.Save($"tmp/{i}.png", ImageFormat.Png);

                MouseUtil.Click(NextPage!.Value.X, NextPage!.Value.Y);

                if (progress != null)
                {
                    int percentComplete = ((i + 1) * 100) / pageCount;
                    progress.Report(percentComplete);
                }

                await Task.Delay((int)NUD_Delay.Value);
            }
        }

        private async void B_PickAll_Click(object sender, EventArgs e)
        {
            await PickCorner(CurrentlyPicking.TopLeft);

            TB_TopLeftXY.Text = $"X: {TopLeft!.Value.X}, Y: {TopLeft!.Value.Y}";

            await PickCorner(CurrentlyPicking.BottomRight);

            TB_BottomRightXY.Text = $"X: {BottomRight!.Value.X}, Y: {BottomRight!.Value.Y}";

            await PickCorner(CurrentlyPicking.NextPage);

            TB_NextPageXY.Text = $"X: {NextPage!.Value.X}, Y: {NextPage!.Value.Y}";

            L_Picker.Text = "All Corners Picked!";
        }

        private void MouseHook_PointPicked(object? sender, Point e)
        {
            _pickedPoint = e;
        }

        private void CB_TopMost_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = ((CheckBox)sender).Checked;
        }

        private void LL_SelfAd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var psi = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                CreateNoWindow = true,
                Arguments = "/c start https://zemi.space"
            };
            Process.Start(psi);
        }

        private async void B_Start_Click(object sender, EventArgs e)
        {            

            if (NUD_PageCount.Value <= 0)
            {
                FastAlert("Page count must be greater than 0.");
                return;
            }

            if (TopLeft == null || BottomRight == null || NextPage == null)
            {
                FastAlert("All corners must be set properly.");
                return;
            }

            if (!TopLeftAndBottomRightMatches())
            {
                FastAlert("Top Left and Bottom Right corners must be set properly.");
                return;
            }

            GB_Options.Enabled = false;
            Rectangle roi = new Rectangle(TopLeft!.Value, new Size(BottomRight!.Value.X - TopLeft.Value.X, BottomRight.Value.Y - TopLeft.Value.Y));
            await CaptureScreenshots(roi, new Progress<int>(percentComplete =>
            {
                PB.Invoke((MethodInvoker)delegate
                {
                    PB.Value = percentComplete;
                });
            }));

            try
            {
                Directory.EnumerateFiles("tmp", "*.png").ToList().ForEach(File.Delete);
            } catch (Exception ex)
            {
                FastAlert(ex.Message);
            }

            PB.Style = ProgressBarStyle.Marquee;

            string guid = Guid.NewGuid().ToString();

            Directory.CreateDirectory("PDFs");

            await PDFUtil.ConvertImagesToPdf(Directory.GetFiles("tmp", "*.png"), Path.Combine("PDFs", $"{guid}.pdf"), RB_PDF_UseA4.Checked ? PageSize.A4 : new PageSize(roi.Width, roi.Height));

            FastAlert($"PDF File saved as {guid}.pdf, enjoy :>");
            GB_Options.Enabled = true;
        }

        private void FastAlert(string message)
        {
            L_FastAlert.Text = message;
            Transition t = new(new TransitionType_Flash(1, 300));
            t.add(L_FastAlert, "ForeColor", Color.Red);
            t.run();
        }

        private bool TopLeftAndBottomRightMatches()
        {
            if (TopLeft != null && BottomRight != null)
            {
                return TopLeft.Value.X < BottomRight.Value.X && TopLeft.Value.Y < BottomRight.Value.Y;
            }
            return false;
        }

        private async void TB_TopLeftXY_DoubleClick(object sender, EventArgs e)
        {
            await PickCorner(CurrentlyPicking.TopLeft);
            TB_TopLeftXY.Text = $"X: {TopLeft!.Value.X}, Y: {TopLeft!.Value.Y}";
        }

        private async void TB_BottomRightXY_DoubleClick(object sender, EventArgs e)
        {
            await PickCorner(CurrentlyPicking.BottomRight);
            TB_BottomRightXY.Text = $"X: {BottomRight!.Value.X}, Y: {BottomRight!.Value.Y}";
        }

        private async void TB_NextPageXY_DoubleClick(object sender, EventArgs e)
        {
            await PickCorner(CurrentlyPicking.NextPage);
            TB_NextPageXY.Text = $"X: {NextPage!.Value.X}, Y: {NextPage!.Value.Y}";
        }

        private void B_TmpFolder_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory("PDFs");
            Process.Start(new ProcessStartInfo()
            {
                FileName = "explorer.exe",
                Arguments = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath)!, "PDFs")
            });
        }
    }
}
