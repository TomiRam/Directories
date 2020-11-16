using System;
using static.System.Console;

namespace CopyADirectory
{ 
	class Program 
	{
		static void Main(string[] args)
		{
			string path = AppDomain.CurrentDomain.BaseDirectory + "data";
			string pathCopy = path + "_copy";
			try{
				Directory.CreateDirectory(pathCopy);

				//Create all of the directories
				foreach(string dirPath in Directory.GetDirectories(path,"*",
						SearchOption.AllDirectories))
				Directory.CreateDirectory(dirPath.Replace(path, pathCopy));

				//Copy all the files & Replaces any files with nthe same name
				foreach(string newPath in Directory.GetFiles(path, "*.*",
						SearchOption.AllDirectories))
				File.Copy(newPath, newPath.Replace(path, pathCopy),true);

				Writeline("successfully copied");

				}
			catch(Exeception e){
				Writeline(e.Message);
			}
		}

	}
}