using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Action;
            int firstValue = 0;
            int secondValue = 0;

            Console.WriteLine("Enter First Number");

            firstValue = int.Parse(Console.ReadLine());
            Console.WriteLine("press 1 for addition");
            Console.WriteLine("press 2 for substraction");
            Console.WriteLine("press 3 for Multiplication");
            Console.WriteLine("press 4 for Devidetion");

            Action = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");

            secondValue = int.Parse(Console.ReadLine());

            int result = 0;
            Program obja = new Program();

            switch (Action)
            {
                case 1:
                    result = obja.addition(firstValue, secondValue);
                    Console.WriteLine(result);
                    break;

                case 2:
                    result = obja.substraction(firstValue, secondValue);
                    Console.WriteLine(result);
                    break;


                case 3:
                    result = obja.Multiplication(firstValue, secondValue);
                    Console.WriteLine(result);
                    break;

                case 4:
                    result = obja.Devidetion(firstValue, secondValue);
                    Console.WriteLine(result);
                    break;
            }

        }

        private int addition(int firstV, int secondV)
        {
            int result = 0;

            result = firstV + secondV;

            return result;
        }

        private int substraction(int firstV, int secondV)
        {
            int result = 0;

            result = firstV - secondV;

            return result;
        }

        private int Multiplication(int firstV, int secondV)
        {
            int result = 0;

            result = firstV * secondV;

            return result;
        }

        private int Devidetion(int firstV, int secondV)
        {
            int result = 0;

            result = firstV / secondV;

            return result;
        }

    }
}
