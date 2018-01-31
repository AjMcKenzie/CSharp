using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliticalFever
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string C1;
            string C2;
            decimal NumDelegates = 0;
            decimal candidate1 = 0;
            decimal candidate2 = 0;
            decimal C1V;
            decimal C2V;
            decimal candidate3;

            Console.WriteLine("Number of delegates: ");
            input = Console.ReadLine();
            NumDelegates= Convert.ToInt32(input);

            Console.WriteLine("Candidate 1 votes: ");
            C1 = Console.ReadLine();
            candidate1 = Convert.ToDecimal(C1);

            Console.WriteLine(" Candidate 2 votes: ");
            C2 = Console.ReadLine();
            candidate2 = Convert.ToDecimal(C2);

            
            C1V = NumDelegates * candidate1;
            C2V = NumDelegates * candidate2;

            C1V = Convert.ToInt32(C1V);
            C2V = Convert.ToInt32(C2V);
            NumDelegates=Convert.ToInt32(NumDelegates);
            candidate3 = NumDelegates - (C1V + C2V);

            
            //Ex1
            //NumDelegates * C1
            //NumDelegates * C2
            //C3 = NumDelegates - (C1 + C2)
            
            //Ex2
            //NumDelegates * C1
            //NumDelegates * C2
            //C3 = NumDelegates - (C1 + C2)
            //if c3 > 15% c3 == 0

            //if AC > 15%    TV == 0
            //if C# < 50%     C# == #D
            //if C1 && C2 >= 15% || 50%   C# && c# ==TV
            //if C3 < 15%   C1 && C2 = C3/2 + c1 && C2

            //c1 =+ (c3/2)
            //c2 =+ (c3/2)
   

        }
    }
}
