// ループ内に文字列を作成する
using System.Text;

var builder = new StringBuilder();
for (int i = 1; i <= 3; i++) // ループで文字列を組み立てる
{
    builder.AppendLine($"Line {i}");
}

Console.Write(builder.ToString());