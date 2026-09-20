// 型パターン

// 一連の銀行取引のCSV
string bankRecords = """
    DEPOSIT,   10000, Initial balance
    DEPOSIT,     500, regular deposit
    WITHDRAWAL, 1000, rent
    DEPOSIT,    2000, freelance payment
    WITHDRAWAL,  300, groceries
    DEPOSIT,     700, gift from friend
    WITHDRAWAL,  150, utility bill
    DEPOSIT,    1200, tax refund
    WITHDRAWAL,  500, car maintenance
    DEPOSIT,     400, cashback reward
    WITHDRAWAL,  250, dining out
    DEPOSIT,    3000, bonus payment
    WITHDRAWAL,  800, loan repayment
    DEPOSIT,     600, stock dividends
    WITHDRAWAL,  100, subscription fee
    DEPOSIT,    1500, side hustle income
    WITHDRAWAL,  200, fuel expenses
    DEPOSIT,     900, refund from store
    WITHDRAWAL,  350, shopping
    DEPOSIT,    2500, project milestone payment
    WITHDRAWAL,  400, entertainment
    """;

double currentBalance = 0.0;

foreach(var transaction in TransactionRecoedType(bankRecords))
{
    // 入金の場合
    // switch"式"
    // パターン => 式で直接値を返せる
    // 割と新しい機能 (2019年のC# 8.0から)
    currentBalance += transaction switch // 型で判断する"型パターン"
    {
        // Deposit型なら
        Deposit d => d.Amount, // オブジェクトをdと置いて，dのAmountにアクセスし，それを返す
        // Withdrawal型なら
        Withdrawal w => -w.Amount,
        _ => 0.0,
    };

    Console.WriteLine($"{transaction} => New Balance: {currentBalance}");
}

// オブジェクトを返す？
static IEnumerable<object?> TransactionRecoedType(string inputText)
{
    var reader = new StringReader(inputText);
    string? line;
    
    while((line = reader.ReadLine())is not null)
    {
        string[] parts = line.Split(',');

        string? transactionType = parts[0]?.Trim();
        if(double.TryParse(parts[1].Trim(), out double amount))
        {
            if(transactionType?.ToUpper() is "DEPOSIT")
                yield return new Deposit(amount, parts[2]); // それぞれオブジェクトを持たせて返す
            else if(transactionType?.ToUpper() is "WITHDRAWAL")
                yield return new Withdrawal(amount, parts[2]);
        }
    }
}


// recordはデータのまとまりを表すのに向いた参照型
// 値の比較が便利　(classだと同じクラス，別オブジェクト，同じ値でも値の比較をするとfalseになる)
public record Deposit(double Amount, string description);
public record Withdrawal(double Amount, string description);