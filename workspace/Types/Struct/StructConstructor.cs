// 構造体コンストラクター

var custom = new ConnectionSettings();
Console.WriteLine($"{custom.Host}:{custom.Port} (retries:{custom.MaxRetries})");

// defaultでコンストラクタをバイパスしてdefault値を入れることができる
var defaults = default(ConnectionSettings);
Console.WriteLine($"{defaults.Host ?? "(null)"}:{defaults.Port} (retries: {defaults.MaxRetries})");


var tile = new GameTile(2, 5);
Console.WriteLine($"Tile ({tile.Row}, {tile.Column}), blocked: {tile.IsBlocked}");

struct ConnectionSettings
{
    public string Host {get; set;}
    public int Port {get; set;}
    public int MaxRetries {get; set;}

    // 構造体にもコンストラクターを含めることができる
    public ConnectionSettings()
    {
        Host = "localhost";
        Port = 8080;
        MaxRetries = 3;
    }
}


struct GameTile
{
    public int Row {get; set;}
    public int Column{get; set;}
    public bool IsBlocked{get; set;}

    public GameTile(int row, int column)
    {
        Row = row;
        Column = column;
        // IsBlockedについて書かなくても自動で初期化される
    }
}