// double 型の処理
// double a = 5;
// double b = 4;
// double c = 2;
// double d = (a + b) / c;
// Console.WriteLine(d);

double a = 19;
double b = 23;
double c = 8;
double d = (a + b) / c;
Console.WriteLine(d);

// 最大値と最小値 (Eの左は仮数，右は指数)
double max = double.MaxValue;
double min = double.MinValue;
Console.WriteLine($"The range of double is {min} to {max}");

// 丸め誤差?
double third = 1.0 / 3.0;
Console.WriteLine(third);