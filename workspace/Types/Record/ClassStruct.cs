// record class 対。 record struct

var p1 = new Person("Grace", "Hopper");
var p2 = p1; // 参照がコピーされる
Console.WriteLine(ReferenceEquals(p1, p2)); // リファレンスは同じ

var c1 = new Coordinate(47.6062, -122.3321);
var c2 = c1; // 値がコピーされる
c2.Longitude = 0.0; // 別のオブジェクトなので代入可能
Console.WriteLine(c1.Longitude); // 別オブジェクトなので別々の値を有する
Console.WriteLine(c2.Longitude);

public record Person(string FirstNam, string LastName);

// record structはreadonlyを追加することでinit専用になる
public record struct Coordinate(double Latitude, double Longitude);
