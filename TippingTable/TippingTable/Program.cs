using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TippingTable
{
    class Program
    {
        static void Main(string[] args)
        {
            double dinnerPrice = 10.00;
            double tipRate;
            double tip;
            const double LOWRATE = 0.10;
            const double MAXRATE = 0.25;
            const double TIPSTEP = 0.05;
            const double MAXDINNER = 100.00;
            const double DINNERSTIP = 10.00;

            Console.WriteLine("Price");
            for(tipRate = LOWRATE; tipRate <= MAXRATE; tipRate += TIPSTEP)
                Console.WriteLine("{0, 8}", tipRate.ToString("F"));
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------");
            tipRate = LOWRATE;
            while (dinnerPrice <= MAXDINNER)
            {
                Console.WriteLine("{0, 8}", dinnerPrice.ToString("C"));
                while(tipRate <= MAXRATE)
                {
                    tip = dinnerPrice * tipRate;
                    Console.WriteLine("{0, 8}", tip.ToString("F"));
                    tipRate += TIPSTEP;
                }
                dinnerPrice += DINNERSTIP;
                tipRate = LOWRATE;
                Console.WriteLine();

            }
        }
    }
}
