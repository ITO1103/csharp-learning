// catch ブロック

using System;

int[] values = [10, 20, 30];

try
{
    Console.WriteLine(GetInt(values, 1));
    GetInt(values, 5);
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine(ex.InnerException?.GetType().Name);
}

try
{
    GetIntWithFilter(values, -1);
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
}

try
{
    RethrowAfterLogging();
}
catch (UnauthorizedAccessException ex)
{
    Console.WriteLine(ex.Message);
}

ExceptionFilterExample();

static int GetInt(int[] array, int index)
{
    try
    {
        return array[index];
    }
    catch (IndexOutOfRangeException ex)
    {
        // 配列の範囲外を引数の例外に置き換える
        throw new ArgumentOutOfRangeException(
            "Parameter index is out of range.", ex);
    }
}

static int GetIntWithFilter(int[] array, int index)
{
    try
    {
        return array[index];
    }
    catch (IndexOutOfRangeException ex) when (index < 0) // whenの条件も満たした場合だけ処理する
    {
        // indexが負の場合
        throw new ArgumentOutOfRangeException(
            "Parameter index cannot be negative.", ex);
    }
    catch (IndexOutOfRangeException ex)
    {
        throw new ArgumentOutOfRangeException(
            "Parameter index cannot be greater than the array size.", ex);
    }
}

static void RethrowAfterLogging()
{
    try
    {
        throw new UnauthorizedAccessException("Access was denied.");
    }
    catch (UnauthorizedAccessException ex)
    {
        LogError(ex);
        // 同じ例外をそのまま呼び出し元に渡す
        throw;
    }
}

static void LogError(Exception ex)
{
    Console.WriteLine($"Logged: {ex.GetType().Name}");
}

static void ExceptionFilterExample()
{
    try
    {
        string? s = null;
        Console.WriteLine(s.Length);
    }
    catch (Exception ex) when (LogException(ex)) // LogExceptionがtrueを返した場合に処理する
    {
        Console.WriteLine("This filter returned true");
    }
    catch (Exception)
    {
        // falseを返したフィルターの次のcatchで処理する
        Console.WriteLine("The filter did not handle the exception");
    }
}

static bool LogException(Exception ex)
{
    Console.WriteLine($"Caught {ex.GetType().Name}");
    Console.WriteLine(ex.Message);
    return false;
}
