// 引数の検証

try
{
    Greet("");
}
catch(ArgumentException ex)
{    
    Console.WriteLine($"{ex.ParamName}: {ex.Message}");
}

static void Greet(string name)
{
    if (string.IsNullOrWhiteSpace(name)) // 典型的な用途：スローされる例外でパラメーター名を生成すること
    {
        throw new ArgumentException("Name must be non-empty.", nameof(name));
    }
    Console.WriteLine($"Hello, {name}!");
}

Customer? maybeCustomer = null;

try
{
    Save(maybeCustomer);
}
catch (ArgumentNullException ex)
{
    // ThrowIfNullに渡した引数名が入る
    Console.WriteLine(ex.ParamName);
}

static void Save(Customer? customer)
{
    // customerがnullならArgumentNullExceptionを投げる
    // 引数名は自動でcustomerとして取得される
    ArgumentNullException.ThrowIfNull(customer);

    Console.WriteLine($"Saved: {customer.Name}");
}


public class Customer(string name)
{
    public string Name {get;} = name;
}