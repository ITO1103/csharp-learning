// タプルの等値性

var order1 = (Product: "Widget", Quantity: 5);
var order2 = (Product: "Widget", Quantity: 5);
var order3 = (Product: "Gadget", Quantity: 3);

// 要素の値で比較可能
// 値と位置が同じであれば等しくなる
Console.WriteLine(order1 == order2);
Console.WriteLine(order1 == order3);

var named = (X: 1, Y: 2);
var different = (A: 1, B: 2);
Console.WriteLine(named == different);