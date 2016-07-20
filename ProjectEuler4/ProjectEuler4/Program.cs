using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool pal = false;
            int palindrome = 0;
            Program p = new Program();

            //These two for loops allow us to check every sum of all three digit numbers
            for (int x = 999; x > 100; x--)
            {
                for (int y = 999; y > 100; y--)
                {
                    pal = p.PalCheckProduct(x, y);

                    //If the sum is a palindrome check and see if it's larger than the one found before it and if so replace the last palindrome
                    if (pal)
                    {
                        if(x * y > palindrome)
                        {
                            palindrome = x * y;
                        }
                    }
                }
            }

            Console.WriteLine(palindrome);

            Console.ReadLine();
        }

        bool PalCheckProduct(int x, int y)
        {
            string check = (x * y).ToString();
            bool checkResult = true; // This bool is innocent untill proven guilty!

            //Iterate through the Sum and if the numbers don't match then set the result to false.
            for(int i = 0; i < check.Length; i++)
            {
                if(check[i] != check[check.Length - (i + 1)])
                {
                    checkResult = false; //Guilty!
                }
            }

            return checkResult;
        }
    }
}
