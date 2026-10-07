// 固定サイズのデータを配列に格納する

{
    string[] stages = ["design", "code", "test", "review"];

    Console.WriteLine($"First: {stages[0]}");
    Console.WriteLine($"test index: {Array.IndexOf(stages, "test")}");
}

{
    string[] stages = ["design", "code", "test"];

    stages[0] = "plan";

    Console.WriteLine(string.Join(", ", stages));
    Console.WriteLine($"Length: {stages.Length}");
}
