//Invers Polish Notation Calculator by T. L. Hagensen
//Version 1.0 for use in console

using System;

namespace test8
{
	public class MainClass
	{
		public class extension
		{
			//Used classes
			addition add = new addition ();
			subtraction sub = new subtraction ();

			//Variables
			private static double var1; //Used for input 1
			private static double var2; //Used for input 2
			private static string var3; //Used to specify the desired calculation operation


			//Main method
			public static void Main (string[] args)
			{
				//First input
				Console.WriteLine ("Input 1 here:");
				Console.WriteLine ("Enter a number: ");
				var1 = Convert.ToDouble (Console.ReadLine ());

				extension ext = new extension ();
				ext.Calcs (var1);
			}

			//Recursive method to take last input and what to do with the two inputs
			public void Calcs (double calcVar1)
			{
				//Second input
				Console.WriteLine ("Input 2 here:");
				Console.WriteLine ("Enter a number: ");
				var2 = Convert.ToDouble (Console.ReadLine ());


				//User picks desired mathematical operation
				Console.WriteLine ("Select calculation");
				var3 = (Console.ReadLine ());


				//Switch case for the different calculation operations
				switch (var3) {

				//Addition
				case "+": 
					add.adding (calcVar1, var2);
					break;

					//Subtraction
				case "-":
					sub.subbing (calcVar1, var2);
					break;
				}
			}
		}
	}
}