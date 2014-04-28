using System;
using System.IO;
using System.Text;

namespace calculator
{
	public class savingsMenu
	{
		Savings save = new Savings ();

		public void MenuSavings ()
		{
			Console.WriteLine ("Welcome to the CALCULATOR OF SAVINGS!\n\n");
			Console.WriteLine ("\nWhich option would you like to choose? Write chosen no. and press enter.\n\n1) A single saving, or \n2) Multiple identical savings?\n3) Multiple varying savings");

			string key2 = Console.ReadLine ();

				
			if (key2 == "1") {
				save.Saver ();
			}
			if (key2 == "2") {
				save.SavingsMultiple ();
			}
			if (key2 == "3") {
				save.SavingsTriple ();
			}
			//In this section I read a text document and write it to the consol

			//The try-catch statement consists of a try block followed by one or more catch clauses, which specify handlers for different exceptions.
			try {

				//StreamReader implements a TextReader that reads characters from a byte stream in a particular encoding.
				using (StreamReader sr = new StreamReader ("texttest.txt")) {
					String line = sr.ReadToEnd ();
					Console.WriteLine (line);
				}
			} catch (Exception e) {
				Console.WriteLine ("The file could not be read:");
				Console.WriteLine (e.Message);
			}
			Console.WriteLine ("Default");
		}
	}
}