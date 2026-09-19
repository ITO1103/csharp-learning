// 課題
/*
StartsWithとEndsWithの 2 つの同様のメソッドも、文字列内の部分文字列を検索します。 
これらのメソッドは、文字列の先頭または末尾に部分文字列を検索します。 
StartsWithの代わりに EndsWith と Contains を使用するように前のサンプルを変更してみてください。 
文字列の先頭に "You" または "goodbye" を検索します。 文字列の末尾に "hello" または "goodbye" を検索します。
*/

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

// 課題
Console.WriteLine("\n[Challenge]");
// StartsWithで"You"もしくは"goodbye"で始まるか調査
Console.Write($"StartWith 'You' is ");
Console.WriteLine(songLyrics.StartsWith("You"));
Console.Write($"StartWith 'goodbye' is ");
Console.WriteLine(songLyrics.StartsWith("goodbye"));

// EndsWithで"hello"もしくは"goodsbye"で終わるか調査
Console.Write($"EndWith 'hello' is ");
Console.WriteLine(songLyrics.EndsWith("hello"));
Console.Write($"EndWith 'goodbye' is ");
Console.WriteLine(songLyrics.EndsWith("goodbye"));