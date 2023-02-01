using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon
{
    internal class Q2587
    {
        public void Apply()
        {
            List<int> values = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                values.Add(int.Parse(Console.ReadLine()));
            }

            values.Sort();
            int average = (int) values.Average();
            int centerValue = values[2];

            Console.WriteLine(average);
            Console.WriteLine(centerValue);
        }
    }
}
