using System;

namespace Programers
{
    internal class DoubleRankQueue
    {
        public int[] Solution(string[] operations)
        {
            int[] answer = new int[2];
            Dictionary<int, int> doubleRankQueue = new Dictionary<int, int>();

            int max = int.MinValue;
            int min = int.MaxValue;

            /*
             * 1. operations을 Split한 후 Command와 숫자를 분리한다.
             * 2. Command에 따라 다음에 진행할 행동을 선택한다.
             * 3. 숫자에 따라 행동을 처리한다.
             * 3-1. 삽입명령은 별다른 처리없이 바로 실행한다.
             * 3-2. 삭제명령은 현재 Queue의 길이가 0이 아니면 실행한다.
             * 4. operations가 끝나면 max, min 값을 반환한다.
             */

            foreach (var item in operations)
            {
                var split = item.Split(" ");
                var command = split[0];
                var setting = int.Parse(split[1]);

                if ( command == "I")
                {
                    if(doubleRankQueue.ContainsKey(setting) == false)
                    {
                        doubleRankQueue.Add(setting, 1);
                    }
                    else
                    {
                        doubleRankQueue[setting]++;
                    }

                    if(max < setting) max = setting;
                    if(min > setting) min = setting;
                }
                else if (command == "D" && doubleRankQueue.Count != 0)
                {
                    var select = (setting > 0) ? max : min;

                    doubleRankQueue[select]--;

                    if (doubleRankQueue[select] == 0) doubleRankQueue.Remove(select);

                    if(doubleRankQueue.Count == 0)
                    {
                        max = int.MinValue;
                        min = int.MaxValue;
                    }
                    else
                    {
                        max = doubleRankQueue.Keys.Max();
                        min = doubleRankQueue.Keys.Min();
                    }
                }
            }

            if(doubleRankQueue.Count == 0)
            {
                max = 0;
                min = 0;
            }

            answer[0] = max;
            answer[1] = min;
            return answer;
        }
    }
}
