using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    public class Conversion
    {
        bool validinput = false;
        float decinput;
        string input;
        float temp;
        public bool shouldRepeat = true;
        public bool validInput = false;
        public Conversion()
        {
            Program PR = new Program();
            PR.Choice = 1;
        }
        public Conversion(string userinput)
        {
            getContinue();
        }
        public bool getContinue()
        {
            do
            {
                Console.Write("Do you want to continue? yes or no: ");
                
                switch (Console.ReadLine())
                {
                    case "no":
                        shouldRepeat = false;
                        validInput = true;
                        break;

                    case "yes":
                        shouldRepeat = true;
                        validInput = true;
                        break;
                }
            }
            while (!validInput);
            return shouldRepeat;
        }
        public double ConvertCelciusToFahrenheit()
        {
            
            Console.Write("Enter the temperature in Celcius so I can covnert it to Fahrenheit for you: ");
            do
            {
                input = Console.ReadLine();
                decinput = float.Parse(input);
               
                if (decinput >= 0)
                {
                    temp = (float)decinput * (float)1.8 + (float)32;
                    Console.Write("The temperature from Celcius to Farenheit is: {0}", temp);
                    Console.WriteLine();
                    shouldRepeat = getContinue();
                    validinput = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Enter Valid Number");
                    validinput = false;
                }
            } while (validinput != true);
            return temp;


        }

        public double ConvertFahrenheitToCelsius()
        {
            Console.Write("Enter the temperature in Fahrenheit so I can convert it to Celsius for you: ");

            do
            {
                input = Console.ReadLine();
                decinput = float.Parse(input);

                if (decinput >= 0)
                {
                    temp = ((float)decinput - (float)32) / (float)1.8;

                    Console.Write("The temperature from Farenheit to Celcius is: {0}", temp);
                    Console.WriteLine();
                    shouldRepeat = getContinue();
                    validinput = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Enter Valid Number");
                    validinput = false;
                }
            } while (validinput != true);
            return temp;
            
        }
        public double ConvertCelciusToKelvin()
        {
            Console.Write("Enter the temperature in Celcius so I can convert it to Kelvin for you: ");

            do
            {
                input = Console.ReadLine();
                decinput = float.Parse(input);

                if (decinput >= 0)
                {
                    temp = ((float)decinput - (float)273.15);

                    Console.Write("The temperature from Celcius to Kelvin is: {0}", temp);
                    Console.WriteLine();
                    shouldRepeat = getContinue();
                    validinput = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Enter Valid Number");
                    validinput = false;
                }
            } while (validinput != true);
            return temp;
            
        }
        public double ConvertKelvinToFahrenheit()
        {
            Console.Write("Enter the temperature in Kelvin so I can convert it to Fahrenheit for you: ");

            do
            {
                input = Console.ReadLine();
                decinput = float.Parse(input);

                if (decinput >= 0)
                {
                    temp = ((float)decinput - (float)273.15) * (float)1.8 + (float)32;

                    Console.Write("The temperature from Kelvin to Fahrenheit is: {0}", temp);
                    Console.WriteLine();
                    shouldRepeat = getContinue();
                    validinput = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Enter Valid Number");
                    validinput = false;
                }
            } while (validinput != true);
            return temp;
           
        }
        public double ConvertKelvinToCelsius()
        {
            Console.Write("Enter the temperature in Kelvin so I can convert it to Celcius for you: ");

            do
            {
                input = Console.ReadLine();
                decinput = float.Parse(input);

                if (decinput >= 0)
                {
                    temp = ((float)decinput - (float)273.15);

                    Console.Write("The temperature from Kelvin to Celcius is: {0}", temp);
                    Console.WriteLine();
                    shouldRepeat = getContinue();
                    validinput = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Enter Valid Number");
                    validinput = false;
                }
            } while (validinput != true);
            return temp;

            
        }
        public double ConvertFahrenheitToKelvin()
        {
            Console.Write("Enter the temperature in Fahrenheit so I can convert it to Kelvin for you: ");

            do
            {
                input = Console.ReadLine();
                decinput = float.Parse(input);

                if (decinput >= 0)
                {
                    temp = ((float)decinput * ((float)5 / (float)9)) + (float)459.67;

                    Console.Write("The temperature from Farenheit to Kelvin is: {0}", temp);
                    Console.WriteLine();
                    shouldRepeat = getContinue();
                    validinput = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Enter Valid Number");
                    validinput = false;
                }
            } while (validinput != true);
            return temp;
        }

    }
}
