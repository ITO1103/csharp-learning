//文字列内のテキストを検索して置換する
string sayHello = "Hello World!";
Console.WriteLine(sayHello);

Console.WriteLine("[Replace]");
// Helloという文字列をGreetingsという文字列に置き換える
sayHello = sayHello.Replace("Hello", "Greetings");
Console.WriteLine(sayHello);

Console.WriteLine("\n[ToUpper, ToLower]");
// 大文字に変換
Console.WriteLine(sayHello.ToUpper());
// 小文字に変換
Console.WriteLine(sayHello.ToLower());

Console.WriteLine("\n[Contains]");
// Containsメソッドで文字列内に特定の文字が含まれているかを判定 (bood値を返す)
string songLyrics = "You say goodbye, and I say hello";
Console.WriteLine(songLyrics.Contains("goodbye"));
Console.WriteLine(songLyrics.Contains("greeting"));