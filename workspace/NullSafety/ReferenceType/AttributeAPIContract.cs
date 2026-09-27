// API コントラクトを記述する属性
using System.Diagnostics.CodeAnalysis; // NotNullWhen属性を使用することで、メソッドの戻り値がtrueの場合に引数がnullではないことをコンパイラに伝えることができる

NullAnalysisAttributes();

// trueを返した場合はvalueがnullではないことをコンパイラに伝える
static bool IsPresent([NotNullWhen(true)] string? value) =>
    !string.IsNullOrEmpty(value);

static void NullAnalysisAttributes()
{
    string? input = ReadInput();

    // IsPresentがtrueならinputはnullではないと判断される
    if (IsPresent(input))
    {
        // !を付けなくても安全にLengthへアクセスできる
        Console.WriteLine(input.Length);
    }
}

// nullになる可能性がある文字列を返す
static string? ReadInput() => "hello";