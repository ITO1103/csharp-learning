// フォールバックを使用して値を取得する

// nullではない値の状態が必要な場合に便利
int? rating = null;

int result1 = rating.GetValueOrDefault();// nullの場合は0を返す
int result2 = rating.GetValueOrDefault(-1); // nullの場合は()の中の値を返す

Console.WriteLine(result1);
Console.WriteLine(result2);

rating = 5;
int result3 = rating.GetValueOrDefault(-1);
Console.WriteLine(result3); // nullではないので普通に表示される

int? priority = null;

int effective = priority ?? 0; // nullだったら0を入れる
Console.WriteLine(effective);

priority = 3;
effective = priority ?? 0; // nullではないので3のまま
Console.WriteLine(effective);