// null 許容値型の算術演算

// null許容値型でも算術演算ができる
int? a = 10;
int? b = 20;
int? c = null;

// 両方に値が入っているので30になる
int? sum = a + b;

// cがnullなので計算結果もnullになる
int? product = a * c;

Console.WriteLine(sum);

// productはnullなのでHasValueはfalseになる
Console.WriteLine(product.HasValue);