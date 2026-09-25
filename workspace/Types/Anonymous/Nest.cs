// 入れ子になった匿名型

var order = new
{
    OrderId = 1,
    Customer = new {Name = "Alice", City = "Seattle"}, // 入れ子にできる
    Total = 150.00m
};
Console.WriteLine($"Order {order.OrderId} for {order.Customer.Name} in {order.Customer.City}");