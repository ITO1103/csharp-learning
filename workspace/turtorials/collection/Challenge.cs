/*
このレッスンと以前のレッスンの概念の一部をまとめることができるかどうかを確認します。 
フィボナッチ数でこれまでに構築した内容を拡張します。 
シーケンス内の最初の 20 個の数値を生成するコードを記述してみてください。 
(ヒントとして、20番目のフィボナッチ数は6765です。
*/

List<int> fibonacciNumbers = [1, 1];

for(int i = 0; i < 20; i++)
{
    var previous = fibonacciNumbers[fibonacciNumbers.Count - 1]; // 末尾の要素
    var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2]; // 末尾から2番目の要素

    fibonacciNumbers.Add(previous + previous2); // 1 + 1 = 2がAddされる
    Console.WriteLine($"{i}: {fibonacciNumbers[i]}");
}