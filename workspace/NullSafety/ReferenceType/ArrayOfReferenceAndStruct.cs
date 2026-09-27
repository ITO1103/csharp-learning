// 参照と構造体の配列

ArrayPitfall();

static void ArrayPitfall()
{
    string[] values = new string[3]; //各要素はまだnull

    // values[0]はnullなので?.で安全にアクセスする
    // nullの場合は-1を表示する
    Console.WriteLine(values[0]?.Length ?? -1);

    // 最初から全ての要素を入れて作ればnullにならない
    string[] initialized = ["a", "b", "c"];

    Console.WriteLine(initialized[0].Length);
}