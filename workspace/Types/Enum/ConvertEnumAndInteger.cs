// 列挙型と整数の間で変換する

var status = HttpStatus.NotFound;
ushort code = (ushort)status; // 整数型へ変換
Console.WriteLine($"Status: {status} ({code})");

var fromCode = (HttpStatus)200; // 整数からEnumへ変換
Console.WriteLine(fromCode);


enum HttpStatus : ushort
{
    OK = 200,
    NotFound = 404,
    InternalServerError = 500
}
