using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zKitap2Pdf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MouseHook.PointPicked += MouseHook_PointPicked;
        }

        private void B_PickAll_Click(object sender, EventArgs e)
        {
            MouseHook.StartPicking();
        }

        private async void B_PickAll_Click(object sender, EventArgs e)
        {
            _pickedPoint = e;
            TB_TopLeftXY.Text = $"X: {TopLeft!.Value.X}, Y: {TopLeft!.Value.Y}";

            await PickCorner(CurrentlyPicking.BottomRight);

            TB_BottomRightXY.Text = $"X: {BottomRight!.Value.X}, Y: {BottomRight!.Value.Y}";

            await PickCorner(CurrentlyPicking.NextPage);

            TB_NextPageXY.Text = $"X: {NextPage!.Value.X}, Y: {NextPage!.Value.Y}";

            L_Picker.Text = "All Corners Picked!";
            FastAlert("Yay!!");
        }

        private void MouseHook_PointPicked(object? sender, Point e)
        {

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

        private void B_Start_Click(object sender, EventArgs e)
        {
            if(NUD_PageCount.Value <= 0)
            {
                
            }
        }

            B_Start.Enabled = false;
            await CaptureScreenshots(new Progress<int>(percentComplete =>
            {
                PB.Invoke((MethodInvoker)delegate
                {
                    PB.Value = percentComplete;
                });
            }));

            FastAlert("Done!");
            B_Start.Enabled = true;
        }

        private void FastAlert(string message)
        {

        }
    }
}
