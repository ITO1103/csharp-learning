// 値型、参照型、等価性の既定値

var order1 = new Order(42, "Shoes");
var order2 = new Order(42, "Shoes");

// classは参照型なので，別々にnewしたインスタンスは内容が同じでも等しくない
Console.WriteLine(order1 == order2);
Console.WriteLine(order1.Equals(order2));
Console.WriteLine(ReferenceEquals(order1, order2));

// order1と同じインスタンスを参照する
Order order3 = order1;
Console.WriteLine(order1 == order3);

var pt1 = new Point(3, 4);
var pt2 = new Point(3, 4);

// structは値型なので，Equalsでは各フィールドの値を比較する
Console.WriteLine(pt1.Equals(pt2));

var t1 = (Name: "Grace", Role: "Engineer");
var t2 = (Name: "Grace", Role: "Engineer");

// tupleは各要素の値が同じなら等しい
Console.WriteLine(t1 == t2);


class Order
{
    public int Id {get;}
    public string Item {get;}

    public Order(int id, string item)
    {
        Id = id;
        Item = item;
    }
}

struct Point
{
    public int X {get;}
    public int Y {get;}

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}