// LINQ クエリで匿名型を使用する
// LINQ: 配列やListなどのデータを絞り込み/変換/並び替えするための機能

var words = new[] {"apple", "blueberry", "cherry"};

// LINQで必要な項目だけを取り出し匿名型としてまとめる
var results = words.Select(w => new { Word = w, Length = w.Length });

foreach (var item in results)
{
    Console.WriteLine($"{item.Word} has {item.Length} letters.");
}