// オブジェクトの作成

var customer = new Customer("Allison");
Console.WriteLine(customer.Name);

var c1 = new Customer("Grace");
var c2 = c1; // 参照

c2.Name = "Hopper"; // 参照なのでc1と同じオブジェクトに書き込む
Console.WriteLine(c1.Name);


public class Customer
{
    // string Nameを取得，変更
    public string Name {get; set;}
    // Customerコンストラクタで受け取ったnameをNameに代入
    public Customer(string name) => Name = name;
}