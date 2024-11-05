// See https://aka.ms/new-console-template for more information
using Programers;

Console.WriteLine("Hello, World!");

var mockexam = new Mockexam();

Console.WriteLine(string.Join(", ", mockexam.Solution(new int[] { 1, 2, 3, 4, 5 })));
Console.WriteLine(string.Join(", ", mockexam.Solution(new int[] { 1, 3, 2, 4, 2 })));