// リストの内容を変更する

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