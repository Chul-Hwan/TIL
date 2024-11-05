using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Programers
{
    internal class Mockexam
    {
        public int[] Solution(int[] answers)
        {
            int[] answer;
            int[] count = new int[3];

            int[] pattern1 = new int[] {1, 2, 3, 4, 5};
            int[] pattern2 = new int[] {2, 1, 2, 3, 2, 4, 2, 5 };
            int[] pattern3 = new int[] {3, 3, 1, 1, 2, 2, 4, 4, 5, 5};

            for(int i = 0; i < answers.Length; i++)
            {
                count[0] += (answers[i] == pattern1[i % pattern1.Length]) ? 1 : 0;
                count[1] += (answers[i] == pattern2[i % pattern2.Length]) ? 1 : 0;
                count[2] += (answers[i] == pattern3[i % pattern3.Length]) ? 1 : 0;
            }

            answer = count.Select((i, index) => new {Value = i, Index = index + 1})
                .Where( x => x.Value == count.Max())
                .Select(x => x.Index)
                .ToArray();

            return answer;
        }
    }
}
