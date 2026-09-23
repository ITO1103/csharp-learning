// 内部インターフェイスの操作

// internalなので同じアセンブリ内からのみ使用できる
internal class InternalConfiguration
{
    public string Setting {get;set;} = "";
}

// internal interfaceなので同じアセンブリ内からのみ参照できる
internal interface ILoggable
{
    void Log(string message);
}

internal interface IConfigurable
{
    void Configure(InternalConfiguration config);
}

// class自体はpublicなので他アセンブリから参照できる
public class ServiceImplementation : ILoggable, IConfigurable
{
    // ILoggableのLogを通常のpublicメソッドとして実装
    public void Log(string message) => Console.WriteLine($"Log: {message}");

    // publicメソッドとして外部公開せずIConfigurableを明示的に実装する
    // internal契約を隠す
    void IConfigurable.Configure(InternalConfiguration config) => Console.WriteLine($"Configured with: {config.Setting}");
}