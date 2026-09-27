// 注釈を使用して意図を表現する

Annotations();
DesignIntent();

static void Annotations()
{
    string required = "always set";
    string? optional = null;
    
    Console.WriteLine(required.Length);

    if(optional is not null) // optionalがnull出ない場合
    {
        Console.WriteLine(optional.Length);
    }
}

static void DesignIntent()
{
    // MiddleNameあり
    Person p1 = new("Ada", "Lovelace"){MiddleName = "King"};
    Console.WriteLine(p1);

    // MiddleNameなし
    Person p2 = new("Grace", "Hopper");
    Console.WriteLine(p2);
}

// sealed class: 継承できないクラス
public sealed class Person(string firstName, string lastName)
{
    public string FirstName {get;} = firstName;
    public string? MiddleName {get; init;} // MiddleNameはあるか不明なので?
    public string LastName {get;} = lastName;
    // MiddleNameがnullならFirstNameとLastNameだけを表示する
    // nullでなければMiddleNameも含めて表示する
    // override: 親クラスにあるToString()を上書きする
    public override string ToString() => MiddleName is null 
        ? $"{FirstName} {LastName}"  // nullの場合
        : $"{FirstName} {MiddleName} {LastName}"; // nullでない場合
}

