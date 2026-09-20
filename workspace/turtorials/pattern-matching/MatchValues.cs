// 値を一致させる

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
var reader = new StringReader(bankRecords); // StringReaderメソッドで文字列を非同期で読み込む

string? line; // ?でnullを許容する
while((line = reader.ReadLine()) is not null) // 一行ずつ読む
{
    if(string.IsNullOrWhiteSpace(line)) continue; // nullもしくは何もない場合は続ける
    
    // カンマ(,)でパーツを区切り配列に入れていく
    string[] parts = line.Split(','); 

    // 預け入れか引き出しかの部分を抽出
    string? transactionType = parts[0]?.Trim(); // nullでなければTrim()を実行, Trim()は空白文字の削除
    // double.TryParseで文字列→doubleに変換できるか試行
    // 変換できるのであればdouble amountに値を格納
    if(double.TryParse(parts[1].Trim(), out double amount))
    {
        // 預け入れの場合
        if(transactionType?.ToUpper() is "DEPOSIT")
            currentBalance += amount;
        // 引き出しの場合
        else if(transactionType?.ToUpper() is "WITHDRAWAL")
            currentBalance -= amount;

        Console.WriteLine($"{line.Trim()} => Parsed Amount: {amount}, New Balance: {currentBalance}");
    }
}