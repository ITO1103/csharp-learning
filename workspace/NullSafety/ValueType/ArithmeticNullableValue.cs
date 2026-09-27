// null 許容値型の算術演算

int? a = 10;
int? b = 20;
int? c = null;

int? sum = a + b; // 普通に計算
int? product = a * c; // nullとの計算は全てnullになる

Console.WriteLine(sum);
Console.WriteLine(product); // nullなので表示されない
Console.WriteLine(product.HasValue);