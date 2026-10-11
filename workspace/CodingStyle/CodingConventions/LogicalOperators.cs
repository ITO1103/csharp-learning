// && 演算子と || 演算子

int dividend = 10;
int divisor = 2;

// divisorが0なら右側の割り算は実行しない
if ((divisor != 0) && (dividend / divisor) is var result)
{
    Console.WriteLine($"Quotient: {result}");
}
else
{
    Console.WriteLine("Attempted division by 0 ends up here.");
}

// 左辺がtrueなら||の右側は評価しない
bool shouldSkip = (divisor == 0) || (dividend / divisor < 0);
Console.WriteLine(shouldSkip);
