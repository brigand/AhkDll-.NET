using System;
using System.Runtime.InteropServices;

namespace AhkWrapper
{
    /// <summary>
    /// These functions serve as a flat wrapper for AutoHotkey.dll.
    /// They assume AutoHotkey.dll is in the same directory as your
    /// executable.  
    /// </summary>
    public class AhkDllFlat
    {
        private const string DLLPATH = "AutoHotkey.dll";

        [DllImport(DLLPATH, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ahkdll(string Path, string Options, string Parameters);

        [DllImport(DLLPATH, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool ahkExec(string code);

        [DllImport(DLLPATH, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern void addScript(string code, byte execute);

        // Constant values for the execute parameter of addScript
        public struct Execute
        {
            public const byte Add = 0, Run = 1, RunWait = 2;
        }

        [DllImport(DLLPATH, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ahktextdll(string Code, string Options, string Parameters);

        [DllImport(DLLPATH, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool ahkReady();


        [DllImport(DLLPATH, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint addFile(string FilePath, byte AllowDuplicateInclude, byte IgnoreLoadFailure);

        /* ahkLabel and ahkFunction should be added
           but they're not a priority */

        [DllImport(DLLPATH, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool ahkassign(string VariableName, string NewValue);

        [DllImport(DLLPATH, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ahkgetvar(string VariableName, bool GetPointer);

        [DllImport(DLLPATH, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ahkTerminate(bool ForceKill);

        [DllImport(DLLPATH, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ahkReload();
    }
}
