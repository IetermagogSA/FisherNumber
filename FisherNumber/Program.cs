using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * A Fisher number is an integer whose multipliers are equal to the number's cube. For example, 12 is a Fisher number,
 *  because 12^3 = 2 x 3 x 4 x 6 x 12.
 *  
 *  This program will accept input and check if the number is a Fisher number.
*/
namespace FisherNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            string input = Console.ReadLine();

            List<int> numbersList = new List<int>();

            bool isFishNum = IsFisherNumber(Convert.ToInt32(input), ref numbersList);

            if (isFishNum)
            {
                Console.Write(isFishNum.ToString() + " (" + input + "^3 = ");
            }
            else
            {
                Console.Write(isFishNum.ToString() + " (" + input + "^3 != ");
            }

            foreach (int i in numbersList)
            {
                if (i == numbersList[numbersList.Count - 1])
                    Console.Write(i + ")");
                else
                    Console.Write(i + " x ");
            }


            Console.ReadLine();
        }

        private static bool IsFisherNumber(int num, ref List<int> myList)
        {
            int cubeNum = num * num * num;

            int total = 1;

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0 && !myList.Contains(i))
                {
                    total *= i;
                    myList.Add(i);
                }
            }

            if (total == cubeNum)
                return true;
            else
                return false;
        }
    }
}
