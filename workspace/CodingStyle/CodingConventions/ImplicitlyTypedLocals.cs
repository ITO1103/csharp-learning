// 暗黙的に型指定されるローカル変数

using System;
using System.Linq;
using System.Text;

// 右辺から型が分かる場合はvarを使う
var message = "This is clearly a string.";
var currentTemperature = 27;

int numberOfIterations = Convert.ToInt32("3");
int currentMaximum = ExampleClass.ResultSoFar();
string? input = "42";
Console.WriteLine($"{message} {currentTemperature} {numberOfIterations} {currentMaximum} {input}");

string phrase = "ha";
var manyPhrases = new StringBuilder();

for (var i = 0; i < 3; i++)
{
    manyPhrases.Append(phrase);
}
Console.WriteLine(manyPhrases);

char[] laugh = ['h', 'a', 'h'];
// foreachではコレクション要素の型を明示する
foreach (char ch in laugh)
{
    if (ch == 'h')
    {
        Console.Write("H");
    }
    else
    {
        Console.Write(ch);
    }
}
Console.WriteLine();

Customer[] Customers = [new("Ana", "Seattle"), new("Ben", "Portland")];
var seattleCustomers =
    from customer in Customers
    where customer.City == "Seattle"
    select customer.Name;

foreach (string customerName in seattleCustomers)
{
    Console.WriteLine(customerName);
}

public static class ExampleClass
{
    public static int ResultSoFar() => 42;
}

public record Customer(string Name, string City);
