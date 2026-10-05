// 単項演算子

int temperature = 20;
int windChill = -5;

// 単項+は値をそのまま使用する
int heatIndex = +temperature;

// 単項-は値の符号を反転する
int coldFactor = -windChill;

Console.WriteLine(heatIndex);
Console.WriteLine(coldFactor);

bool isRaining = false;

// !でboolのtrueとfalseを反転する
bool isSunny = !isRaining;

Console.WriteLine(isSunny);