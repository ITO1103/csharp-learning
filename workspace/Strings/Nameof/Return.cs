// nameof が返すもの
// 型，変数，プロパティなどの名前を文字列として返す (値を取得するわけではない)
Console.WriteLine(nameof(Customer)); // Customer自体 = Customer
Console.WriteLine(nameof(Customer.Name)); // CustomerのNameという変数 = Name

var customer = new Customer("Ada");
Console.WriteLine(nameof(customer));
Console.WriteLine(nameof(customer.Name)); // 値を取得するわけではないのでAdaではなくName

public class Customer(string name)
{
    public string Name {get;} = name;
}