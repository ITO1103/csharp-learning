// case と when を使用したテスト パターン

int measurement = 42;

switch (measurement)
{
    case < 0:
        Console.WriteLine("Negative");
        break;
    case 0:
        Console.WriteLine("Zero");
        break;
    case > 0 when measurement % 2 == 0:
        Console.WriteLine("Positive and even");
        break;
    default:
        Console.WriteLine("Positive and odd");
        break;
}
