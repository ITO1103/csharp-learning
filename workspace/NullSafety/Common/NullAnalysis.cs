// null 解析属性を追加する
using System.Diagnostics.CodeAnalysis;

CallerWithoutAttribute("hello");
CallerWithAttribute("hello");

// 実際にはtrueならtextはnullではないがこの定義だけではコンパイラにはその関係が分からない
static bool IsPresent(string? text) =>
    !string.IsNullOrEmpty(text);

static void CallerWithoutAttribute(string? text)
{
    if (IsPresent(text))
    {
        // コンパイラはtextがnullではないと判断できないので警告が出る
        Console.WriteLine(text.Length);
    }
}


// trueを返した場合はtextがnullではないことをコンパイラに伝える
static bool AttributedIsPresent([NotNullWhen(true)] string? text) => !string.IsNullOrEmpty(text);

static void CallerWithAttribute(string? text)
{
    // trueならtextはnullではないとコンパイラが判断する
    if (AttributedIsPresent(text))
    {
        Console.WriteLine(text.Length);
    }
}