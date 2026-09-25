// 平等

var a = new {Name = "Alice", Age = 30};
var b = new {Name = "Alice", Age = 30};
var c = new {Name = "Bob", Age = 25};

// 値で比較
Console.WriteLine(a.Equals(b));
// 値が違うのでfalse
Console.WriteLine(a.Equals(c));