// 属性引数内の nameof
using System.Diagnostics.CodeAnalysis;

Console.WriteLine(NormalizeOrNull("  hi  ") ?? "<null>");
Console.WriteLine(NormalizeOrNull(null) ?? "<null>");

[return: NotNullIfNotNull(nameof(input))]// 属性の引数にもnameofを使用可能．名前を変更したときに修正漏れしにくい
static string? NormalizeOrNull(string? input) => input?.Trim();