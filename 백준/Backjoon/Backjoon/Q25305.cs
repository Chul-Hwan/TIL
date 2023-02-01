using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon
{
    internal class Q25305
    {
        // https://stackoverflow.com/a/31970619
        public void Apply()
        {
            int count;
            int rank;

            string info = Console.ReadLine();
            string[] infoSplit = info.Split(' ');

            count = int.Parse(infoSplit[0]);
            rank = int.Parse(infoSplit[1]);

            string score = Console.ReadLine();
            string[] scoreList = score.Split(' ');

            // ThenByDescending 두 번째 이후의 정렬기준이라고 보면 된다.
            var scoreList2 = scoreList.OrderByDescending(x => x.Length).ThenByDescending(x => x).ToList();
            Console.WriteLine(scoreList2[rank - 1]);
        }
    }

/*
using System;
using System.Linq;
using System.Collections.Generic;

namespace 백준
{
    internal class Program
    {
        static void Main(string[] args)
        {
        	int count;
            int rank;

            string info = Console.ReadLine();
            string[] infoSplit = info.Split(' ');

            count = int.Parse(infoSplit[0]);
            rank = int.Parse(infoSplit[1]);

            string score = Console.ReadLine();
            string[] scoreList = score.Split(' ');

            var scoreIntList = scoreList.OrderByDescending(s => s.Length).ThenByDescending(s=>s).ToList();

            Console.WriteLine(scoreIntList[rank -1]);
        }
    }
}
*/
}
