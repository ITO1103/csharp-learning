// 値を switch ステートメントと一致させる

DayOfWeek day = DayOfWeek.Saturday;

switch (day)
{
    case DayOfWeek.Saturday:
    case DayOfWeek.Sunday:
        Console.WriteLine("Weekend");
        break;
    default:
        Console.WriteLine("Weekday");
        break;
}
