// await 終了コード

Console.Write("Hello ");
await Task.Delay(5000); // Task: 「今すぐ終わらない処理」を表すオブジェクト
// Taskを作ってる

Console.WriteLine("World!");


// 終了コードを返す
string? s = Console.ReadLine(); // 入力を読む(模擬的に与えるだけ)

int returnValue = int.Parse(s ?? "-1"); // 入力がnullであれば-1を使用する
return returnValue; // return intで終了コードとして返す