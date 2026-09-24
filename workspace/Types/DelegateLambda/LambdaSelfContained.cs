// ラムダ式を自己完結型にする

// staticを付けるとラムダ式の外側にあるローカル変数などを参照できなくなる
// 受け取ったvalueだけを使って偶数かどうかを判定する
Func<int, bool> isEven = static value => value % 2 == 0;

Console.WriteLine(isEven(14));
Console.WriteLine(isEven(15));