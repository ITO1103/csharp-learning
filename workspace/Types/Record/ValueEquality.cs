// 値の等価性

var phones = new string[] {"555-1234"};
var person1 = new Person("Grace", "Hopper", phones);
var person2 = new Person("Grace", "Hopper", phones);

Console.WriteLine(person1 == person2); // 値は同じ
Console.WriteLine(ReferenceEquals(person1, person2)); // オブジェクトが違う

person1.PhoneNumbers[0] = "555-9999";
Console.WriteLine(person2.PhoneNumbers[0]); // 同じ配列phonesを共有しているのでperson1の変更はperson2に波及する



public record Person(string FirstNam, string LastName, string[] PhoneNumbers);
