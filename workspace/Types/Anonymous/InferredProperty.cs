// 推定プロパティ名

// 匿名型では変数名からプロパティ名を推論できる
string productName = "Laptop";
decimal price = 999.99m;
var product = new {productName, price};
Console.WriteLine($"{product.productName}, {product.price:C}");
// :Cで通貨形式にする