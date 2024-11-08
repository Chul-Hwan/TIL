using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programers
{
    internal class GetMinTotal
    {
        public int Solution(int[] A, int[] B)
        {
            int answer = 0;

            // 3, 1 비교 시 
            // 오름차순 시 3,1 -> CompareTo = 1 -> i1이 i2보다 뒤에 위치해 있다는 의미이므로 i1의 위치를 i2 위치로 -> 1, 3
            // 내림차순 시 3,1 -> CompareTo = -1 -> i1이 i2보다 앞에 있다는 의미이므로 위치는 그대로 -> 3, 1

            Array.Sort(A);
            Array.Sort(B, comparison: new Comparison<int>((i1, i2) => i2.CompareTo(i1)));
            
            for(int i = 0; i < A.Length; i++)
            {
                answer += A[i] * B[i];
            }
           
            return answer;
        }
    }
}
