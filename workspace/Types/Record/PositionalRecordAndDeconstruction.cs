// 位置指定レコードとデコンストラクション

var person = new Person("Grace", "Hppper");

// recordからプロパティを順番に取り出す = デコンストラクション
var (first, last) = person;
Console.WriteLine($"{first} {last}");

public record Person(string FirstNam, string LastName);
