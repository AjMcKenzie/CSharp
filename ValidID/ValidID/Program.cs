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

            while(idNum < LOW || idNum > HIGH)
            {
                Console.WriteLine("{0} is an invalid ID number" , idNum);
                Console.WriteLine("ID numbers must be ");
                Console.WriteLine("between {0} and {1} inclusive", LOW, HIGH);
                Console.WriteLine("Enter an ID number: ");
                input = Console.ReadLine();
                idNum = Convert.ToInt32(input);
            }
            Console.WriteLine("ID number {0} is valid", idNum);

        }
    }
}
