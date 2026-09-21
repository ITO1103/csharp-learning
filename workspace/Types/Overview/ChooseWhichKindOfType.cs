// どの種類を選ぶか選択してください


// タプル
// 一時的に複数の値をまとめたい場合
// わざわざ名前付きの型を定義するほどではないときに使う
(string name, int age) person = ("Alice", 20);
Console.WriteLine($"{person.name}, {person.age}");


// struct / record struct
// 小さなデータを値そのものとして扱いたい場合
// 代入すると値がコピーされる
Point point1 = new(10, 20);
Point point2 = point1;

// record structなのでpoint1とpoint2は別々の値
Console.WriteLine(point1);
Console.WriteLine(point2);


// record class
// データを表すことが中心の場合
// 値による比較やwithを使いたい場合
User user1 = new("Alice", 20);
User user2 = new("Alice", 20);

// 別オブジェクトでも値が同じなのでtrue
Console.WriteLine(user1 == user2);

// 元のuser1を変更せず，新しいrecordを作る
User user3 = user1 with { Age = 21 };

Console.WriteLine(user1);
Console.WriteLine(user3);


// class
// 状態を持って変化したり，複雑な処理を持つオブジェクト
Player player = new("Alice", 100);

player.Damage(20);

Console.WriteLine($"{player.Name}: HP={player.Hp}");


// interface
// 複数の型に共通する機能・契約を定義したい場合
IPaymentProcessor processor = new CreditCardProcessor();

processor.Process(1000);


// enum
// 決まった選択肢を表したい場合
TransactionStatus status = TransactionStatus.Success;

Console.WriteLine(status);


// 型定義

// 小さな値として扱うデータ
public readonly record struct Point(int X, int Y);


// データ中心の参照型
public record User(string Name, int Age);


// 複雑な状態や処理を持つ型
public class Player
{
    public string Name { get; }
    public int Hp { get; private set; }

    public Player(string name, int hp)
    {
        Name = name;
        Hp = hp;
    }

    public void Damage(int damage)
    {
        Hp -= damage;
    }
}


// 共通の契約
public interface IPaymentProcessor
{
    void Process(double amount);
}


// interfaceを実装するclass
public class CreditCardProcessor : IPaymentProcessor
{
    public void Process(double amount)
    {
        Console.WriteLine($"Payment: {amount}");
    }
}


// 固定された選択肢
public enum TransactionStatus
{
    Success,
    Failed,
    Pending
}