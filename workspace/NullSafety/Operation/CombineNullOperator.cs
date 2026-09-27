// null 演算子を結合する

Order? order = GetPendingOrder();

// ?.で安全にたどり，nullなら??で"unknown"を使用する
string city = order?.Customer?.Address?.City ?? "unknown";

// order自体がnullか確認する
if (order is null)
{
    Console.WriteLine("No pending order.");
}
else
{
    Console.WriteLine($"Shipping to: {city}");
}

static Order? GetPendingOrder()
{
    return new Order("ORD-001", new Customer("Alice", new Address("123 Main St", "Springfield", "IL")));
}

public sealed class Order(string orderId, Customer? customer)
{
    public string OrderId { get; } = orderId;

    // Customerが存在しない注文もあるので?
    public Customer? Customer { get; } = customer;
}

public sealed class Customer(string name, Address? address)
{
    public string Name { get; } = name;

    // Addressが存在しない場合もあるので?
    public Address? Address { get; } = address;
}

public sealed class Address(string street, string city, string state)
{
    public string Street { get; } = street;
    public string City { get; } = city;
    public string State { get; } = state;
}