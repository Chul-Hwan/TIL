# 문제
출처: 프로그래머스 코딩 테스트 연습, https://school.programmers.co.kr/learn/challenges

[문제 링크](https://school.programmers.co.kr/learn/courses/30/lessons/42748?language=csharp)


[문제 설명]



## 내 풀이 (IDE O)
``` C#
using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        int max = commands.GetLength(0);
        int[] answer = new int[max];

        for(int i = 0; i < max; i++)
        {
            int start     = commands[i,0] - 1;
            int end       = commands[i,1] - start;
            int select    = commands[i,2] - 1;

            var slice = array.Skip(start).Take(end);

            var sort = from num in slice orderby num select num;

            answer[i] = sort.ToList()[select];
        }

        return answer;
    }
}
```

## 내풀이2 (IDE X)
``` C#
using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        int[] answer = new int[commands.GetLength(0)];
        
        for(int i = 0; i < answer.Length; i++)
        {
            answer[i] = array.Skip(commands[i, 0] - 1).Take(commands[i,1] - commands[i,0] +1).OrderBy(n => n).ToArray()[commands[i,2]-1];
        }
        return answer;
    }
}
```

## 회고
- 그 전에 풀었을 때는 Linq 사용에 재미를 들여서 Linq 사용 위주로 하였다.
- 이번에 풀 때는 IDE를 쓰지 않기 때문에 변수값 그대로 쓰려고 노력하였다.
- 따로 지역변수를 선억하여 푸는 것이 좀 더 깔끔할 것 같다.