// out パラメーターを持つメソッドの呼び出し

CheckInput();

static void CheckInput()
{
    string text = "42";

    if (IsWholeNumber(text))
    {
        Console.WriteLine($"Accepted: {text}");
    }
    else
    {
        Console.WriteLine("Enter a whole number.");
    }
    // intに変換できるかだけ確認し変換後の値自体は使わない
    static bool IsWholeNumber(string text) => int.TryParse(text, out _);
}