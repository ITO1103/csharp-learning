// オブジェクト ID と値の等価性

using System;

PersonClass person1 = new("Wallace", 75);
PersonClass person2 = person1;
PersonClass person3 = new("Wallace", 75);

Console.WriteLine(object.ReferenceEquals(person1, person2));
Console.WriteLine(object.ReferenceEquals(person1, person3));

Person p1 = new("Wallace", 75);
Person p2 = new("", 42);

p2.Name = "Wallace";
p2.Age = 75;

if (p2.Equals(p1))
{
    Console.WriteLine("p2 and p1 have the same values.");
}

public class PersonClass(string name, int age)
{
    public string Name { get; set; } = name;
    public int Age { get; set; } = age;
}

public struct Person
{
    public string Name { get; set; } = "";
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}
