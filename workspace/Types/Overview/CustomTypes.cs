// 組み込み型とカスタム型

// 組み込み型

// 整数
int age = 25;

// 小数
double price = 19.99;

// 真偽値
bool isActive = true;

// 1文字
char grade = 'A';

// 文字列
string name = "Alice";

Console.WriteLine($"int: {age}");
Console.WriteLine($"double: {price}");
Console.WriteLine($"bool: {isActive}");
Console.WriteLine($"char: {grade}");
Console.WriteLine($"string: {name}");

// カスタム型

// enum: 固定された選択肢を表す型
TransactionType transactionType = TransactionType.Deposit;
Console.WriteLine($"enum: {transactionType}");


// tuple: 複数の値を一時的にまとめる
(string name, int age) person = ("Bob", 20);
Console.WriteLine($"tuple: {person.name}, {person.age}");


// class: 一般的なオブジェクトを表す参照型
var player1 = new Player("Alice", 100);
var player2 = player1;

// classは参照型なので，同じオブジェクトを参照する
player2.Hp = 50;

Console.WriteLine($"class player1: {player1.Hp}");
Console.WriteLine($"class player2: {player2.Hp}");


// struct: 値型なので，代入すると値そのものがコピーされる
var point1 = new Point(10, 20);
var point2 = point1;

point2.X = 100;

Console.WriteLine($"struct point1: {point1.X}, {point1.Y}");
Console.WriteLine($"struct point2: {point2.X}, {point2.Y}");


// record: データのまとまりを表すのに向いた参照型
// 別オブジェクトでも値が同じなら値として比較できる
var user1 = new User("Alice", 25);
var user2 = new User("Alice", 25);

Console.WriteLine($"record comparison: {user1 == user2}");


// record struct: recordの特徴を持つ値型
var size1 = new Size(1920, 1080);
var size2 = size1;

Console.WriteLine($"record struct: {size2}");


// interface: 「この機能を持つこと」という契約
IPaymentProcessor paymentProcessor = new CreditCardProcessor();
paymentProcessor.Process(1000);


// generic:
// 型を後から指定して再利用できる仕組み
List<string> names = new();
names.Add("Alice");
names.Add("Bob");

Console.WriteLine($"generic List<T>: {names[0]}");

// 型定義
// enum
public enum TransactionType
{
    Deposit,
    Withdrawal,
    Invalid
}


// class
public class Player
{
    public string Name { get; set; }
    public int Hp { get; set; }

    public Player(string name, int hp)
    {
        Name = name;
        Hp = hp;
    }
}


// struct
public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}


// record
public record User(string Name, int Age);


// record struct
public record struct Size(int Width, int Height);


// interface
public interface IPaymentProcessor
{
    void Process(double amount);
}


// interfaceを実装するclass
public class CreditCardProcessor : IPaymentProcessor
{
    public void Process(double amount)
    {
        Console.WriteLine($"Credit card payment: {amount}");
    }
}