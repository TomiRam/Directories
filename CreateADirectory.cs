using System;
using static.System.Console;

namespace CreateDirectory
{ 
	class Program 
	{
		static void Main(string[] args)
		{
			string path = AppDomain.CurrentDomain.BaseDirectory + "data";
			
			try{
				Directory.CreateDirectory(path);

				Writeline("successfully created");

				}
			catch(Exeception e){
				Writeline(e.Message);
			}
		}

	}
}