// null を許容しないメンバーを初期化する

ConstructorInjection();
RequiredProperty();
InitializedProperty();
OptionalProperty();

static void ConstructorInjection()
{
    PersonInjected person = new("Alice");

    Console.WriteLine(person.Name);
}

static void RequiredProperty()
{
    PersonRequired person = new()
    {
        Name = "Bob"
    };

    Console.WriteLine(person.Name);
}

static void InitializedProperty()
{
    PersonInitialized person = new();

    Console.WriteLine(person.Name);
}

static void OptionalProperty()
{
    PersonOptional person = new();

    // Nameはnullになる可能性がある
    Console.WriteLine(person.Name ?? "(no name)");
}


// コンストラクターで必ずNameを受け取る
public class PersonInjected(string name)
{
    public string Name {get;} = name;
}


// requiredを付けるとオブジェクト作成時に指定する必要がある
public class PersonRequired
{
    public required string Name {get; init;}
}


// 最初から既定値を入れておく
public class PersonInitialized
{
    public string Name {get; set;} = "John Doe";
}


// Nameが存在しない場合もあるならstring?にする
public class PersonOptional
{
    public string? Name {get; set;}
}