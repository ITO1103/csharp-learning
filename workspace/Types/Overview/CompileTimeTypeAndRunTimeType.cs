// コンパイル時の型と実行時の型

// コンパイル時と実行時の型が同じ例
string message = "Hello, world!";
Console.WriteLine(message.GetType());

// コンパイル時と実行時の型が違う例
object boxed = "This is a string at run time";
Console.WriteLine(boxed.GetType());
// object型だが，実際に参照しているオブジェクトはstring


IEnumerable<char> characters = "abcdefghijklmnopqrstuvwxyz";
Console.WriteLine(characters.GetType());
// IEnumerable<char>だが，実際に参照しているオブジェクトはstring