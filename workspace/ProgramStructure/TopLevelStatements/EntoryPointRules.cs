// エントリーポイントルール

// 実際のエントリーポイントになるのはここ
Console.WriteLine("Top-level"); // 最上位エントリーポイント
// コンパイラが暗黙のMainを作成する
// 今回のようなawaitもreturnもない場合，static void Main(string[] args)が暗黙的に作成される

class EntoryPointRules
{
    // Mainメソッドを書くことはできるが，最上位ステートメントを使用している場合は開始位置にならない
    static void Main()
    {
        Console.WriteLine("Explicit Main");
    }
}