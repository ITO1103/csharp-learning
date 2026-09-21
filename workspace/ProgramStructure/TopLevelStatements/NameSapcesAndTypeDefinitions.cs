// 名前空間と型の定義

// 最上位ステートメントは名前空間や型定義よりも前に書く必要がある (Cの前方宣言に似ている)
MyClass.TestMethod();
MyNamespace.MyClass.MyMethod();

// これ以下に名前空間や型定義を書く

// 最上位ステートメントは暗黙的にグローバルnamespaceに入る
public class MyClass
{
    public static void TestMethod()
    {
        Console.WriteLine("Hello world!");
    }
}

// 明示的に名前空間を作る
namespace MyNamespace
{
    class MyClass
    {
        public static void MyMethod()
        {
            Console.WriteLine("Hello world from MyNamespace.MyClass.MyMethod!");
        }
    }
}