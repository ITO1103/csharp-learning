// フォールバックを使用して値を取得する

int? rating = null;

// 値があればその値を返し，nullならintのデフォルト値である0を返す
int result1 = rating.GetValueOrDefault();

// 値があればその値を返し，nullなら指定した-1を返す
int result2 = rating.GetValueOrDefault(-1);

Console.WriteLine(result1);
Console.WriteLine(result2);

rating = 5;

// 値が入っているので5が返る
int result3 = rating.GetValueOrDefault(-1);
Console.WriteLine(result3);


int? priority = null;

// priorityがnullなので0を使用する
int effective = priority ?? 0; // ??を使ってnullの場合の代わりの値を指定する
Console.WriteLine(effective);

priority = 3;

// priorityに値が入っているので3を使用する
effective = priority ?? 0;
Console.WriteLine(effective);