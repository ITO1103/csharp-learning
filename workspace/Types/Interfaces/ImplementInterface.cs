// インターフェイスを実装する

// ILoggerインターフェイスで宣言されているNameプロパティとLogメソッドを実装する必要がある
public class ConsoleLogger : ILogger
{
    public string Name => "Console";

    public void Log(string message) => Console.WriteLine($"[{Name}] {message}");
}

public class FileLogger : ILogger
{
    public string Name => "File";
    public void Log(string message)
    {
        Console.WriteLine($"[{Name}] Writing to file: {message}");
    }
}


interface ILogger
{
    void Log(string message);
    string Name {get;}
}