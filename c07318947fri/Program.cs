using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c07318947fri
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    class UsingRecursion
    {
        public static int CalculateRecursively(int n, int m)
        {
            int sum = n;

            if (n < m)
            {
                n++;
                return sum += CalculateRecursively(n, m);
            }
            return sum;
        }

    }
}
