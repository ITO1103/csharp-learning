// オブジェクト初期化子

// 今までとの違いは「オブジェクト作成後に呼び出し側がプロパティに値を設定する」
var options = new ConnectionOptions
{
    Host = "db.example.com",
    Port = 5432,
    UseSsl = true
};
Console.WriteLine($"{options.Host}:{options.Port} (SSL:{options.UseSsl})");

// 省略すると既定でinternalになる
class ConnectionOptions
{
    public string Host {get; init;} = "localhost";
    public int Port {get; init;} = 80;
    public bool UseSsl{get; init;}
}