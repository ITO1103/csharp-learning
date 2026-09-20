// その他の種類のリスト

List<int> fibonacciNumbers = [1, 1];

var previous = fibonacciNumbers[fibonacciNumbers.Count - 1]; // [1, 1]の末尾の"1"が入る
var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2]; // [1, 1]の末尾から2番目の"1"が入る

fibonacciNumbers.Add(previous + previous2); // 1 + 1 = 2がAddされる

// この時点で[1, 1, 2]

foreach(var item in fibonacciNumbers)
{
    Console.WriteLine(item);
}