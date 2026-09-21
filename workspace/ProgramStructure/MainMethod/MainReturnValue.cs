// Main() の戻り値
class MainReturnValue
{
    // Mainメソッドでawaitを使用する場合は，戻り値の型としてasync / Task / Task<int>を宣言する
    static async Task<int> Main(string[] args)
    {
        // argsはParse / Convertを使用して他の型に変換できる
        long num = long.Parse(args[0]);
        Console.WriteLine(num);
        return await AsyncConsoleWork();
    }

    private static async Task<int> AsyncConsoleWork()
    {
        return 0;
    }
}