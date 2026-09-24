// 入力が無関係な場合は破棄パラメーターを使用する

// _で破棄する
Action<int, int, string> statusUpdate = (_, _, message) => Console.WriteLine(message);

statusUpdate(200, 42, "Operation completed");