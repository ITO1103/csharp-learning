// 条件と論理パターンを組み合わせる

Console.WriteLine(IsWeekendPattern(DayOfWeek.Saturday));
Console.WriteLine(IsWeekendPattern(DayOfWeek.Monday));

Console.WriteLine(IsWeekendImperative(DayOfWeek.Saturday));
Console.WriteLine(IsWeekendImperative(DayOfWeek.Monday));

static bool IsWeekendPattern(DayOfWeek day) =>
    // SaturdayまたはSundayならtrue
    day is DayOfWeek.Saturday or DayOfWeek.Sunday;

static bool IsWeekendImperative(DayOfWeek day) =>
    // 上と同じ判定を普通の論理演算子で書いた場合
    day == DayOfWeek.Saturday || day == DayOfWeek.Sunday;