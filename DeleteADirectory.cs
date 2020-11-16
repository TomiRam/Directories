using System;
using static.System.Console;

namespace DeleteADirectory
{ 
	class Program 
	{
		static void Main(string[] args)
		{
			string path = AppDomain.CurrentDomain.BaseDirectory + "data_copy";
			
			try{
				Directory.Delete(path);

				Writeline("successfully deleted");

				}
			catch(Exeception e){
				Writeline(e.Message);
			}
		}

	}
}