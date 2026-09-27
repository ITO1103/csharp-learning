// null 合体代入演算 ??=

List<string>? cache = null;

// cacheがnullの場合だけLoadData()の結果を代入する
cache ??= LoadData();

Console.WriteLine(cache.Count);

// すでにcacheに値があるのでLoadData()は実行されない
cache ??= LoadData();

Console.WriteLine(cache.Count);

static List<string> LoadData() => ["alpha", "beta", "gamma"];