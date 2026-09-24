// メソッドから複数の値を返す

// 「タプルの最も一般的な用途の1つは、メソッドから複数の値を返す方法です」
static (double Minimum, double Maximum, double Average) ComputeStats(List<double> values)
{
    var min = values.Min();
    var max = values.Max();
    var avg = values.Average();
    return (min, max, avg); // タプルだから複数返せる
}