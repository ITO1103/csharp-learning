// コンストラクターと初期化



var person = new Person{FirstName = "Grace", LastName = "Hopper"};

// requiredのプロパティが腹足しているのでエラーになる例
// var person2 = new Person{FirstName = "Grace"};

Console.WriteLine($"{person.FirstName} {person.LastName}");


public class Container(int capacity)
{
    // privateフィールドの名前に_をつける命名規則
    private int _capacity = capacity;

    // public Container(int capacity) => _capacity = capacity;
}

public class Person
{
    // "必要なプロパティ"をrequiredで設定&強制する
    public required string FirstName{get; set;}
    public required string LastName{get; set;}
}


