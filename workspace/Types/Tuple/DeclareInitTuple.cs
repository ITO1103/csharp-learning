// タプルを宣言して初期化する

(string Name, int Age) person = ("Alice", 30);
Console.WriteLine($"{person.Name} is {person.Age} years old");

// デフォルトでは(Item1, Item2)になる
(string, int) unnamed = ("Bob", 25);
Console.WriteLine($"{unnamed.Item1} is {unnamed.Item2} years old");

// varにタプルを入れることもできる
var city = (Name: "Seattle", Population: 749_256);
Console.WriteLine($"{city.Name}: population {city.Population}");