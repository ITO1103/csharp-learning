// 追加の名前付け規則

// usingを書かずに完全修飾名で型を指定する
System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.
    Stopwatch();

stopwatch.Start();
stopwatch.Stop();

System.Console.WriteLine(stopwatch.ElapsedMilliseconds);
