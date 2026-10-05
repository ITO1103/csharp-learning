// 条件付き論理演算子

int age = 20;
bool hasTicket = true;

// &&は両方がtrueの場合にtrueになる
bool canEnter = age >= 18 && hasTicket;
Console.WriteLine(canEnter);

// ||はどちらか一方以上がtrueの場合にtrueになる
bool freeEntry = age < 5 || age >= 65;
Console.WriteLine(freeEntry);

List<string>? items = null;

// 左側がfalseになった時点で&&全体がfalseになるので，右側は評価されない
bool hasItems = items != null && items.Count > 0;
Console.WriteLine(hasItems);