// ジェネリック メソッド

// 型を固定せずに様々な型で使い回せるメソッドを作れる
static void Print<T>(T value) => Console.WriteLine($"Value: {value}");

Print(42); // Print<int>(42)と推論
Print("Hello");
Print(3.14);