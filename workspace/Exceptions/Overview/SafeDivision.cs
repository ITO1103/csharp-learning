// 例外と例外処理

using System;

double a = 98;
double b = 0; // 0除算を発生させる

try
{
    double result = SafeDivision(a, b);
    Console.WriteLine($"{a} divided by {b} = {result}");
}
catch (DivideByZeroException) // 0で割ったときの例外を処理する
{
    Console.WriteLine("Attempted divide by zero.");
}

static double SafeDivision(double x, double y)
{
    if (y == 0)
    {
        // 0で割る前に例外をスローする
        throw new DivideByZeroException();
    }

    return x / y;
}
