// ビット フラグ


var permissions = FileAccess.Read | FileAccess.Write;

Console.WriteLine(permissions);
Console.WriteLine(permissions.HasFlag(FileAccess.Read));
Console.WriteLine(permissions.HasFlag(FileAccess.Execute));

[Flags] // 複数のenum値をビット単位で組み合わせて使うことを表す属性 [FlagsAttribute]
enum FileAccess
{
    // 単独のフラグはビットが重ならないように2の累乗で定義する
    None = 0,
    Read = 1,
    Write = 2,
    Execute = 4,
    ReadWrite = Read | Write,
    All = Read | Write | Execute
}