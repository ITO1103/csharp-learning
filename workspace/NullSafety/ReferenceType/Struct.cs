// 既定の構造体

DefaultStructPitfall();

static void DefaultStructPitfall()
{
    // defaultでstructを作ると各フィールドは既定値になる
    // stringの既定値はnullなのでFirstNameとLastNameもnullになる
    Student s = default;

    // FirstNameは今回nullなので?.で安全にアクセスする
    Console.WriteLine(s.FirstName?.Length ?? -1);
}

public struct Student
{
    // null非許容として宣言していてもdefaultではnullになる
    public string FirstName;
    public string? MiddleName;
    public string LastName;
}