// See https://aka.ms/new-console-template for more information
using Programers;

Console.WriteLine("Hello, World!");

var mockexam = new Mockexam();

Console.WriteLine(string.Join(", ", mockexam.Solution(new int[] { 1, 2, 3, 4, 5 })));
Console.WriteLine(string.Join(", ", mockexam.Solution(new int[] { 1, 3, 2, 4, 2 })));

var doubleRankQueue = new DoubleRankQueue();

var result = string.Join(", ", doubleRankQueue.Solution(new string[] { "I 16", "I -5643", "D -1", "D 1", "D 1", "I 123", "D -1" }));

Console.WriteLine(result);