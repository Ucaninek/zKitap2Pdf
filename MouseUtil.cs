using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace zKitap2Pdf
{
    internal class MouseUtil
    {
        internal static void Click(int x, int y)
        {
            // Set the cursor position
            SetCursorPosition(x, y);

            // Perform a left mouse button click
            MouseEvent(MouseEventFlags.LeftDown);
            MouseEvent(MouseEventFlags.LeftUp);
        }

        private static void SetCursorPosition(int x, int y)
        {
            SetCursorPos(x, y);
        }

        private static void MouseEvent(MouseEventFlags flags)
        {
            mouse_event((int)flags, 0, 0, 0, 0);
        }

        [DllImport("user32.dll")]
        private static extern bool SetCursorPos(int x, int y);

        [DllImport("user32.dll")]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        [Flags]
        private enum MouseEventFlags
        {
            LeftDown = 0x00000002,
            LeftUp = 0x00000004
        }
    }
}
