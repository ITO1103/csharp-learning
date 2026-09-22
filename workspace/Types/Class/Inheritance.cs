// 継承

var manager = new Manager("Satya", "Engineering");
Console.WriteLine($"{manager.Name} manages {manager.Department}");


class Manager
{
    public string Name {get; set;}
    public string Department {get;set;}

    public Manager(string name, string department)
    {
        Name = name;
        Department = department;
    }

}