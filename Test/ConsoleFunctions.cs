using System;
using System.Runtime.InteropServices;

namespace MissileControl
{
    internal static class ConsoleFunctions
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        internal static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        internal static extern bool FreeConsole();
    }
}