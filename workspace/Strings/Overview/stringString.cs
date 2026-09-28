// string と String

// stringはSystem.Stringの別名
string a = "hello";
String b = "hello";

// どちらも同じ文字列なのでtrue
Console.WriteLine(a == b);

// stringとStringは同じ型なのでtrue
Console.WriteLine(typeof(string) == typeof(String));