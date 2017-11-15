using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ProgrammingFundamentalsAnonymousDownsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWebsites = int.Parse(Console.ReadLine());

            int securityKey = int.Parse(Console.ReadLine());
            decimal totalLoss = 0;

            for (int i = 0; i < numberOfWebsites; i++)
            {
                string[] websites = Console.ReadLine().Split();
                string siteName = websites[0];

                decimal siteVisits = decimal.Parse(websites[1]);
                decimal siteCommercialPricePerVisit = decimal.Parse(websites[2]);
                decimal siteLoss = siteVisits * siteCommercialPricePerVisit;

                totalLoss += siteLoss;
                Console.WriteLine(siteName);

            }
            Console.WriteLine($"Total loss: {totalLoss:F20}");
            Console.WriteLine($"Security token: {BigInteger.Pow(securityKey, numberOfWebsites)}");
        }
    }
}
