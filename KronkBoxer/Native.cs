using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading;
using Microsoft.Win32;
using System.Drawing;
using System.Drawing.Imaging;

namespace KronkBoxer
{
    public static class Native
    {
        private const int SW_HIDE = 0;
        private const int SW_SHOWNORMAL = 1;
        private const int SW_SHOWMINIMIZED = 2;
        private const int SW_SHOWMAXIMIZED = 3;
        private const int SW_SHOWNOACTIVATE = 4;
        private const int SW_RESTORE = 9;
        private const int SW_SHOWDEFAULT = 10;

        private const int GWL_STYLE = -16;              //hex constant for style changing
        private const int WS_BORDER = 0x00800000;       //window with border
        private const int WS_CAPTION = 0x00C00000;      //window with a title bar
        private const int WS_SYSMENU = 0x00080000;      //window with no borders etc.
        private const int WS_MINIMIZEBOX = 0x00020000;  //window with 

        private const uint WM_KEYDOWN = 0x100;
        private const uint WM_KEYUP = 0x101;
        private const uint WM_PASTE = 0x302;

        [StructLayout(LayoutKind.Sequential)]
        public struct Rect
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        [DllImport("user32.dll")]
        private static extern int SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern IntPtr ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowRect(IntPtr hWnd, ref Rect rect);

        [DllImport("USER32.DLL")]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern uint SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll")]
        public static extern IntPtr PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool PostMessage(IntPtr hWnd, int Msg, uint wParam, uint lParam);

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern bool SendMessage(IntPtr hWnd, int wMsg, uint wParam, uint lParam);

        [DllImport("user32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll")]
        public static extern bool PrintWindow(IntPtr hWnd, IntPtr hdcBlt, int nFlags);

        private static bool ShowWindow(Process _Process, int nCmdShow)
        {
            return ShowWindowAsync(_Process.MainWindowHandle, nCmdShow);
        }

        public static Process LoadProcessInControl(string _Process, Control _Control)
        {
            Process p = Process.Start(_Process);
            new Thread(() =>
                {
                    p.WaitForInputIdle();
                    p.WaitForInputIdle();
                    Thread.Sleep(2000);

                    IntPtr control = IntPtr.Zero;

                    _Control.Invoke((MethodInvoker)delegate() { control = _Control.Handle; });
                    SetParent(p.MainWindowHandle, control);

                    SetWindowLong(p.MainWindowHandle, GWL_STYLE, WS_SYSMENU);
                    ShowWindow(p, SW_SHOWMAXIMIZED);
                }).Start();

            return p;
        }

        public static void ReMaximize(Process p)
        {
            ShowWindow(p, SW_SHOWNORMAL);
            ShowWindow(p, SW_SHOWMAXIMIZED);
        }

        public static void SendUp(Process p, Keys k)
        {
            PostMessage(p.MainWindowHandle, WM_KEYUP, ((IntPtr)k), (IntPtr)0);
        }

        public static void SendDown(Process p, Keys k)
        {
            PostMessage(p.MainWindowHandle, WM_KEYDOWN, ((IntPtr)k), (IntPtr)0);
        }

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hwnd, int msg, IntPtr wParam, [MarshalAs(UnmanagedType.LPStr)] string lParam);
        private const int WM_SETTEXT = 0x000C;
        private const int WM_COMMAND = 0x0111;

        public static void SendString(Process p, string s)
        {
            Clipboard.SetText(s);

            SendMessage(p.MainWindowHandle, WM_KEYDOWN, ((IntPtr)Keys.Enter), (IntPtr)0);
            Thread.Sleep(1);
            PostMessage(p.MainWindowHandle, WM_KEYUP, ((IntPtr)Keys.Enter), (IntPtr)0);
            Thread.Sleep(20);

            SendMessage(p.MainWindowHandle, WM_COMMAND, (IntPtr)(1 | 57637), (IntPtr)0); //1 = accelerator, 57637 = acceleratorID
            //PostMessage(p.MainWindowHandle, WM_COMMAND, (IntPtr)1, (IntPtr)57637);
            //PostMessage(p.MainWindowHandle, WM_COMMAND, (IntPtr)0, (IntPtr)0);

            Thread.Sleep(20);

            PostMessage(p.MainWindowHandle, WM_KEYDOWN, ((IntPtr)Keys.Enter), (IntPtr)0);
            Thread.Sleep(1);
            PostMessage(p.MainWindowHandle, WM_KEYUP, ((IntPtr)Keys.Enter), (IntPtr)0);
        }

        public static Bitmap CaptureApplication(IntPtr p)
        {
            try
            {
                Rect rect = new Rect();
                IntPtr error = GetWindowRect(p, ref rect);

                int width = rect.right - rect.left;
                int height = rect.bottom - rect.top;

                Bitmap bmp = new Bitmap(width, height, PixelFormat.Format32bppArgb);
                Graphics graphics = Graphics.FromImage(bmp);
                graphics.CopyFromScreen(rect.left, rect.top, 0, 0, new Size(width, height), CopyPixelOperation.SourceCopy);

                graphics.Dispose();
                graphics = null;

                return bmp;
            }
            catch
            {
                return new Bitmap(1, 1);
            }
        }

        public static Size GetWindowSize(Process p)
        {
            Rect rect = new Rect();
            IntPtr error = GetWindowRect(p.MainWindowHandle, ref rect);

            Size s = new Size();
            s.Width = rect.right - rect.left;
            s.Height = rect.bottom - rect.top;

            return s;
        }

        public static void BackgroundMousePosition(Process p, int x, int y)
        {
            PostMessage(p.MainWindowHandle, 512, 0U, GetLParam(x, y));
        }

        public static void BackgroundMouseClick(Process p, int button, int x, int y)
        {
            switch (button)
            {
                case 1:
                    PostMessage(p.MainWindowHandle, 513, (uint)1, GetLParam(x, y));
                    Thread.Sleep(10);
                    PostMessage(p.MainWindowHandle, 514, (uint)1, GetLParam(x, y));
                    break;

                case 2:
                    PostMessage(p.MainWindowHandle, 516, (uint)2, GetLParam(x, y));
                    Thread.Sleep(10);
                    PostMessage(p.MainWindowHandle, 517, (uint)2, GetLParam(x, y));
                    break;

                case 3:
                    PostMessage(p.MainWindowHandle, 519, (uint)3, GetLParam(x, y));
                    Thread.Sleep(10);
                    PostMessage(p.MainWindowHandle, 520, (uint)3, GetLParam(x, y));
                    break;
            }
        }

        public static void BackgroundMouseDown(Process p, int x, int y)
        {
            PostMessage(p.MainWindowHandle, 513, (uint)1, GetLParam(x, y));
        }

        public static void BackgroundMouseUp(Process p, int x, int y)
        {
            PostMessage(p.MainWindowHandle, 514, (uint)1, GetLParam(x, y));
        }

        private static uint GetLParam(int x, int y)
        {
            return (uint)(y << 16 | x & (int)ushort.MaxValue);
        }
    }
}
