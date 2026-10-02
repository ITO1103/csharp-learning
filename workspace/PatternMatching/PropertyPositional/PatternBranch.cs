// パターンと分岐ステートメントを比較する

object? value1 = new DateTime(2026, 10, 3);
object? value2 = new DateTime(2026, 10, 2);
object? value3 = null;
object? value4 = "Hello";

Console.WriteLine(DescribeDate(value1));
Console.WriteLine(DescribeDate(value2));
Console.WriteLine(DescribeDate(value3));
Console.WriteLine(DescribeDate(value4));

Console.WriteLine();

Console.WriteLine(DescribeDateWithBranches(value1));
Console.WriteLine(DescribeDateWithBranches(value2));
Console.WriteLine(DescribeDateWithBranches(value3));
Console.WriteLine(DescribeDateWithBranches(value4));

static string DescribeDate(object? value) =>
    // switch式とパターンマッチングを使って判定する
    value switch
    {
        // DateTime型で曜日が土曜日または日曜日の場合
        DateTime { Date.DayOfWeek:
            DayOfWeek.Saturday or DayOfWeek.Sunday } => "Weekend date",
        // DateTime型だが土日ではない場合
        DateTime => "Weekday date",
        // nullの場合
        null => "No date",
        // DateTimeでもnullでもない場合
        _ => "Not a date"
    };


// 上と同じ判定を通常のif文で書いた場合
static string DescribeDateWithBranches(object? value)
{
    if (value is DateTime date)
    {
        if (date.DayOfWeek == DayOfWeek.Saturday ||
            date.DayOfWeek == DayOfWeek.Sunday)
        {
            return "Weekend date";
        }

        return "Weekday date";
    }

    if (value is null)
    {
        return "No date";
    }

    return "Not a date";
}