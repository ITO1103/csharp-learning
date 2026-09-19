// 少数型を扱う

decimal min = decimal.MinValue;
decimal max = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {min} to {max}");

double doubleMin = double.MinValue;
double doubleMax = double.MaxValue;
Console.WriteLine($"The range of the double type is {doubleMin} to {doubleMax}");

double a = 1.0;
double b = 3.0;
Console.WriteLine(a / b);

// Mはサフィックス (定数でdecimal型を使用する必要があると示す．それ以外の場合はコンパイラはdoubleを想定する)
decimal c = 1.0M;
decimal d = 3.0M;
Console.WriteLine(c / d);