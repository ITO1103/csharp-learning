// 型を使用して変数を宣言する

// 明示的に指定
int count = 10;
double temperature = 36.6;

// コンパイラが代入された値から方を推定する
var name = "C#";
var items = new List<string> { "one", "two", "three" };

// stringとintを受け取り，stringを返す
static string GetGreeting(string name, int visitCount)
{
    return visitCount switch
    {
        1 => $"Welcome, {name}!", // visitcountがある場合 = 訪問済みの場合
        _ => $"Welcome back, {name}! Visit #{visitCount}." // 初回訪問の場合
    };
}