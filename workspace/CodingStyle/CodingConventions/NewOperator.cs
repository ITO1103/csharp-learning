// new 演算子

var firstExample = new ExampleClass();
// 左辺の型からExampleClassを推論する
ExampleClass instance2 = new();
ExampleClass secondExample = new ExampleClass();

firstExample.Name = "First";
instance2.Name = "Second";
secondExample.Name = "Third";

// オブジェクト初期化子でまとめて値を設定する
var thirdExample = new ExampleClass
{
    Name = "Desktop",
    ID = 37414,
    Location = "Redmond",
    Age = 2.3
};

ExampleClass fourthExample = new ExampleClass();
fourthExample.Name = "Desktop";
fourthExample.ID = 37414;
fourthExample.Location = "Redmond";
fourthExample.Age = 2.3;

Console.WriteLine($"{firstExample.Name}: {firstExample.ID}");
Console.WriteLine($"{instance2.Name}: {secondExample.Name}");
Console.WriteLine($"{thirdExample.Location}: {thirdExample.Age}");
Console.WriteLine($"{fourthExample.Location}: {fourthExample.Age}");

public class ExampleClass
{
    public string Name { get; set; } = "";
    public int ID { get; set; }
    public string Location { get; set; } = "";
    public double Age { get; set; }
}
