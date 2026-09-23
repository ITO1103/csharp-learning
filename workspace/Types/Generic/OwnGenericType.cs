// 独自のジェネリック型を作成する

// Tにintを指定してGenericListを作成
var list = new GenericList<int>();
for (var i = 0; i < 5; i++)
{
    list.AddHead(i);
}
// GetEnumerator()が定義されているのでforeachで順番に取り出せる
foreach (var item in list)
{
    Console.Write($"{item} ");
}
Console.WriteLine();

// 格納する型を後から指定できる独自のジェネリック型
public class GenericList<T>
{
    // リストの1つの要素を表すNode
    // DataにT型の値を持ち，Nextで次のNodeを参照する
    private class Node(T data)
    {
        public T Data { get; set; } = data;
        public Node? Next { get; set; }
    }

    // リストの先頭のNode
    private Node? head;

    // リストの先頭にT型のデータを追加する
    public void AddHead(T data)
    {
        // 新しいNodeのNextに現在の先頭を設定
        var node = new Node(data) { Next = head };
        // 新しく作ったNodeを先頭にする
        head = node;
    }

    // foreachで要素を順番に取り出せるようにする
    public IEnumerator<T> GetEnumerator()
    {
        var current = head;
        while (current is not null)
        {
            // 現在のNodeのデータを返す
            yield return current.Data;
            // 次のNodeへ移動
            current = current.Next;
        }
    }
}