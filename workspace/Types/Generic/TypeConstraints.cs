// 型制約

// IComparable: 大小比較をする
// 大きい方を返す
// Tなので型は固定されていない
static T Max<T>(T a, T b) where T : IComparable<T> => a.CompareTo(b) >= 0 ? a : b;

Console.WriteLine(Max(3, 7));
Console.WriteLine(Max("apple", "banana"));

// Tは引数なしコンストラクタを持つ型に限定する
static T CreateDefault<T>() where T : new() => new T();

var list = CreateDefault<List<int>>();
Console.WriteLine($"Empty list count: {list.Count}");

// Tで型の制限はかけないが，参照型や値型だけなどの"型の種類"を制限できる