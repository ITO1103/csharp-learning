// リストの検索と並べ替え

List<string> names = ["<name>", "Ana", "Felipe"];
foreach(var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}

// ここからAddで追加，Removeで削除
Console.WriteLine();
names.Add("Maria");
names.Add("Bill");
names.Remove("Ana");
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}

// Listの中身をインデックスで指定することも可能
Console.WriteLine($"My name is {names[0]}.");
Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");

// Countプロパティでリストの長さを確認できる
Console.WriteLine($"The list has {names.Count} people in it");


// ここから
// リストにない場合はIdexOfは-1を返す
var index = names.IndexOf("Felipe");
if (index == -1)
{
    Console.WriteLine($"When an item is not found, IndexOf returns {index}");
}
else // リストにあるので1を返す
{
    Console.WriteLine($"The name {names[index]} is at index {index}");
}

index = names.IndexOf("Not Found");
if (index == -1) // リストにないので-1を返す
{
    Console.WriteLine($"When an item is not found, IndexOf returns {index}");
}
else
{
    Console.WriteLine($"The name {names[index]} is at index {index}");
}

// "通常の順序"に並び替える
// 今回(文字列)の場合はアルファベット順に並び替える
names.Sort();
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}