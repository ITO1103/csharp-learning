// 例外処理 (C# プログラミング ガイド)

using System;

TryCatch();

try
{
    TryFinally();
}
catch (SomeSpecificException ex) // TryFinallyから伝わった例外を処理する
{
    Console.WriteLine(ex.Message);
}

TryCatchFinally();

static void TryCatch()
{
    try
    {
        throw new SomeSpecificException("try-catch");
    }
    catch (SomeSpecificException ex)
    {
        // 処理できる例外だけをcatchする
        Console.WriteLine(ex.Message);
    }
}

static void TryFinally()
{
    try
    {
        throw new SomeSpecificException("try-finally");
    }
    finally
    {
        // 例外が起きても実行される
        Console.WriteLine("finally");
    }
}

static void TryCatchFinally()
{
    try
    {
        throw new SomeSpecificException("try-catch-finally");
    }
    catch (SomeSpecificException ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally
    {
        Console.WriteLine("finally");
    }
}

public class SomeSpecificException(string message) : Exception(message);
