// 関係演算子


int speed = 75;
int limit = 60;

// 2つの値の大小関係を比較する
Console.WriteLine(speed > limit);
Console.WriteLine(speed < limit);
Console.WriteLine(speed >= limit);
Console.WriteLine(speed <= limit);

char grade = 'B';

// charはUnicodeコードポイントの数値で比較される
Console.WriteLine(grade >= 'A' && grade <= 'C');