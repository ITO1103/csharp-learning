// 文字列データ

using System.Text;

Name[] nameList = [new("Tanaka", "Ana"), new("Smith", "Ben")];
int n = 0;
string displayName = $"{nameList[n].LastName}, {nameList[n].FirstName}";
Console.WriteLine(displayName);

string phrase = "Learning C# ";
StringBuilder manyPhrases = new();

// 繰り返し文字列を追加する場合はStringBuilderを使う
for (int i = 0; i < 3; i++)
{
    manyPhrases.Append(phrase);
}

// 複数行の文字列をそのまま書く
string message = """
This is a long message that spans across multiple lines.
It uses raw string literals. This means we can
also include characters like \n and \t without escaping them.
""";

Console.WriteLine(manyPhrases);
Console.WriteLine(message);

Student[] students = [new("Sato", 95), new("Kato", 82)];

// 補間式にプロパティ参照を入れる
foreach (Student student in students)
{
    Console.WriteLine($"{student.Last} Score: {student.Score}");
}

public record Name(string LastName, string FirstName);
public record Student(string Last, int Score);
