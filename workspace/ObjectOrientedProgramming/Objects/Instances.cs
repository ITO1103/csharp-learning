// 構造体インスタンスとクラス インスタンス

using System;

Person person1 = new("Leopold", 6);
Person person2 = person1; // person1と同じオブジェクトを参照する

person2.Name = "Molly";
person2.Age = 16;

Console.WriteLine($"person1 Name = {person1.Name} Age = {person1.Age}");
Console.WriteLine($"person2 Name = {person2.Name} Age = {person2.Age}");

StructPerson p1 = new("Alex", 9);
StructPerson p2 = p1; // p1の値をコピーする

p2.Name = "Spencer";
p2.Age = 7;

Console.WriteLine($"p1 Name = {p1.Name} Age = {p1.Age}");
Console.WriteLine($"p2 Name = {p2.Name} Age = {p2.Age}");

public class Person(string name, int age)
{
    public string Name { get; set; } = name;
    public int Age { get; set; } = age;
}

public struct StructPerson
{
    public string Name { get; set; } = "";
    public int Age { get; set; }

    public StructPerson(string name, int age)
    {
        Name = name;
        Age = age;
    }
}
