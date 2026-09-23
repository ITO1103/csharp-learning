// 基になる型と明示的な値を指定する


HpptStatus status = HpptStatus.OK;

Console.WriteLine(status);
Console.WriteLine((ushort)status);

// 基となる型はchar型を除く任意の整数型にすることができる
// byte short ushort int uint long ulong
enum HpptStatus : ushort
{
    OK = 200,
    NotFount = 404,
    InternalServerError = 500
}
