using System;
using System.IO;
using System.Text;

namespace calculator
{
	public class MainClass
	{
		public class extension
		{
			//Variables
			private static string menuVar;//Used to select desired calculator
			private static double var1;//Used for input 1

			//Main method
			public static void Main (string[] args)
			{
				//Menu for selectin calculator of choice
				Console.WriteLine ("Choose your desired calculator:");
				Console.WriteLine ("Press 1 for Inverse Polish Notation Calculator");
				Console.WriteLine ("Press 2 for Savings Calculator");
				Console.WriteLine ("Press 3 for Dept Calculator");
				Console.WriteLine ("Press 4 for Measurement Converter");
				Console.WriteLine ("Press 5 for BMI calculator");
				menuVar = Convert.ToString (Console.ReadLine ());
			
				switch (menuVar) {
				case "1": //Invers Polish Notation
					Console.WriteLine ("Input 1 here:");//First input
					Console.WriteLine ("Enter a number: ");
					var1 = Convert.ToDouble (Console.ReadLine ());
					InversPolishNotation IPN = new InversPolishNotation ();
					IPN.Calcs (var1);
					break;
				case "2": //Savings
					savingsMenu save = new savingsMenu ();
					save.MenuMads ();
					break;
				case "3": //Dept
					dept deptInstance = new dept ();
					deptInstance.Debt ();
					break;
				case "4": //Converter
					converter Con = new converter ();
					Con.converterMenu ();
					break;
				case "5": //BMI
					BMI bmi = new BMI ();
					bmi.BmiCalc ();
					break;
				}
			}
		}
	}
}