// リレーショナル パターンと値を比較する

ShowExpressionAndPattern(5, 10);
ShowExpressionAndPattern(-3, 10);

// 普通の比較式と関係パターンを比較する
static void ShowExpressionAndPattern(int temperature, int threshold)
{
    // 普通の比較式
    // 右側に変数thresholdを使用できる
    bool belowThreshold = temperature < threshold;

    // 関係パターン
    // 0は定数なのでパターンとして使用できる
    bool belowFreezing = temperature is < 0;

    string description =
        temperature switch
        {
            < 0 => "Freezing",
            0 => "Freezing point",
            > 0 => "Above freezing"
        };

    Console.WriteLine(
        $"Below threshold: {belowThreshold}; " +
        $"below freezing: {belowFreezing}; {description}"
    );
}