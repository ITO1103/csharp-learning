// タプル
var pt = (X: 1, Y: 2); // タプル = 構造体

var slope = (double)pt.Y / (double)pt.X;
Console.WriteLine($"A line from the origin to the point {pt} has a slope of {slope}.");

// タプルの要素に加算
pt.X = pt.X + 5; 
Console.WriteLine($"The point is now at {pt}.");

// タプルの要素に代入
var pt2 = pt with {Y = 10};
Console.WriteLine($"The point 'pt2' is at {pt2}");


var subscript = (A: 0, B:0);
subscript = pt; // 同じ構造を持つタプルであれば代入できる
Console.WriteLine(subscript);

var namedData = (Name: "Morning observation", Temp: 17, Wind: 4);
var person = (FitstName: "", LastName: "");
var order = (Product: "guitar picks", style: "triangle", quantity: 500, UnitPrice: 0.10m);

person.FitstName = "BOB";
person.LastName = "BabyOnBoard";

Console.WriteLine(namedData);
Console.WriteLine(person);
Console.WriteLine(order);
Console.WriteLine(order.Product);