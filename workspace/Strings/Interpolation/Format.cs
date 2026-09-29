// 書式文字列を適用する

var date = new DateTime(1731, 11, 25);
// :の後ろで書式設定を適応できる
Console.WriteLine($"On {date:dddd, MMMM dd, yyyy} L. Euler introduced the letter e to denote {Math.E:F5}.");