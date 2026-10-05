// 算術演算子

int apples = 10;
int oranges = 3;

Console.WriteLine(apples + oranges); // 加算
Console.WriteLine(apples - oranges); // 減算
Console.WriteLine(apples * oranges); // 乗算
Console.WriteLine(apples / oranges); // int同士なので整数除算
Console.WriteLine(apples % oranges); // 除算した余りを取得

// int同士の除算では小数部を切り捨てる
int result = 7 / 2;
Console.WriteLine(result);

// 負の値でも0に近づく方向に切り捨てる
int negResult = -7 / 2;
Console.WriteLine(negResult);

// 小数の結果を得るには，どちらかを浮動小数点型にする
double precise = 7.0 / 2;
Console.WriteLine(precise);

// %の結果の符号は左側の値に従う
Console.WriteLine(-7 % 3);
Console.WriteLine(7 % -3);