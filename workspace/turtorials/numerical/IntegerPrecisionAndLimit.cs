// 整数の精度と限界を探る

OrderPrecedence();

void OrderPrecedence()
{
    int a = 7;
    int b = 4;
    int c = 3;
    int d = (a + b) / c;
    int e = (a + b) % c;
    Console.WriteLine($"quotient: {d}");
    Console.WriteLine($"remainder: {e}");

    int max = int.MaxValue; // 最大値
    int min = int.MinValue; // 最小値
    Console.WriteLine($"The range of integers is {min} to {max}");
    
    // オーバーフロー
    int what = max + 3;
    Console.WriteLine($"An example of overflow: {what}");
}