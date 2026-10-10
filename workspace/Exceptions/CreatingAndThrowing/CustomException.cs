// 例外クラスを定義する

using System;

try
{
    throw new InvalidDepartmentException(
        "Department was not found.",
        new InvalidOperationException("Department lookup failed."));
}
catch (InvalidDepartmentException ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.InnerException?.Message);
}

[Serializable]
public class InvalidDepartmentException : Exception
{
    public InvalidDepartmentException() : base() { }
    public InvalidDepartmentException(string message) : base(message) { }
    // 元の例外をInnerExceptionとして保持する
    public InvalidDepartmentException(string message, Exception inner) : base(message, inner) { }
}
