using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Multifus
{
    

    class ForegroundWindowBypass //by VollRagm
    {

		public static void Set(IntPtr hWnd)
		{
			uint curerntThreadId = Native.GetCurrentThreadId();	//get current ThreadId
			IntPtr hForegroundWindow = Native.GetForegroundWindow();
			uint activeThread = Native.GetWindowThreadProcessId(hForegroundWindow, out uint foregroundThreadId);	//get current foreground ThreadId;
			uint windowThread = Native.GetWindowThreadProcessId(hWnd, out uint targetThreadId);	//get target window ThreadId

			if (curerntThreadId != activeThread)	//If the current program is not in the foreground
				Native.AttachThreadInput(curerntThreadId, activeThread, true);  //attach to the current foreground window -> we are now in the foreground
            if (windowThread != curerntThreadId)    //same for the target window
                Native.AttachThreadInput(windowThread, curerntThreadId, true);

			uint lockBuffer = 0;
			uint foo = 0;
			//condition we need to meet from Microsoft Docs: The foreground lock time-out has expired
			//so lets just force this

			Native.SystemParametersInfo(Native.SPI_GETFOREGROUNDLOCKTIMEOUT, 0, ref lockBuffer, 0);	//store old lock time
			Native.SystemParametersInfo(Native.SPI_SETFOREGROUNDLOCKTIMEOUT, 0, ref foo, 0);	//set lock time to 0
			Native.LockSetForegroundWindow(2);	
			Native.AllowSetForegroundWindow(-1);	//since we are "foreground window" we can now do this, this lets every process set the foreground window

			Native.SetForegroundWindow(hWnd);	//and this
			Native.ShowWindow(hWnd, 5);	//show the target window if its minimized

			Native.SystemParametersInfo(Native.SPI_SETFOREGROUNDLOCKTIMEOUT, 0, ref lockBuffer, 0);	//reset lock time

		}
	}
}
