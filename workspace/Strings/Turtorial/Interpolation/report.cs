// 文字列補間を使用して C でレポートを作成する
// 振り返り的な？
using System.Globalization;

string name = "Maria";
int itemCount = 3;

// $を付けることで，{}の中に変数や式を埋め込める
Console.WriteLine($"Hello, {name}! You have {itemCount} items in your cart.");


decimal subtotal = 23.5m;
decimal taxRate = 0.08m;

// :Cで通貨形式
Console.WriteLine($"Subtotal: {subtotal:C}");
// :P0でパーセント形式
// 0は小数点以下の桁数
Console.WriteLine($"Tax rate: {taxRate:P0}");
// 式の計算結果にも書式指定を適応可能
Console.WriteLine($"Total:    {subtotal * (1 + taxRate):C}");

(string Name, int Quantity, decimal Price)[] orders =
[
    ("Espresso", 2, 3.50m),
    ("Cappuccino", 1, 4.25m),
    ("Tea", 4, 2.00m),
];

foreach (var order in orders)
{
    // ",数値"で表示する最低幅を指定する．負の値は左揃え，正の値は右揃え
    // :Cで通貨形式も同時に指定
    Console.WriteLine($"{order.Name,-12}{order.Quantity,3}{order.Price * order.Quantity,10:C}");
}

decimal total = 1234.56m;
string germanReceipt = string.Create(new CultureInfo("de-DE"), $"Gesamt: {total:C}");
string invariantLog = string.Create(CultureInfo.InvariantCulture, $"total={total:F2}");

Console.WriteLine(germanReceipt);
Console.WriteLine(invariantLog);