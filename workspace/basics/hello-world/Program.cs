// Console.WriteLine("Hello, World!");単体と同じ
// ↑の場合はSystem名前空間が暗黙的に含まれている．含まれていない場合はSystem.Console....となる

using System;
namespace TourOfCsharp;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
    }
}