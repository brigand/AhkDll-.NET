using System;
using System.Runtime.InteropServices;

namespace AhkWrapper
{
    /// <summary>
    /// A class for wrapping native Win32 api functions.  Internal use only.
    /// </summary>
    internal class Win32
    {
        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        internal static extern IntPtr LoadLibrary(string lpLibFileName);
    }
}
