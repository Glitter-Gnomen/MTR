using System;

namespace test8
{
	public class division : MainClass
	{
		public void dividing(double input1, double input2)
		{
			double result;

			Console.WriteLine(input1 / input2);
			result = input1 / input2;
			extension ext = new extension();
			ext.Calcs(result);
		}
	}
}