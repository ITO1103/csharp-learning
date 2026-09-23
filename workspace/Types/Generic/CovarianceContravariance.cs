// 共変性と反変性


// 共変性
// DogはAnimalの一種なので，IEnumerable<Dog>をIEnumerable<Animal>として扱える
List<Dog> dogs = [new("Rex"), new("Buddy")];
IEnumerable<Animal> animals = dogs;

foreach (var animal in animals)
{
    Console.WriteLine(animal.Name);
}

// 反変性
// Animalを受け取れる処理なら，Dogも受け取ることができる
Action<Animal> printAnimal = a => Console.WriteLine($"Animal: {a.Name}");
// Action<Animal>をAction<Dog>として扱える
Action<Dog> printDog = printAnimal;

printDog(new Dog("Spot"));

// Animalを基底クラスとして定義
public class Animal
{
    public string Name { get; }

    public Animal(string name)
    {
        Name = name;
    }
}

// DogはAnimalを継承
public class Dog : Animal
{
    public Dog(string name) : base(name)
    {
    }
}