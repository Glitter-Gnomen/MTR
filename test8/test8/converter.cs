using System;

namespace calculator
{
	public class converter : MainClass
	{
		public void converterMenu ()
		{
			Console.WriteLine ("\n UNIT CONVERTER \n\n---------\n\n Choose a type of conversion: \n\n 1) Temperature from fahrenheit to celsius \n 2) Temperature from celsius to fahrenheit \n 3) Speed from km/h to miles/h \n 4) Speed from miles/h to km/h ");
			int key = Convert.ToInt32 (Console.ReadLine ());

			extension ext = new extension ();
			switch (key) {
			case 1:
				//Convert temperature from fahrenheit to celsius
				FahrenheitToCelsiusTemp ();
				converterMenu ();
				break;
			case 2:
				//Convert temperature from celsius to fahrenheit
				CelsiusToFahrenheitTemp ();
				converterMenu ();
				break;
			case 3:
				//Convert speed from kilometers per hour to miles per hour
				KmPerHourToMilesPerHour ();
				converterMenu ();
				break;
			case 4:
				//Convert speed from miles per hour to kilometers per hour
				MilesPerHourToKmPerHour ();
				converterMenu ();
				break;
			case 5:
				Length ();
				converterMenu ();
				switch (key) {
				case 1:
					CentimetersToMeters ();
					converterMenu ();
					break;
				case 2:
					CentimetersToKilometers ();
					converterMenu ();
					break;
				case 3:
					MetersToCentimeters ();
					converterMenu ();
					break;
				case 4:
					MetersToKilometers ();
					converterMenu ();
					break;
				case 5: 
					KilometersToCentimeters ();
					converterMenu ();
					break;
				case 6:
					KilometersToMeters ();
					converterMenu ();
					break;
				}
				break;
			}
		}

		public void FahrenheitToCelsiusTemp ()
		{
			double celsius;
			Console.WriteLine ("Please enter a temperature in fahrenheit: ");
			double fahrenheitToCelsius = Convert.ToDouble (Console.ReadLine ());
			celsius = (fahrenheitToCelsius - 32) * 5 / 9;
			Console.WriteLine ("The temperature: " + fahrenheitToCelsius + " fahrenheit is the same as: " + celsius + " degrees celsius!");
		}
		public void CelsiusToFahrenheitTemp ()
		{
			double fahrenheit;
			Console.WriteLine ("\nPlease enter a temperature in celsius: ");
			double celsiusToFahrenheit = Convert.ToDouble (Console.ReadLine ());
			fahrenheit = (celsiusToFahrenheit * 9 / 5 + 32);
			Console.WriteLine ("The temperature: " + celsiusToFahrenheit + " celsius is the same as: " + fahrenheit + " fahrenheit!");
		}
		public void KmPerHourToMilesPerHour ()
		{
			double mph;
			Console.WriteLine ("\nPlease enter a speed in kilometers per hour: ");
			double kphTomph = Convert.ToDouble (Console.ReadLine ());
			mph = (kphTomph / 1.6093);
			Console.WriteLine ("The speed: " + kphTomph + " kilometers per hour is the same as: " + mph + " miles per hour!");
		}
		public void MilesPerHourToKmPerHour ()
		{
			double kph;
			Console.WriteLine ("\nPlease enter a speed in miles per hour: ");
			double mphToKph = Convert.ToDouble (Console.ReadLine ());
			kph = (mphToKph * 1.6093);
			Console.WriteLine ("The speed: " + mphToKph + " miles per hour is the same as: " + kph + " kilometers per hour!");
		}
		public void Length ()
		{
			Console.WriteLine ("\n 1) Centimeters to meters \n 2) Centimeters to kilometers \n 3) Meters to centimeters \n 4) Meters to kilometers \n 5) Kilometers to centimeters \n 6) Kilometers to meters");
			int key = Convert.ToInt32 (Console.ReadLine ());

		}
		public void CentimetersToMeters ()
		{
			double m;
			Console.WriteLine ("\nPlease enter a length in centimeters: ");
			double cmToM = Convert.ToDouble (Console.ReadLine ());
			m = (cmToM / 100);
			Console.WriteLine ("The length: " + cmToM + " centimeters is the same as: " + m + " meters!");
		}
		public void CentimetersToKilometers ()
		{
			double km;
			Console.WriteLine ("\nPlease enter a length in centimeters: ");
			double cmToKm = Convert.ToDouble (Console.ReadLine ());
			km = (cmToKm / 100000);
			Console.WriteLine ("The length: " + cmToKm + " centimeters is the same as: " + km + " kilometers!");
		}
		public void MetersToCentimeters ()
		{
			double cm;
			Console.WriteLine ("\nPlease enter a length in meters: ");
			double mToCm = Convert.ToDouble (Console.ReadLine ());
			cm = (mToCm * 100);
			Console.WriteLine ("The length: " + mToCm + " meters is the same as: " + cm + " centimers!");
		}
		public void MetersToKilometers ()
		{
			double km;
			Console.WriteLine ("\nPlease enter a length in meters: ");
			double mToKm = Convert.ToDouble (Console.ReadLine ());
			km = (mToKm / 1000);
			Console.WriteLine ("The length: " + mToKm + " meters is the same as: " + km + " kilometers!");
		}
		public void KilometersToCentimeters ()
		{
			double cm;
			Console.WriteLine ("\nPlease enter a length in kilometers: ");
			double kmToCm = Convert.ToDouble (Console.ReadLine ());
			cm = (kmToCm * 100000);
			Console.WriteLine ("The length: " + kmToCm + " kilometers is the same as: " + cm + " centimers!");
		}
		public void KilometersToMeters ()
		{
			double m;
			Console.WriteLine ("\nPlease enter a length in kilometers: ");
			double kmToM = Convert.ToDouble (Console.ReadLine ());
			m = (kmToM * 1000);
			Console.WriteLine ("The length: " + kmToM + " kilometers is the same as: " + m + " meters!");
		}
	}
}