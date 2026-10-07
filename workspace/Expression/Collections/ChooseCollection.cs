// コレクションの形を選択する

using System.Collections.Generic;

string[] sprintPlan = ["design", "code", "test"];
List<string> backlog = ["design", "code"];
Dictionary<string, int> priorities = new()
{
    ["docs"] = 2,
    ["tests"] = 1
};

backlog.Add("test");

Console.WriteLine($"Array: {string.Join(", ", sprintPlan)}");
Console.WriteLine($"List count: {backlog.Count}");
Console.WriteLine($"Priority for docs: {priorities["docs"]}");
