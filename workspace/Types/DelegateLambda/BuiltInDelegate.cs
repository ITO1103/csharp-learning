// 組み込みのデリゲート型: Func と Action

// Func<引数1, 引数2, 戻り値>
// intを2つ受け取り，intを返す処理をaddに入れる
Func<int, int, int> add = (left, right) => left + right;

// Action<引数>
// stringを1つ受け取り，戻り値を返さない処理をreportに入れる
Action<string> report = message => Console.WriteLine($"Report: {message}");

// addに5と9を渡して，戻り値をtotalに入れる
int total = add(5, 9);

// reportに文字列を渡して実行する
report($"5 + 9 = {total}");