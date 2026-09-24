// デリゲートはラムダ式をサポートします
// ラムダ式: =>で簡単な動作を入れることができるやつ

Transform doubler = x => x * 2;
Transform squarer = Square;

Console.WriteLine(doubler(5));
Console.WriteLine(squarer(5));

static int Square(int value) => value * value;

delegate int Transform(int value);