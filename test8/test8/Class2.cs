using System;
using System.IO;
using System.Text;

namespace test8
{
	public class Class2
	{

		public static void MenuMads (){
			Console.WriteLine ("Welcome to the CALCULATOR OF INTERESTS!\n\nWhich option would you like to choose? Write chosen no. and press enter." +
				"\n\n1) Calculate savings\n2) Calculate debts\n\n3) BMI Calc\n");

			int key = Convert.ToInt32(Console.ReadLine ());

			switch (key)
			{
			case 1:

				Console.WriteLine ("\nShould that be...\n\n1) A single saving, or \n2) Multiple identical savings?\n3) Multiple varying savings");

				string key2 = Console.ReadLine();

				if (key2 == "1") {
					Savings ();
				}
				if (key2 == "2") {
					SavingsMultiple ();
				}
				if (key2 == "3") {
					SavingsTriple ();
				}
				break;

			case 2:
				Debt ();
				break;
			case 3:
				BmiCalc ();
				break;
			case 4:

				//In this section I read a text document and write it to the consol

				//The try-catch statement consists of a try block followed by one or more catch clauses, which specify handlers for different exceptions.
				try
				{

					//StreamReader implements a TextReader that reads characters from a byte stream in a particular encoding.
					using (StreamReader sr = new StreamReader("texttest.txt"))
					{
						String line = sr.ReadToEnd();
						Console.WriteLine(line);
					}
				}
				catch (Exception e)
				{
					Console.WriteLine("The file could not be read:");
					Console.WriteLine(e.Message);
				}
				break;
			default:
				Console.WriteLine ("Default");
				break;
			}
		}

		public static void Savings (){

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
				Savings ();
			}

			if (key == "2") {
				//Whipes the terminal
				Console.Clear ();
				MenuMads ();
			}
		}

		public static void SavingsMultiple (){

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
				MenuMads ();
				Console.WriteLine ();
			}

		}

		public static void SavingsTriple (){


		}

		public static void Debt (){
			//Text introducing the program

			Console.WriteLine("\nDEBT CALCULATOR");
			Console.WriteLine("===============");

			//1st instruction
			Console.WriteLine("\nHow much do you owe? Only whole numbers, please.\n");

			//Taking a string input and converts it to int stored in 'save'

			int owe = Convert.ToInt32 (Console.ReadLine ());

			Console.WriteLine ("\nThank you. What is the rate on the loan in percent?\n");

			double owe_rate = Convert.ToDouble (Console.ReadLine());

			owe_rate = owe_rate * 0.01;

			Console.WriteLine ("\nNow enter in how many terms you are going to pay your debt back:\n");

			int owe_terms = Convert.ToInt32 (Console.ReadLine ());

			double debtPMT = owe * (owe_rate / (1 - Math.Pow ((1 + owe_rate), owe_terms * -1)));

			Console.WriteLine ("\nThe amount you should pay every term:\n");

			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine (debtPMT);

			Console.ForegroundColor = ConsoleColor.Black;

			//Lastly, we give the user the option of trying again and going back
			Console.WriteLine ("\nWould you like to (1) try again or (2) go back?");

			string key = Console.ReadLine ();

			if (key == "1") {
				Debt ();
			}

			if (key == "2") {
				Console.Clear ();
				MenuMads ();
			}

		}

		public static void BmiCalc (){

			Console.WriteLine("\nBMI CALCULATOR");
			Console.WriteLine("==============");

			Console.WriteLine("\nInsert weigth in Kg: ");

			int kg = Convert.ToInt32 (Console.ReadLine());

			Console.WriteLine ("\nInsert heigth in cm: ");

			int m = Convert.ToInt32 (Console.ReadLine());

			double BMI = kg / ((m / 100.0) * (m / 100.0));

			BMI = Math.Round (BMI, 2);

			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine ();
			Console.WriteLine ("BMI: " + BMI);
			Console.ForegroundColor = ConsoleColor.Black;

			if (BMI <= 18.5) {
				Console.WriteLine ("\n18.5-: Youre a skinny bitch, girl");
			}
			if (BMI > 18.5 && BMI <= 25) {
				Console.WriteLine ("\n18.5-25: Youre an average, boring tard, my frined");
			}
			if (BMI > 25 && BMI <= 30) {
				Console.WriteLine ("Description:\n25-30: My man, ur so fat you could be a cuddle-bear");
			}
			if (BMI > 30) {
				Console.WriteLine ("\n30+: Youre so fat your neck looks like a pack of sausages, man");
			}


			//Console.WriteLine ("Your BMI is: " + (weigth/(float)Math.Pow(heigth, 2)));

		}
	}
}

