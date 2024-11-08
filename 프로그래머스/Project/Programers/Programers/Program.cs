// See https://aka.ms/new-console-template for more information
using Programers;

Console.WriteLine("Hello, World!");

var mockexam = new Mockexam();

Console.WriteLine(string.Join(", ", mockexam.Solution(new int[] { 1, 2, 3, 4, 5 })));
Console.WriteLine(string.Join(", ", mockexam.Solution(new int[] { 1, 3, 2, 4, 2 })));

var doubleRankQueue = new DoubleRankQueue();

var result = string.Join(", ", doubleRankQueue.Solution(new string[] { "I 16", "I -5643", "D -1", "D 1", "D 1", "I 123", "D -1" }));

Console.WriteLine(result);

#region overtimeIndex
var overtimeIndex = new OvertimeIndex();

// Console.WriteLine("overtimeIndex : " + overtimeIndex.Solution(999, new int[] { 800, 100, 55, 45 }));
// Console.WriteLine("overtimeIndex : " + overtimeIndex.Solution(4, new int[] { 5, 5, 1})); // 9 + 9 + 1
// Console.WriteLine("overtimeIndex : " + overtimeIndex.Solution(4, new int[] { 10, 6, 1})); // 6, 6, 1
Console.WriteLine("overtimeIndex : " + overtimeIndex.Solution(6, new int[] { 5, 2, 1})); // 요소 중 하나가 0이 되는 케이스
#endregion
