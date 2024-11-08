using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programers
{
    /// <summary>
    /// 특수케이스를 대응하는 코드를 만들었다면 코드를 수정하고 나서 다시 한 번 확인할 것.
    /// </summary>
    internal class OvertimeIndex
    {
        public long Solution(int n, int[] works)
        {
            int currentIndex = 0;
            int current = int.MinValue;
            long answer = 0;

            Array.Sort(works);
            Array.Reverse(works);

            while ( n > 0 )
            {
                currentIndex = currentIndex % works.Length;
                var nextIndex = currentIndex + 1;

                if (works[currentIndex] != 0)
                {
                    current = --works[currentIndex];
                }

                // nextIndex가 works의 범위를 넘어섰을 때,
                // 다음 값보다 현재 값이 더 크거나 같을 경우 처음부터 계산하도록 함. 
                if (nextIndex == works.Length || current >= works[nextIndex])
                {
                    currentIndex = 0;
                }
                else if (current < works[nextIndex])
                {
                    currentIndex = nextIndex;
                }

                n--;
            }

            answer = (long) works.Select(i=> Math.Pow(i, 2)).Sum();
            return answer;
        }
    }
}
