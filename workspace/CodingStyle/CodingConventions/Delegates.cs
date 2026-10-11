// デリゲート

using System;

// Actionは戻り値なし，Funcは戻り値ありの処理を表す
Action<string> actionExample1 = x => Console.WriteLine($"x is: {x}");
Action<string, string> actionExample2 = (x, y) =>
    Console.WriteLine($"x is: {x}, y is {y}");

Func<string, int> funcExample1 = x => Convert.ToInt32(x);
Func<int, int, int> funcExample2 = (x, y) => x + y;

actionExample1("first");
actionExample2("first", "second");
Console.WriteLine($"The value is {funcExample1("1")}");
Console.WriteLine($"The sum is {funcExample2(1, 2)}");

// メソッド名をそのままデリゲートに設定する
Del exampleDel2 = DelMethod;
exampleDel2("Hey");

// newを使う書き方もできる
Del exampleDel1 = new Del(DelMethod);
exampleDel1("Hello");

static void DelMethod(string str)
{
    Console.WriteLine($"DelMethod argument: {str}");
}

public delegate void Del(string message);
