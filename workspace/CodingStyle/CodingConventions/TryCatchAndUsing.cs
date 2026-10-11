// 例外処理でのtry-catchおよびusingステートメント

using System;
using System.IO;

Console.WriteLine(ComputeDistance(1, 2, 4, 6));

MemoryStream bodyStyle = new();
try
{
    bodyStyle.WriteByte(65);
    Console.WriteLine(bodyStyle.ToArray()[0]);
}
finally
{
    bodyStyle?.Dispose();
}

// Disposeだけを行うfinallyはusingに置き換えられる
using (MemoryStream arial = new())
{
    arial.WriteByte(66);
    Console.WriteLine(arial.ToArray()[0]);
}

using MemoryStream normalStyle = new();
// using宣言のスコープを抜けるとDisposeされる
normalStyle.WriteByte(67);
Console.WriteLine(normalStyle.ToArray()[0]);

static double ComputeDistance(double x1, double y1, double x2, double y2)
{
    try
    {
        return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
    }
    catch (ArithmeticException ex)
    {
        Console.WriteLine($"Arithmetic overflow or underflow: {ex}");
        // throw;で同じ例外を再スローする
        throw;
    }
}
