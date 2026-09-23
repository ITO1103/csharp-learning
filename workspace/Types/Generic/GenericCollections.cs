// ジェネリック コレクション

// List
List<string> names = ["Alice", "Bob", "Carol"];
names.Add("Dave"); // 加える


// Dictionary
// キーと値のペア
var inventory = new Dictionary<string, int>
{
    ["Apples"] = 50,
    ["Oranges"] = 30
};

inventory["Bananas"] = 25;

// HashSet
// 重複しない
HashSet<int> uniqueIds = [1, 2, 3, 1, 2];
Console.WriteLine($"Unique count: {uniqueIds.Count}");

// FIFOキュー
Queue<string> tasks = new();
tasks.Enqueue("Build"); // キュー追加
tasks.Enqueue("Test");
Console.WriteLine($"Next task: {tasks.Dequeue()}");