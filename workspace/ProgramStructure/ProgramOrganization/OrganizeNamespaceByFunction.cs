// 型の種類ではなく、機能別に名前空間を整理する
namespace MyApp.Payments;
// 機能ベースでインターフェース，実装，サポート型を配置することが望ましい

// interfaceとは：「この型はこの機能を必ず持つ」という契約を定義する = 共通ルール
// interfaceの場合，名前の先頭に"I"をつけるのが一般的な命名規則
public interface IPaymentProcessor
{
    bool ProcessPayment(decimal amount);
}

// 契約しているので ProcessPayment(decimal amount)を必ず使っている
public class CreditCardProcessor : IPaymentProcessor
{
    public bool ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing credit card payment of {amount:C}");
        return true;
    }
}

public record PaymentResult(bool Success, string? TransactionId);