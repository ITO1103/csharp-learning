/*
double型を使用して、大きな数値、小さい数値、乗算、除算を含む他の計算を試してみてください。 
より複雑な計算を試してください。 課題に時間を費やした後、記述したコードを取得し、新しいメソッドに配置します。 
新しいメソッドに WorkWithDoubles名前を付けます。
*/
WorkWithDoubles();

void WorkWithDoubles()
{
    double a = 123456789;
    double b = 0.01;
    double min = double.MinValue;
    double max = double.MaxValue;
    double answer;

    answer = a * b * b / min * max;

    Console.WriteLine(answer);
}

/*
さまざまな数値型がわかったら、半径が 2.50 cm の円の面積を計算するコードを記述します。 
円の面積は、半径の 2 乗に PI を乗算した値です。 
1 つのヒント: ランタイムには PI の定数が含まれています。 
Math.PI その値に使用できます。 
Math.PI System.Math名前空間で宣言されているすべての定数と同様に、double値です。 
そのため、このチャレンジでは、doubleの値ではなくdecimalの値を使用する必要があります。
*/
// ↑の「doubleの値ではなくdecimalの値を使用する必要があります。」は嘘(翻訳ミス？)であり，doubleを使用する必要がある

double r = 2.50; // 半径
double area = r * r * Math.PI; // 面積を求める
Console.WriteLine(area);