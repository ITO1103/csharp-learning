// 修飾名

Console.WriteLine(nameof(System.Collections.Generic.List<int>)); // 修飾された式の場合最後の識別子を返す(今回の場合はList)
Console.WriteLine(nameof(Customer.Name)); 

public class Customer(string name)
{
    public string Name {get;} = name;
}