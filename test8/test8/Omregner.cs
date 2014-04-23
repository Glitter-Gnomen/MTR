using System;

namespace test8
{
	public class Omregner
	{
		public static void OmregnerMain (string[] args)
		{
			TheMenu ();
		}
		//Created a menu in a switch statement, so that the user can choose which type of conversion to use
		public static void TheMenu () {
			Console.WriteLine("\n UNIT CONVERTER \n\n---------\n\n Choose a type of conversion: \n\n 1) Temperature from fahrenheit to celsius \n 2) Temperature from celsius to fahrenheit \n 3) Speed from km/h to miles/h \n 4) Speed from miles/h to km/h ");
			int key = Convert.ToInt32 (Console.ReadLine ());


			switch (key) {

			case 1:

				//Convert temperature from fahrenheit to celsius
				FahrenheitToCelsiusTemp ();

				TheMenu ();

				break;

			case 2:

				//Convert temperature from celsius to fahrenheit
				CelsiusToFahrenheitTemp ();

				TheMenu ();

				break;

			case 3:

				//Convert speed from kilometers per hour to miles per hour
				KmPerHourToMilesPerHour ();

				TheMenu ();

				break;

			case 4:

				//Convert speed from miles per hour to kilometers per hour
				MilesPerHourToKmPerHour ();

				TheMenu ();
				break;

			}
		}

		public static void FahrenheitToCelsiusTemp(){
			double celsius;
			Console.WriteLine ("Please enter a temperature in fahrenheit: ");
			double fahrenheitToCelsius = Convert.ToDouble (Console.ReadLine ());
			celsius = (fahrenheitToCelsius - 32) * 5 / 9;
			Console.WriteLine ("The temperature: " + fahrenheitToCelsius + " fahrenheit is the same as: " + celsius + " degrees celsius!");

		}
		public static void CelsiusToFahrenheitTemp(){
			double fahrenheit;
			Console.WriteLine ("\nPlease enter a temperature in celsius: ");
			double celsiusToFahrenheit = Convert.ToDouble (Console.ReadLine ());
			fahrenheit = (celsiusToFahrenheit * 9 / 5 + 32);
			Console.WriteLine ("The temperature: " + celsiusToFahrenheit + " celsius is the same as: " + fahrenheit + " fahrenheit!");

		}
		public static void KmPerHourToMilesPerHour(){
			double mph;
			Console.WriteLine ("\nPlease enter a speed in kilometers per hour: ");
			double kphTomph = Convert.ToDouble (Console.ReadLine ());
			mph = (kphTomph / 1.6093);
			Console.WriteLine ("The speed: " + kphTomph + " kilometers per hour is the same as: " + mph + " miles per hour!");

		}
		public static void MilesPerHourToKmPerHour(){
			double kph;
			Console.WriteLine ("\nPlease enter a speed in miles per hour: ");
			double mphToKph = Convert.ToDouble (Console.ReadLine ());
			kph = (mphToKph * 1.6093);
			Console.WriteLine ("The speed: " + mphToKph + " miles per hour is the same as: " + kph + " kilometers per hour!");

		}
		public static void LengthConverter(){
			double centimeters;
			double meters;
			double kilometers;
			Console.WriteLine

		}

	}
}
