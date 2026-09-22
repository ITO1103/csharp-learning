// with式による非破壊的変異

var original = new Person("Grace", "Hppper");
var modified = original with {FirstNam = "Margaret"}; // with式で非破壊的にプロパティを変更しつつコピー

Console.WriteLine(original);
Console.WriteLine(modified);
Console.WriteLine(original == modified);

var copy = original with {}; // 非破壊的に別インスタンスを立てる
Console.WriteLine(original == copy);
Console.WriteLine(ReferenceEquals(original, copy));

// record structでもwith式による非破壊的変更は可能
var home = new Coordinate(100.0, 100.0);
var shifted = home with {Longitude = -122.0};
Console.WriteLine(shifted);
Console.WriteLine(home == shifted);



public record Person(string FirstNam, string LastName);
public record struct Coordinate(double Latitude, double Longitude);
