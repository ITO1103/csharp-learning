// インクリメントとデクリメント

int counter = 5;

// 前置++は，先に値を1増やしてからその値を使用する
int a = ++counter;
Console.WriteLine(a);
Console.WriteLine(counter);

// 後置++は，現在の値を使用してから1増やす
int b = counter++;
Console.WriteLine(b);
Console.WriteLine(counter);

int score = 10;

// 後置--は，現在の値を使用してから1減らす
Console.WriteLine(score--);
Console.WriteLine(score);