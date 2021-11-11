using System;

class CmdLineArgs{
	static void Main(string[] args){
		Console.WriteLine(args.Length);
		for (int i=0; i<args.Length; i++){
			Console.WriteLine(args[i]);
		}
	}
}