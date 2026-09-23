// インターフェイスを宣言する

// interfaceは名前の先頭にIを付けるのが一般的な命名規則
interface ILogger
{
    void Log(string message);
    string Name {get;}
}