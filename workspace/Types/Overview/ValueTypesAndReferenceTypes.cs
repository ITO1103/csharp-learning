// 値型と参照型

// 値型
var point1 = new Coords(3, 4);
var point2 = point1; // 値そのものがコピーされる
Console.WriteLine($"point1: ({point1.X}, {point1.Y})");
Console.WriteLine($"point2: ({point2.X}, {point2.Y})");

// 参照型
var list1 = new List<int> { 1, 2, 3 };
var list2 = list1; // list1とlist2で同じオブジェクトを参照する
list2.Add(4);
Console.WriteLine($"list1 count: {list1.Count}"); // 4 — same object

// 値型のrecord構造素体
public readonly record struct Coords(int X, int Y);

