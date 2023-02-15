using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Q10989
{
    public void Execute()
    {
        using var reader = new System.IO.StreamReader(Console.OpenStandardInput());

        using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());

        int count = int.Parse(reader.ReadLine());
        int[] numbers = new int[10001];

        for (int i = 0; i < count; i++)
        {
            numbers[int.Parse(reader.ReadLine())]++;
        }

        for (int i = 1; i <= 10000; i++)
        {
            for (int j = 0; j < numbers[i]; j++)
            {
                print.WriteLine(i);
            }
        }
    }
}

