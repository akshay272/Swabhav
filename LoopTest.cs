using System;

public class LoopTest{
	
	public static void CheckDay(int dayNumber){
		Console.WriteLine("*** Switch Case ***");
		switch(dayNumber){
			case '1' : Console.Write("Sunday");
				break;
			case '2' : Console.Write("Monday");
				break;
			case '3' : Console.Write("Tuesday");
				break;
			case '4' : Console.Write("Wednesday");
				break;
			case '5' : Console.Write("Thursday");
				break;
			case '6' : Console.Write("Friday");
				break;
			case '7' : Console.Write("Saturday");
				break;
			default : Console.Write("invalid input");
				break;
		}
		Console.WriteLine("");
	}

	public static void CheckHoliday(int dayNumber){
		Console.WriteLine("*** if else Loop ***");
		if(dayNumber == 1){
			Console.WriteLine("Hurrey...its Holiday");
		}
		else if (dayNumber >=2 || dayNumber <= 6){
			Console.WriteLine("its working day");
		}
		else if (dayNumber == 7){
			Console.WriteLine("Half day");
		}
	}

	public static void MultiplyTable(int num){
		Console.WriteLine("\n *** Table is created using For Loop ****");
		Console.WriteLine("Table of " + num +" :");
		for(int i=1; i<=10; i++){
			Console.WriteLine(num + " * "+ i +" = "+ (num * i));
		}
	}

	public static void PrintArray(int[] arr){
		Console.WriteLine("Elements print using foreach Loop");
		foreach(int i in arr){
			Console.Write(i +" ");
		}
	}

	public static void Main(string[] args){
		
		Console.WriteLine("Enter the Number from 1-7");
		int dayNumber = Console.Read();
		CheckDay(dayNumber);
		CheckHoliday(dayNumber);
		int num = 8;

		//Generate Table using for Loop
		MultiplyTable(num);
		
		//creating Array
		int[] arr = new int[6] {45,7,55,98,1,24};
		
		//Array print by forEach Loop
		PrintArray(arr);
	}

}