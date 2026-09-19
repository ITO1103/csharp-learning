// 操作の順序を調べる
int a = 5;
int b = 4;
int c = 2;
int d = a + b * c; // 乗算が加算の前に実行される
Console.WriteLine(d);

d = (a + b) * c; // 括弧が先に実行される
Console.WriteLine(d);

d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
Console.WriteLine(d);

OrderPrecedence();

void OrderPrecedence()
{
    Console.WriteLine("[OrderPrecedence]");
    // 操作の順序を調べる
    int a = 5;
    int b = 4;
    int c = 2;
    int d = a + b * c; // 乗算が加算の前に実行される
    Console.WriteLine(d);

    d = (a + b) * c; // 括弧が先に実行される
    Console.WriteLine(d);

    d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
    Console.WriteLine(d);
}