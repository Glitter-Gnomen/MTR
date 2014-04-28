using System;

namespace calculator
{
	public class modulus : MainClass
	{
		public void modulo (double input1, double input2)
		{
			double result;

			Console.WriteLine (input1 % input2);
			result = input1 % input2;
			InversPolishNotation IPN = new InversPolishNotation ();
			IPN.Calcs (result);
		}
	}
}