// 値が存在するかどうかを確認する

int? temperature = 72;

if(temperature is int degrees) // null以外の場合にのみ一致→degreesに値を代入
{
    Console.WriteLine($"Temperature is {degrees}F.");
}
else
{
    Console.WriteLine("Temperature is not recorded.");
}

int? count = 42;

if (count.HasValue) // HasValueで確認することも可能
{
    Console.WriteLine($"Count is {count.Value}.");
}
else
{
    Console.WriteLine("Count has no value");
}

int? quantity = null;

if(quantity != null) // "null"と直接比較も可能
{
    Console.WriteLine($"Quantity: {quantity.Value}");
}
else
{
    Console.WriteLine("Quantity is not set.");
}