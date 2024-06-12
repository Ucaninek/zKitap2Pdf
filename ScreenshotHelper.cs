using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zKitap2Pdf
{
    internal class ScreenshotHelper
    {
        public static Bitmap CaptureScreenshot(Rectangle rect)
        {
            Bitmap screenshot = new(rect.Width, rect.Height, PixelFormat.Format32bppArgb);

            using (Graphics graphics = Graphics.FromImage(screenshot))
            {
                graphics.CopyFromScreen(rect.X, rect.Y, 0, 0, rect.Size, CopyPixelOperation.SourceCopy);
            }

            return screenshot;
        }
    }
}
