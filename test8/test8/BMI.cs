using System;

namespace calculator
{
	public class BMI
	{
		public void BmiCalc ()
		{
			Console.WriteLine ("\nBMI CALCULATOR");
			Console.WriteLine ("==============");
			Console.WriteLine ("\nInsert weigth in Kg: ");

			int kg = Convert.ToInt32 (Console.ReadLine ());

			Console.WriteLine ("\nInsert heigth in cm: ");

			int m = Convert.ToInt32 (Console.ReadLine ());

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