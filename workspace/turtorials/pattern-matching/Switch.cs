// 徹底的な一致 switch

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

foreach(var transaction in TransactionRecords(bankRecords))
{
    // 入金の場合
    // switch"式"
    // パターン => 式で直接値を返せる
    // 割と新しい機能 (2019年のC# 8.0から)
    currentBalance += transaction switch
    {
        // 帰ってきたtransactionのTransactionTypeがDepositかWithdrawalか，
        // 二つ目の要素をamountに代入し，amountを返す
        (TransactionType.Deposit, var amount) => amount,
        // 引き出しの場合はマイナスにして返す
        (TransactionType.Withdrawal, var amount) => -amount,
        _ => 0.0, // それ以外の場合
    };

    Console.WriteLine($"{transaction.type} => Parsed Amount: {transaction.amount}, New Balance: {currentBalance}");
}



// IEnumerable: タプルを複数個順番に返せるもの．今回の場合はenumのTransactionTypeとdoubleのタプル
// だからforeachでループが作れる
static IEnumerable<(TransactionType type, double amount)> TransactionRecords(string inputText)
{
    // 入力文字列を読む
    var reader = new StringReader(inputText);
    string? line; // null許容
    while((line = reader.ReadLine()) is not null) // 文字列がなくなるまで一行ずつ読む
    {
        string[] parts = line.Split(','); //カンマで区切ってパーツごとにする

        string? transactionType = parts[0]?.Trim(); // 操作を入れる
        // parts[1]がdoubleに変換できるのであれば，変換→double型として返す
        if(double.TryParse(parts[1].Trim(), out double amount))
        {
            // 預け入れの場合
            if (transactionType?.ToUpper() is "DEPOSIT")
                // yield returnで順番に返すことができる = foreachでループが回る
                // Listに入れてからreturnで返すことも可能
                yield return (TransactionType.Deposit, amount);
            // 引き出しの場合
            else if (transactionType?.ToUpper() is "WITHDRAWAL")
                yield return (TransactionType.Withdrawal, amount);
        }
        else
        {
            yield return (TransactionType.Invalid, 0.0);
        }
    }
}



// 操作タイプの型
public enum TransactionType
{
    Deposit,
    Withdrawal,
    Invalid
}

