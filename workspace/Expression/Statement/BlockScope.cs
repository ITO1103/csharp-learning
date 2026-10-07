// ブロックによって変数スコープが定義される

int outerValue = 10;

if (outerValue > 0)
{
    int innerValue = outerValue * 2;
    Console.WriteLine(innerValue);
}

// innerValueはifブロックの外では使用できない
Console.WriteLine(outerValue);
