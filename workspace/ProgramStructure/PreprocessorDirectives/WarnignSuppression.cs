// 警告の抑制

ProcessData();

static void ProcessData()
    {
        try
        {
            // 失敗する前提
            var data = File.ReadAllText("config.json");
            Console.WriteLine($"Config loaded: {data.Length} characters");
        }
// warnign disable CSXXXXで特定のコンパイラ警告を抑制
#pragma warning disable CS0168 // Variable is declared but never used : CS0168: 変数は宣言されていますが、使用されていません
        catch (FileNotFoundException ex) // 使われていないex変数 (本来なからここで警告が出る)
// warning restore CSXXXXで抑制した警告を再度有効にする
#pragma warning restore CS0168
        {
            Console.WriteLine("Config file not found, using defaults.");
        }
    }