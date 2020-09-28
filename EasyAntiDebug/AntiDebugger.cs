using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace EasyAntiDebug
{
   
    public class AntiDebugger
    {
        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        private static extern bool CheckRemoteDebuggerPresent(IntPtr ProcessHandle, ref bool isDebugging);

        public static bool isDebugging()
        {
            bool isDebugging = false;
            CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, ref isDebugging);

            if (isDebugging)
            {
                return true;
            }

            return false;
        }
    }
}
