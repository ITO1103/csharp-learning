// switch を使用したパターン マッチング

ShowStatus();


static void ShowStatus()
{
    int statusCode = 503;
    string message = statusCode switch
    {
        200 => "Ready",
        404 => "Not found",
        _ => "Another status" // 200と404以外の値の場合
    };

    Console.WriteLine(message);
}