using System;
using System.Diagnostics;

namespace Oscs
{
	public class OsShell
	{
		private Process CurrentProcess;

		/*
			Starts the os shell program and returns its process : 

			Defaults : 
				Default Working Directory is the current directory of the program.
				Default Argument is empty string .
				By Default , the UseShellExecute is true


			fName = fileName (the name of the program to be executed)
			args is the arguments to be passed to the program during execution in the shell
			wkDir is the working directory of the program during execution.
			useShell is whether the program provided should be executed in a shell process.

			
		*/

		
		public Process Launch(string fName , string args = "" , string wkDir = "./" , bool useShell = true)
		{
			// create instance of the processstartinfo class. 
			// It will set the parameters of the program that will be launched :
			ProcessStartInfo pInfo = new ProcessStartInfo();
			pInfo.FileName = fName;
			pInfo.Arguments = args;
			pInfo.WorkingDirectory = wkDir;
			pInfo.UseShellExecute = useShell;


			// start the process
			CurrentProcess = Process.Start(pInfo);

			// return the current process
			return CurrentProcess;
		}
		/*
		*/




		/*
			Stops the processes that have been opened by the instance of the OsShell Class.
		*/
		public void Stop()
		{
			CurrentProcess.Close();
		}
		
		/*
		*/
	}
		
}
