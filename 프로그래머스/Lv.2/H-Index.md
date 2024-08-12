# 문제
출처: 프로그래머스 코딩 테스트 연습, https://school.programmers.co.kr/learn/challenges

[문제 링크](https://school.programmers.co.kr/learn/courses/30/lessons/42747)

[문제 설명]   


## 내 풀이
```c#
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] citations) {
                int answer = 0;
                int maxValue = 0;
                int hIndex = 0;
                int count = 0;
                var sort = citations.OrderByDescending(t => t);

                //maxValue = sort.Max();
                maxValue = sort.Count();

                for (int i = maxValue; i >= 0; i--)
                {
                    hIndex = i;
                    count = 0;

                    foreach (var item in sort)
                    {
                        if (hIndex <= item)
                            count++;
                    }

                    if(hIndex <= count)
                    {
                        break;
                    }
                }

                answer = hIndex;

                return answer;
            }
    
}
```

## 내 풀이2
```c#
using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] citations) {
        int max = citations.Length;
        int answer = 0;
        for(int i = max; i >= 0; i--)
        {
            int count = citations.Where(c => c >= i).Count();
            if(count >= i && (max - count) <= i)
            {
                answer = i;
                break;
            }
        }
        return answer;
    }
}
```
## 추가 풀이
```c#
var max = citations.Max();
var answer = 0;
for (int h = 1; h <= max; h++)
{
    var check = citations.Count(c => c >= h) >= h;
    if (check)
    {
        answer = h;
    }
}
return answer;
```

## 회고
- 두 번째 풀 때는 문제를 잘 못 읽었음. H-Index 값이 배열의 요소값으로 들어있다고 착각함.
- H-Index 이상인 값을 제외하고 나머지 논문이 H-Index 이하인 점도 고려를 했어야했음.
