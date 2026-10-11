// コメントのスタイル

using System.Linq;

int[] numbers = [1, 2, 3, 4, 5];

// 配列から偶数を抽出するクエリを作成する．この時点では実行しない
var query = numbers.Where(number => number % 2 == 0);

foreach (int number in query)
{
    Console.WriteLine(number);
}
