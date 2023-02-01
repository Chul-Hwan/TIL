using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon
{
    internal class Q2750
    {
        public void Apply()
        {
            int length = int.Parse(Console.ReadLine());
            List<int> input = new List<int>();

            for (int i = 0; i < length; i++)
            {
                input.Add(int.Parse(Console.ReadLine()));
            }

            input.Sort();

            foreach (int value in input)
            {
                Console.WriteLine(value);
            }
        }
    }
}
