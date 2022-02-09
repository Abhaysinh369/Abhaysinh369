using System;

namespace Assignment_2
{
    class Program
    {
        public  int Choice;
        static void Main(string[] args)
        {
            
            String sInput1;
            
            Conversion cs = new Conversion();
            Conversion cs1 = new Conversion("Hello");
            Program PR = new Program();
            do
            {
                Console.WriteLine("This program converts temperatures between Celsius and Fahrenheit.\n");
                Console.WriteLine("Which do you want to convert:");
                Console.WriteLine("1. Celsius to Fahrenheit");
                Console.WriteLine("2. Celsius to Kelvin\n");
                Console.WriteLine("3. Kelvin to Fahrenheit\n");
                Console.WriteLine("4. Kelvin to Celsius\n");
                Console.WriteLine("5. Fahrenheit to Kelvin\n");
                Console.WriteLine("6. Fahrenheit to Celsius\n");
                Console.WriteLine("7. Exit\n");

                Console.Write("Enter 1 or 2 for your choice: ");
                sInput1 = Console.ReadLine();
                PR.Choice = Int32.Parse(sInput1);

                switch (PR.Choice)
                {
                    case 1:
                        cs.ConvertCelciusToFahrenheit();
                        break;

                    case 2:
                        cs.ConvertCelciusToKelvin();
                        break;
                    case 3:
                        cs.ConvertKelvinToFahrenheit();
                        break;
                    case 4:
                        cs.ConvertKelvinToCelsius();
                        break;
                    case 5:
                        cs.ConvertFahrenheitToKelvin();
                        break;
                    case 6:
                        cs.ConvertFahrenheitToCelsius();
                        break;
                    case 7:
                        cs.shouldRepeat = false;
                        cs.validInput = true;
                        break;

                }
            } while (cs.shouldRepeat);
            Console.WriteLine("Goodbye!!!");
            
        }
    }
}