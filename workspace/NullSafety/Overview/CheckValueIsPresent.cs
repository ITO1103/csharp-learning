// 値が存在するかどうかを確認する

int? temperature = 72;

// nullではない場合だけintとして取り出し，degreesに入れる
if (temperature is int degrees)
{
    Console.WriteLine($"Temperature is {degrees}°F.");
}
else
{
    Console.WriteLine("Temperature is not recorded.");
}

int? count = 42;

// 値が入っているか確認する
if (count.HasValue)
{
    // Valueで実際の値を取得する
    Console.WriteLine($"Count is {count.Value}.");
}
else
{
    Console.WriteLine("Count has no value.");
}

int? quantity = null;

// nullではないか直接確認することも可能
if (quantity != null)
{
    Console.WriteLine($"Quantity: {quantity.Value}");
}
else
{
    Console.WriteLine("Quantity is not set.");
}