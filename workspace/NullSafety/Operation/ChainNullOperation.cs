// null 条件演算子を連結する

var order = new Order("ORD-001", null);

// CustomerがnullならAddressやCityにはアクセスせず，cityはnullになる
string? city = order.Customer?.Address?.City;

Console.WriteLine(city ?? "(no city)");

var fullOrder = new Order(
    "ORD-002",
    new Customer("Alice", new Address("123 Main St", "Springfield", "IL"))
);

// 全てnullではないのでCityまで取得できる
Console.WriteLine(fullOrder.Customer?.Address?.City);

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