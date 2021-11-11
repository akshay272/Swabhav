using System;

public class ArrayTest{

	public static void PrintArray(int[] arr){
		Console.Write("Elements in Array are : ");
		
		for (int i = 0; i<arr.Length; i++){
			Console.Write(arr[i] + " ");
		}
		Console.WriteLine("");
	}
	
	public static void LastIndex(int[] arr){
		Console.WriteLine("Last Element is : " + arr[arr.Length - 1]);
	}
	
	public static void MinElement(int[] arr){
		int min = arr[0];
		
		for (int i = 1; i<arr.Length; i++){
			if(arr[i] < min){
				min = arr[i];
			}
		}
		Console.WriteLine("Minimum element is : " + min);
	}

	public static void MaxElement(int[] arr){
		int max = arr[0];
		
		for (int i = 1; i<arr.Length; i++){
			if( arr[i] > max){
				max = arr[i];
			}
		}
		Console.WriteLine("Maximum element is : " +" "+ max);
	}

	public static void Mean(int[] arr){
		int sum = 0 ;
		float mean = 0;
    		
		for (int i=0; i < arr.Length; i++){
			sum = sum + arr[i];
		}
		mean = (sum / arr.Length);
		Console.WriteLine("mean of array is : " + mean); 
	}

	
	public static void SearchElement(int[] arr, int key){
		
		bool flag = false;
		
		for (int i = 1; i<arr.Length; i++){
			if (key == arr[i]){
				flag = true;
				Console.WriteLine("Position of " + key +" is " + (i+1) +"th index");
				break;
			}
		}

		if (flag == false){
			Console.WriteLine("element not found");
		}
	}

	// Main method
	public static void Main(string[] args){
		
		//creating array
		int[] arr = new int[10] {45,78,44,1,2,65,9,87,35,12};
		int key = 9;

		//printing array elements
		PrintArray(arr);

		//finding Last element of array
		LastIndex(arr);

		//finding minimum element in array
		MinElement(arr);

		//finding maximum element in array
		MaxElement(arr);

		//finding mean of array elements
		Mean(arr);

		//searching element
		SearchElement(arr, key);
	
	}
}