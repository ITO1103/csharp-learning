// LINQ クエリ

using System.Linq;

Customer[] Customers =
[
    new("Ana", "Seattle"),
    new("Ben", "Portland"),
    new("Cleo", "Seattle")
];

Distributor[] Distributors =
[
    new("North", "Seattle"),
    new("West", "Portland")
];

Student[] students =
[
    new("Sato", [95, 88]),
    new("Kato", [91, 84])
];

var seattleCustomers =
    from customer in Customers
    where customer.City == "Seattle"
    select customer.Name;

foreach (string customerName in seattleCustomers)
{
    Console.WriteLine(customerName);
}

var localDistributors =
    from customer in Customers
    join distributor in Distributors on customer.City equals distributor.City
    // 結合した要素を匿名型にまとめる
    select new { Customer = customer, Distributor = distributor };

foreach (var localDistributor in localDistributors)
{
    Console.WriteLine($"{localDistributor.Customer.Name}: {localDistributor.Distributor.Name}");
}

var localDistributors2 =
    from customer in Customers
    join distributor in Distributors on customer.City equals distributor.City
    select new { CustomerName = customer.Name, DistributorName = distributor.Name };

foreach (var localDistributor in localDistributors2)
{
    Console.WriteLine($"{localDistributor.CustomerName}: {localDistributor.DistributorName}");
}

// whereで絞ってからorderbyで並べる
var seattleCustomers2 =
    from customer in Customers
    where customer.City == "Seattle"
    orderby customer.Name
    select customer;

foreach (Customer customer in seattleCustomers2)
{
    Console.WriteLine(customer.Name);
}

// 複数のfromでStudentごとのScoreを一つずつ処理する
var scoreQuery =
    from student in students
    from score in student.Scores
    where score > 90
    select new { Last = student.LastName, score };

foreach (var student in scoreQuery)
{
    Console.WriteLine($"{student.Last} Score: {student.score}");
}

public record Customer(string Name, string City);
public record Distributor(string Name, string City);
public record Student(string LastName, int[] Scores);
