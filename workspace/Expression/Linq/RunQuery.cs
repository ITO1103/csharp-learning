// クエリを実行する

using System.Collections.Generic;
using System.Linq;

{
    List<string> workItems = ["design", "docs"];

    IEnumerable<string> query = workItems.Where(item => item.StartsWith('d'));

    workItems.Add("deploy");

    // foreachで結果を要求したときにクエリが実行される
    foreach (string item in query)
    {
        Console.WriteLine(item);
    }
}

{
    List<string> workItems = ["design", "docs"];

    IEnumerable<string> query = workItems.Where(item => item.StartsWith('d'));

    // Count()はこの時点で一致する要素を読み取る
    int count = query.Count();
    Console.WriteLine($"Count before add: {count}");

    workItems.Add("deploy");

    Console.WriteLine($"Stored count: {count}");
    Console.WriteLine($"Current count: {query.Count()}");
}
