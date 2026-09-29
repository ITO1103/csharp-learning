// +演算子と+=演算子を使用する

string name = "Alex";
string day = "Monday";

// +で新しい文字列を生成する
string greeting = "Hello " + name + ". Today is " + day + ".";
Console.WriteLine(greeting);

// +=で既存の文字列に追加する
greeting += " How are you today?";
Console.WriteLine(greeting);