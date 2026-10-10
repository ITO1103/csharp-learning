// 例外の作成とスロー

using System;
using System.IO;

try
{
    CopyObject(null!);
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.ParamName);
}

string logPath = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
File.WriteAllText(logPath, "");

ProgramLog programLog = new();
programLog.OpenLog(new FileInfo(logPath), FileMode.Open);

try
{
    programLog.WriteLog();
}
catch (InvalidOperationException ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    programLog.CloseLog();
    File.Delete(logPath);
}

int[] numbers = [10, 20, 30];
Console.WriteLine(GetValueFromArray(numbers, 1));

try
{
    GetValueFromArray(numbers, 5);
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine(ex.InnerException?.GetType().Name);
}

static void CopyObject(SampleClass original)
{
    // originalがnullなら例外をスローする
    _ = original ?? throw new ArgumentException("Parameter cannot be null", nameof(original));
}

static int GetValueFromArray(int[] array, int index)
{
    try
    {
        return array[index];
    }
    catch (IndexOutOfRangeException ex)
    {
        // 元の例外をInnerExceptionとして残す
        throw new ArgumentOutOfRangeException(
            "Parameter index is out of range.", ex);
    }
}

public class SampleClass;

public class ProgramLog
{
    private FileStream logFile = null!;

    public void OpenLog(FileInfo fileName, FileMode mode)
    {
        // 読み取り専用で開く
        logFile = fileName.Open(mode, FileAccess.Read);
    }

    public void WriteLog()
    {
        if (!logFile.CanWrite)
        {
            throw new InvalidOperationException("Logfile cannot be read-only");
        }
    }

    public void CloseLog() => logFile.Close();
}
