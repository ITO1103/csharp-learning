// Dictionary<TKey,TValue>を使用してキーで値を関連付ける

using System.Collections.Generic;

{
    Dictionary<string, int> priorities = new()
    {
        ["docs"] = 2,
        ["tests"] = 1
    };

    priorities["review"] = 3;
    priorities.Remove("review");

    if (priorities.TryGetValue("docs", out int docsPriority))
    {
        Console.WriteLine($"docs priority: {docsPriority}");
    }
    else
    {
        Console.WriteLine("docs missing");
    }

    if (priorities.TryGetValue("deploy", out int deployPriority))
    {
        Console.WriteLine($"deploy priority: {deployPriority}");
    }
    else
    {
        Console.WriteLine("deploy missing");
    }

    Console.WriteLine($"count: {priorities.Count}");
}

{
    Dictionary<string, int> priorities = new()
    {
        ["docs"] = 2,
        ["tests"] = 1
    };

    priorities["docs"] = 1;

    if (priorities.TryGetValue("tests", out int testsPriority))
    {
        priorities["tests"] = testsPriority + 1;
    }

    priorities["deploy"] = 3;

    Console.WriteLine($"docs priority: {priorities["docs"]}");
    Console.WriteLine($"tests priority: {priorities["tests"]}");
    Console.WriteLine($"deploy priority: {priorities["deploy"]}");
}
