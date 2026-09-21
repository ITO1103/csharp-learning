// dynamic 型
// コンパイル時の型チェックをバイパスする
// 型が固定されていない感覚
// 非推奨

// System.Int32になる
dynamic value = 42;
Console.WriteLine(value.GetType());

// System.Stringに変わる
value = "Now I'm a string";
Console.WriteLine(value.GetType());