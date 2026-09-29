// 条件式を使用する

var rand = new Random(42);
for (int i = 0; i < 3; i++)
{
    // .は補完式の中で特別な意味を持つので，条件式は()で括る
    // Console.WriteLine($"Coin flip: {rand.NextDouble() < 0.5 ? "heads" : "tails"}");はダメ
    Console.WriteLine($"Coin flip: {(rand.NextDouble() < 0.5 ? "heads" : "tails")}");
}