// システム固有サイズの整数

// 環境によってポインタのサイズを合わせるもの
// 普段使わない
// 低レベル環境で使用する可能性
nint bufferSize = 1024;
nuint elementCount = 256;

// コンテナは64bit環境なので8byteになるはず
Console.WriteLine($"nint size: {IntPtr.Size} bytes");
Console.WriteLine($"nuint size: {UIntPtr.Size} bytes");