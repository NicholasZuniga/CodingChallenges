using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            int n2 = 1;
            int n3 = 0;
            int sum = 0;

            while (n3 < 4000000)
            {
                n3 = n + n2;

                if (n3 % 2==0)
                {
                    sum += n3;
                }

                n = n2;
                n2 = n3;

            }
            Console.WriteLine(sum);
        }
    }
}

