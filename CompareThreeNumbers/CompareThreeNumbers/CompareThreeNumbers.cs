    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareThreeNumbers
{
    class CompareThreeNumbers
    {
        static void Main(string[] args)
        {
            string numberString;
            int num1, num2, num3;

            System.Console.Write("Enter an integer ");
            numberString = System.Console.ReadLine();
            num1 = Convert.ToInt32(numberString);
            System.Console.Write("Enter an integer ");
            numberString = System.Console.ReadLine();
            num2 = Convert.ToInt32(numberString);
            System.Console.Write("Enter an integer ");
            numberString = System.Console.ReadLine();
            num3 = Convert.ToInt32(numberString);

            if (num1 == num2)
                if (num1 == num3)
                    System.Console.WriteLine("All thre numbers are equal");
                else
                    System.Console.WriteLine("First two are equal");
            else
                if (num1 == num3)
                    System.Console.WriteLine("First and last are equal");
                else
                    if (num2 == num3)
                        System.Console.WriteLine("Last two are equal");
                    else
                        System.Console.WriteLine("No two numbers are equal");
        }
    }
}
