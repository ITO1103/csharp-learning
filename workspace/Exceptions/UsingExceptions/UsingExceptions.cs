// 例外を使用する

using System;
using System.IO;

CatchCustomException(); // CustomExceptionをスローしてcatchする
CatchOrder(); // 具体的な例外から順にcatchする
TestFinally(); // finallyでファイルを閉じる

static void TestThrow()
{
    // 呼び出し元に例外を伝える
    throw new CustomException("Custom exception in TestThrow()");
}

static void CatchCustomException()
{
    try
    {
        TestThrow();
    }
    catch (CustomException ex)
    {
        Console.WriteLine(ex.ToString());
    }
}

static void CatchOrder()
{
    try
    {
        // 存在しないディレクトリを指定して例外を発生させる
        using (var sw = new StreamWriter("./missing/test.txt"))
        {
            sw.WriteLine("Hello");
        }
    }
    catch (DirectoryNotFoundException ex) // ディレクトリが見つからない場合
    {
        Console.WriteLine(ex.GetType().Name);
    }
    catch (FileNotFoundException ex)
    {
        Console.WriteLine(ex.GetType().Name);
    }
    catch (IOException ex) // IOExceptionを最後に処理する
    {
        Console.WriteLine(ex.GetType().Name);
    }

    Console.WriteLine("Done");
}

static void TestFinally()
{
    FileStream? file = null;
    FileInfo fileInfo = new System.IO.FileInfo("./file.txt");

    try
    {
        file = fileInfo.OpenWrite();
        file.WriteByte(0xF);
    }
    finally
    {
        // 例外が起きてもファイルを閉じる
        file?.Close();
    }

    try
    {
        file = fileInfo.OpenWrite();
        Console.WriteLine("OpenWrite() succeeded");
    }
    catch (IOException)
    {
        Console.WriteLine("OpenWrite() failed");
    }

    file?.Close();
}

public class CustomException : Exception
{
    public CustomException(string message) : base(message) { }
}
