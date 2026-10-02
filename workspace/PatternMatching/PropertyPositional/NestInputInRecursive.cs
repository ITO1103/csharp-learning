// 再帰パターン内の入れ子になった入力項目をたどる

object? value1 = new DateTime(2026, 10, 3); // 土曜日
object? value2 = new DateTime(2026, 10, 2); // 金曜日
object? value3 = null;
object? value4 = "Hello";

Console.WriteLine(DescribeNullableInput(value1));
Console.WriteLine(DescribeNullableInput(value3));
Console.WriteLine(DescribeNullableInput(value4));

Console.WriteLine(DescribeDate(value1));
Console.WriteLine(DescribeDate(value2));
Console.WriteLine(DescribeDate(value3));
Console.WriteLine(DescribeDate(value4));

static string DescribeNullableInput(object? value)
{
    if (value is not { } nonNullValue) // { }でnull意外の値に一致する (今回はnotなので「nullの場合」)
    {
        return "No value";
    }

    // 型を確認
    return nonNullValue switch
    {
        DateTime => "Date",
        string => "Text",
        _ => "Another type"
    };
}

static string DescribeDate(object? value) =>
    value switch
    {
        // valueがDateTime型か確認した後，Date.DayOfWeekで土曜日または日曜日か確認する
        DateTime { Date.DayOfWeek:
            DayOfWeek.Saturday or DayOfWeek.Sunday } => "Weekend date",
        DateTime => "Weekday date", // DateTime型だが上記土日の条件には一致しなかった場合
        null => "No date", // nullの場合
        _ => "Not a date" // 上記以外
    };