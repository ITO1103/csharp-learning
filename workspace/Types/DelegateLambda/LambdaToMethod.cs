// ラムダ式をメソッドに渡す


int[] numbers = [1, 2, 3, 4, 5, 6];
// Filterメソッドに「valueが偶数ならtrueを返す」というラムダ式を条件として渡す
// 条件に一致した値だけを取り出しToArray()で配列に変換する
int[] evenNumbers = Filter(numbers, value => value % 2 == 0).ToArray();

Console.WriteLine(string.Join(", ", evenNumbers));