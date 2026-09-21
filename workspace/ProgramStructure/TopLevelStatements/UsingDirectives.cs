// usingディレクティブ
using System.Text; // 最上位レベルステートメントの場合はusingを先頭に置く必要がある

StringBuilder builder = new(); // StringBuilderと型がわかっているのでnew()だけで良い
// 型がわかっていない場合は var builder = new StringBuilder();となる
// 引数を複数渡したい場合もnewだけではなくなる．1つならnew(引数)でもOK

builder.AppendLine("The following arguments are passeed:");

foreach(var arg in args)
{
    builder.AppendLine($"Argument={arg}");
}

Console.WriteLine(builder.ToString());

return 0;