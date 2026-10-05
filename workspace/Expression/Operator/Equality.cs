// 等値演算子

int expected = 42;
int actual = 42;

// ==は等しいか，!=は等しくないかを確認する
Console.WriteLine(actual == expected);
Console.WriteLine(actual != expected);

string name = "Alice";

// stringは文字列の内容を比較する
Console.WriteLine(name == "Alice");

// stringの比較は大文字と小文字を区別する
Console.WriteLine(name == "alice");

int x = 5;
Console.WriteLine(x == 10);

// C#には===演算子はないためコンパイルエラーになる
// bool same = (x === 10);