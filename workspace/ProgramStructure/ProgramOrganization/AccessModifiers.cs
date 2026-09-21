// アクセス修飾子とアセンブリ
namespace MyApp.Inventory;

// public: 全てのアセンブリからアクセス可能
public class InventoryService
{
    // => は式形式メンバーという書き方
    // return StockDatabase.Lookup(productName);と同じ
    // だが，今回の場合はInventoryServiceが外部向けの窓口として機能する (内部実装を隠せる)
    public int GetStockLevel(string productName) => StockDatabase.Lookup(productName);
}

// internal: 同じアセンブリ内でのみアクセス可能
// 他のプロジェクトで必要とされない型には既定でinternalを使用するのが望ましい
internal static class StockDatabase
{
    // private: 
    private static readonly Dictionary<string, int> _stock = new()
    {
        ["Widget"] = 42,
        ["Gadget"] = 17
    };

    internal static int Lookup(string productName) => _stock.GetValueOrDefault(productName);
}