// クラスを宣言します

// 規定値はinternal (同じアセンブリからのみアクセス可能)
public class Customer
{
    // string Nameを取得，変更
    public string Name {get; set;}
    // Customerコンストラクタで受け取ったnameをNameに代入
    public Customer(string name) => Name = name;
}
