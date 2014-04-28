using System;

namespace calculator
{
	public class dept
	{
		public void Debt ()
		{
			//Text introducing the program

			Console.WriteLine ("\nDEBT CALCULATOR");
			Console.WriteLine ("===============");

			//1st instruction
			Console.WriteLine ("\nHow much do you owe? Only whole numbers, please.\n");

			//Taking a string input and converts it to int stored in 'save'

			int owe = Convert.ToInt32 (Console.ReadLine ());

			Console.WriteLine ("\nThank you. What is the rate on the loan in percent?\n");

			double owe_rate = Convert.ToDouble (Console.ReadLine ());

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
				savingsMenu class2 = new savingsMenu ();
				class2.MenuMads ();
			}
		}
	}
}