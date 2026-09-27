// null 状態分析

NullStateTracking();
Node root = new("Root");
Node child = new("Child")
{
    Parent = root
};

FlowAnalysis(child);

static void NullStateTracking()
{
    string? message = null;
    // Console.WriteLine(message.Length); コンパイラは警告，実行時はエラーを出す
    
    message = "Hello World!";
    Console.WriteLine(message.Length);
}

static void FlowAnalysis(Node start)
{
    Node? current = start;
    while(current is not null)
    {
        Console.WriteLine(current.Name);
        current = current.Parent;
    }
}

public sealed class Node(string name)
{
    public string Name {get;} = name;
    public Node? Parent {get; init;} // 親がいないNodeもあるのでnullを許容
}

