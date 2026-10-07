// List<T>でシーケンスを拡大および縮小する

using System.Collections.Generic;

{
    List<string> workItems = ["design", "code", "test"];

    workItems.Add("review");
    workItems.Remove("code");
    workItems[1] = "verify";
    Console.WriteLine(string.Join(", ", workItems));
    Console.WriteLine($"Has review: {workItems.Contains("review")}");
    Console.WriteLine($"Index of verify: {workItems.IndexOf("verify")}");
}

{
    List<string> workItems = ["design", "test"];

    workItems.Insert(1, "code");
    Console.WriteLine($"Insert middle: {string.Join(", ", workItems)}");

    workItems.Insert(0, "plan");
    Console.WriteLine($"Insert front: {string.Join(", ", workItems)}");

    workItems.InsertRange(workItems.Count, ["review", "deploy"]);
    Console.WriteLine($"Insert range at end: {string.Join(", ", workItems)}");

    workItems.RemoveAt(workItems.Count - 1);
    Console.WriteLine($"Remove end: {string.Join(", ", workItems)}");

    workItems.RemoveAt(2);
    Console.WriteLine($"Remove middle: {string.Join(", ", workItems)}");

    workItems.RemoveAt(0);
    Console.WriteLine($"Remove front: {string.Join(", ", workItems)}");
}
