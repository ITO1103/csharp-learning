// コレクション式

// コレクションの初期化に[]を使える
List<string> fruits = ["Apple", "Banana", "Cherry"];

int[] numbers = [1, 2, 3, 4, 5];

IReadOnlyList<double> temperatures = [72.0, 68.5, 75.3];

Console.WriteLine($"Fruits: {string.Join(", ", fruits)}");
Console.WriteLine($"Numbers: {string.Join(", ", numbers)}");
Console.WriteLine($"Temps: {string.Join(", ", temperatures)}");


List<int> first = [1, 2, 3];
List<int> second = [4, 5, 6];

// ..で既存のコレクションの要素を展開できる
List<int> combined = [.. first, .. second];
Console.WriteLine(string.Join(", ", combined));

List<int> withExtras = [0, .. first, 99, .. second];
Console.WriteLine(string.Join(", ", withExtras));