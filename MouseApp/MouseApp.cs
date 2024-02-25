using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MouseApp
{
    internal class MouseApp
    {
        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int X, int Y);
    }
}
