// 値の等価性にはレコードを使用する

var person1 = new Person("Ada", "Lovelace");
var person2 = new Person("Ada", "Lovelace");

// record classは参照型だが，==とEqualsではプロパティの値を比較する
Console.WriteLine(person1 == person2);
Console.WriteLine(person1.Equals(person2));

// 別々にnewしたオブジェクトなので参照自体は異なる
Console.WriteLine(ReferenceEquals(person1, person2));

var dim1 = new Dimension(1920, 1080);
var dim2 = new Dimension(1920, 1080);

// record structも値を比較し，==も使用できる
Console.WriteLine(dim1 == dim2);
Console.WriteLine(dim1.Equals(dim2));


record Person(string FirstName, string LastName);

readonly record struct Dimension(int Width, int Height);