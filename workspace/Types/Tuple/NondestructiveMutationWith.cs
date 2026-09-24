// with による非破壊な変化

var original = (Name: "Widget", Price: 19.99m, InStock: true);
var discounted = original with { Price = 14.99m }; // with式で一つ以上の要素が変更されたタプルのコピーを作成(元の要素には影響しない)

Console.WriteLine($"Original: {original.Name} at {original.Price:C}");
Console.WriteLine($"Discounted: {discounted.Name} at {discounted.Price:C}");