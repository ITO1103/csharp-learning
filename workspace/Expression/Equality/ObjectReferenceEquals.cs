// Object.ReferenceEqualsを使用して ID を直接テストする

var doc1 = new Document("Report");
var doc2 = new Document("Report");
var doc3 = doc1;

// 別々にnewしているので異なるインスタンス
Console.WriteLine(ReferenceEquals(doc1, doc2));

// doc3はdoc1と同じインスタンスを参照している
Console.WriteLine(ReferenceEquals(doc1, doc3));


class Document
{
    public string Title {get;}

    public Document(string title)
    {
        Title = title;
    }
}