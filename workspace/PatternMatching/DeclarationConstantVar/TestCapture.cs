// 宣言パターンを使用して型をテストしてキャプチャする

decimal value = 10;

double d = 10.0;
string s = "string";

PrintPrice(value);
Console.WriteLine(FormatSensorValue(value));
Console.WriteLine(FormatSensorValue(d));
Console.WriteLine(FormatSensorValue(s));



static void PrintPrice(object value)
{
    if(value is decimal amount) // 宣言パターンでdecimalだけを受け取るようにする
    {
        Console.WriteLine($"Price: {amount:C}");
    }
}


static string FormatSensorValue(object reading) =>
    reading switch // switch式でreadingの型を判定し，一致した型の変数として取り出す
    {
        int count => $"Count: {count}", // intならcount
        double temperature => $"Temperature: {temperature:F1}°C", // doubleならtemperature
        string message => $"Message: {message}", // stringならmessage
        _ => "Unsupported reading" // それ以外
    };