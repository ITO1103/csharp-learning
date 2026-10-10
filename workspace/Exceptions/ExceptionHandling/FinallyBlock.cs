// Finally ブロック

using System.IO;

TestFinally();

static void TestFinally()
{
    FileStream? file = null;
    FileInfo fileInfo = new(Path.Combine(Path.GetTempPath(), Path.GetRandomFileName()));

    try
    {
        file = fileInfo.OpenWrite();
        file.WriteByte(0xF);
    }
    finally
    {
        // fileがnullでなければ閉じる
        file?.Close();
    }

    File.Delete(fileInfo.FullName);
}
