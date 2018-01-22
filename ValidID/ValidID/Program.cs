using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidID
{
    class Program
    {
        static void Main(string[] args)
        {
            int idNum;
            String input;
            const int LOW = 1000;
            const int HIGH = 9999;

            Console.WriteLine("Enter an ID number: ");
            input = System.Console.ReadLine();
            idNum = Convert.ToInt32(input);

        }
    }
}
