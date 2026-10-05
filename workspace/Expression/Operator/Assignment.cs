// 代入演算子

// 変数を宣言すると同時に1で初期化する
int level = 1;

// 既存の変数に新しい値を代入する
level = 5;

Console.WriteLine(level);

int hp = 100;

// hp = hp + 20の短縮形
hp += 20;
Console.WriteLine(hp);

// hp = hp - 10の短縮形
hp -= 10;
Console.WriteLine(hp);

// hp = hp * 2の短縮形
hp *= 2;
Console.WriteLine(hp);

// hp = hp / 3の短縮形．intなので整数除算になる
hp /= 3;
Console.WriteLine(hp);

// hp = hp % 7の短縮形
hp %= 7;
Console.WriteLine(hp);

int a2, b2, c2;

// 代入は右から左に評価される
a2 = b2 = c2 = 0;
Console.WriteLine($"{a2} {b2} {c2}");

byte small = 200;

// 複合代入では計算結果が左辺の型に変換される
small += 10;
Console.WriteLine(small);