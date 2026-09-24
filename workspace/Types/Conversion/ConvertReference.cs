// 参照の変換


Mammal otter = new() {Name = "River Otter"};

// MammalはAnimalを継承しているのでAnimal型として扱える
Animal animal = otter;

// MammalはINamedを実装しているのでINamed型として扱える
INamed named = otter;

// objectは全ての型の基底なのでobject型として扱える
object obj = otter;

Console.WriteLine(named.Name);


// Animal型だが実体はMammal
Animal knownAnimal = new Mammal {Name = "River otter"};

// isでMammal型か確認し，Mammalならmammal変数として使用する
if (knownAnimal is Mammal mammal)
{
    Console.WriteLine($"Pattern match succeeded: {mammal.Name}");
}


// Animal型だが実体はReptile
Animal unknownAnimal = new Reptile();

// Mammalとして扱えるかisで確認する
Console.WriteLine($"Can treat as mammal: {unknownAnimal is Mammal}");


// object型だが実体はMammal
object boxedMammal = new Mammal {Name = "Sea lion"};

// asでMammalへの変換を試す
// 変換できない場合はnullになる
Mammal? maybeMammal = boxedMammal as Mammal;

Console.WriteLine(maybeMammal is null ? "Not a mammal" : maybeMammal.Name);


// object型だが実体はReptile
object boxedReptile = new Reptile();

// ReptileはMammalではないのでnullになる
Mammal? noMammal = boxedReptile as Mammal;

Console.WriteLine(noMammal is null ? "Safe null result" : noMammal.Name);