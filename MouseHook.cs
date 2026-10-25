using System.Diagnostics;
using System.Runtime.InteropServices;

namespace zKitap2Pdf
{
    internal class MouseHook
    {
        private static readonly LowLevelMouseProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;
        private static bool _isPicking = false;
        private static Point _pickedPoint;

        public static event EventHandler<Point>? PointPicked;
        public static event EventHandler<Point>? MouseMoved;

        public static void StartPicking()
        {
            _isPicking = true;
            _hookID = SetHook(_proc);
        }

        public static void StopPicking()
        {
            _isPicking = false;
            UnhookWindowsHookEx(_hookID);
        }

        private delegate IntPtr LowLevelMouseProc(int nCode, IntPtr wParam, IntPtr lParam);

        private static IntPtr SetHook(LowLevelMouseProc proc)
        {
            using Process curProcess = Process.GetCurrentProcess();
            using ProcessModule? curModule = curProcess.MainModule;
            if (curModule?.ModuleName == null) return new IntPtr(1);
            return SetWindowsHookEx(WH_MOUSE_LL, proc, GetModuleHandle(curModule.ModuleName), 0);
        }

        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (_isPicking && nCode >= 0 && (MouseMessages.WM_LBUTTONDOWN == (MouseMessages)wParam))
            {
                MSLLHOOKSTRUCT? hookStruct = (MSLLHOOKSTRUCT?)Marshal.PtrToStructure(lParam, typeof(MSLLHOOKSTRUCT));
                if (hookStruct != null)
                {
                    _pickedPoint = new Point(((MSLLHOOKSTRUCT)hookStruct).pt.x, ((MSLLHOOKSTRUCT)hookStruct).pt.y);
                    PointPicked?.Invoke(null, _pickedPoint);
                }
                StopPicking();

                // Stop event propagation by not calling CallNextHookEx
                return new IntPtr(1);
            }
            else if (nCode >= 0 && (MouseMessages.WM_MOUSEMOVE == (MouseMessages)wParam))
            {
                MSLLHOOKSTRUCT? hookStruct = (MSLLHOOKSTRUCT?)Marshal.PtrToStructure(lParam, typeof(MSLLHOOKSTRUCT));
                if (hookStruct != null)
                {
                    Point mousePosition = new(((MSLLHOOKSTRUCT)hookStruct).pt.x, ((MSLLHOOKSTRUCT)hookStruct).pt.y);
                    MouseMoved?.Invoke(null, mousePosition);
                }
            }

            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        private const int WH_MOUSE_LL = 14;

        private enum MouseMessages
        {
            WM_LBUTTONDOWN = 0x0201,
            WM_MOUSEMOVE = 0x0200
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct POINT
        {
            public int x;
            public int y;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct MSLLHOOKSTRUCT
        {
            public POINT pt;
            public uint mouseData;
            public uint flags;
            public uint time;
            public IntPtr dwExtraInfo;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelMouseProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);
    }
}
