using System;

namespace test8
{
	public class Savings : MainClass
	{
		public void Saver (){

			//Text introducing the program

			Console.WriteLine("\nSAVINGS CALCULATOR");
			Console.WriteLine("==================");

			//1st instruction
			Console.WriteLine("\nEnter the amount you would like to deposit: ");

			//Taking a string input and converts it to int stored in 'save'
			int save = Convert.ToInt32 (Console.ReadLine ());

			/*if (save < 0) {
				Console.WriteLine ("Number cant be negative, please try again");
			}*/

			//2nd instruction
			Console.WriteLine("\nThank you. Now insert rate in percent (use '.' for dot): ");

			//Again taking an input, converts it to a double as this variable needs to become a decimal number
			double saveRate = Convert.ToDouble (Console.ReadLine ());

			//Turns the rate, stored by the user, into a number to be used in the savings-formula
			saveRate = saveRate * 0.01;

			//3rd instruction, 3rd storing
			Console.WriteLine("\nThank you. Now insert number of terms: ");
			int termNo = Convert.ToInt32 (Console.ReadLine ());

			Console.Clear ();

			//Presents the user what has been stored
			Console.WriteLine ("Present Value: " + save + "\nRate: " + saveRate * 100.0 + "%" + "\nNo of terms: " + termNo);

			//The actual calculation, being stored into the variable PMT. The formula is: Kn = Ko * (1 + r)^n
			double PMT = save * Math.Pow ((1 + saveRate), termNo);

			//Rounds up the PMT-variable to only hold two decimals
			PMT = Math.Round (PMT, 2);

			//Makes the text stand out by coloring it green
			Console.ForegroundColor = ConsoleColor.Green;

			//This line prints the result to the terminal
			Console.WriteLine ("\nFuture Value (PMT): " + PMT);

			//Turns the text back to black
			Console.ForegroundColor = ConsoleColor.Black;

			//Lastly, we give the user the option of trying again or going back

			Console.WriteLine ("\nWould you like to...\n\n1) Try again \n2) Go back\n");

			string key = Console.ReadLine ();

			if (key == "1") {
				Saver ();
			}

			if (key == "2") {
				//Whipes the terminal
				Console.Clear ();
				Class2 class2 = new Class2 ();
				class2.MenuMads ();
			}
		}

		public void SavingsMultiple (){

			//Text introducing the program

			Console.WriteLine("\nSAVINGS CALCULATOR");
			Console.WriteLine("==================");

			//1st instruction
			Console.WriteLine("\nWrite the payment you want to continiously deposit: ");

			//Taking a string input and converts it to int stored in 'save'
			int save_m = Convert.ToInt32 (Console.ReadLine ());

			//2nd instruction
			Console.WriteLine("\nThank you. Now insert rate in percent (use '.' for dot): ");

			//Again taking an input, converts it to a double as this variable needs to become a decimal number
			double saveRate_m = Convert.ToDouble (Console.ReadLine ());

			//Turns the rate, stored by the user, into a number to be used in the savings-formula
			saveRate_m = saveRate_m * 0.01;

			//3rd instruction, 3rd storing
			Console.WriteLine("\nThank you. Now insert number of terms: ");
			int termNo_m = Convert.ToInt32 (Console.ReadLine ());

			Console.Clear ();

			//Presents the user what has been stored
			Console.WriteLine ("Present Value: " + save_m + "\nRate: " + saveRate_m * 100.0 + "%" + "\nNo of terms: " + termNo_m);

			//The actual calculation, being stored into the variable PMT. The formula is: An = b * ((1 + r)^n - 1 / r)
			double PMT_m = save_m * ((Math.Pow ((1 + saveRate_m), termNo_m) - 1) / saveRate_m);

			//Rounds up the PMT-number to only hold two decimals
			PMT_m = Math.Round (PMT_m, 2);

			//Calculates the total money deposited by multiplying the save with the no of terms
			int totalPay_m = save_m * termNo_m;

			Console.WriteLine ("Money deposited in total: " + totalPay_m);

			//This line prints the result to the terminal
			Console.WriteLine ("\nFuture Value (PMT): \n");

			Console.ForegroundColor = ConsoleColor.Green;

			Console.WriteLine (PMT_m);

			Console.ForegroundColor = ConsoleColor.Black;

			//Lastly, we give the user the option of trying again and going back through an if-statement
			Console.WriteLine ("\nWould you like to...\n\n1) Try again \n2) Go back\n");

			string key = Console.ReadLine ();

			if (key == "1") {
				SavingsMultiple ();
			}

			if (key == "2") {
				Class2 class2 = new Class2 ();
				class2.MenuMads ();
				Console.WriteLine ();
			}

		}

		public void SavingsTriple (){


		}
	}
}

