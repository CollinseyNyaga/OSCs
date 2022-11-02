/*
	the following is test#1 for the Oscs.OsShell class 
	
	Whats going on ? launching the ls linux shell program and providing the option "-al":
	For windows systems , replace program name with a valid path of a program in the disk.
				example : dir program as a replacement for ls in unix based systems.

*/


using System;
using Oscs;

public class Test
{
	static void Main()
	{
		OsShell oss = new OsShell();
		string ProgramName = "ls";
		string ProgramArgs = "-al";
		string WorkingDir = "";
		bool UseTheShell = true;
		
		oss.Launch(ProgramName , ProgramArgs , WorkingDir , UseTheShell);
		
	}
}
