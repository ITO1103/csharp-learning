// コンストラクターと初期化

Person person = new("Ana", "Smith");

// requiredプロパティは初期化時に値を設定する
LabelledContainer<string> container = new("notes")
{
    Contents = "C# coding conventions"
};

Console.WriteLine($"{person.FirstName} {person.LastName}");
Console.WriteLine($"{container.Label}: {container.Contents}");

// recordの位置指定パラメーターからプロパティが作られる
public record Person(string FirstName, string LastName);

public class LabelledContainer<T>(string label)
{
    public string Label { get; } = label;
    public required T Contents { get; init; }
}
