// 条件演算子 ?:

int temperature2 = 35;

// condition ? trueの場合の値 : falseの場合の値
string weather = temperature2 > 30 ? "hot" : "comfortable";
Console.WriteLine(weather);

int divisor = 0;

// 条件がtrueなので，右側の10 / divisorは評価されない
int safe = divisor == 0 ? -1 : 10 / divisor;
Console.WriteLine(safe);