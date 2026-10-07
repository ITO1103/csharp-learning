// LINQ メソッド構文

using System.Collections.Generic;
using System.Linq;

string[] names = ["Ana", "Ben", "Cleo", "Dara"];

IEnumerable<string> query = names
    .Where(name => name.Length >= 4)
    .OrderBy(name => name)
    .Select(name => name);

foreach (string name in query)
{
    Console.WriteLine(name);
}

(string Area, int Priority)[] workItems =
[
    ("docs", 2),
    ("tests", 1),
    ("deploy", 4),
    ("api", 1)
];

IEnumerable<string> nextItems =
    from item in workItems
    let label = $"{item.Area}: P{item.Priority}"
    where item.Priority <= 2
    orderby item.Priority, item.Area
    select label;

foreach (string item in nextItems)
{
    Console.WriteLine(item);
}

List<string> workItemsForCount = ["design", "docs", "deploy", "review"];

int count = workItemsForCount.Count(item => item.StartsWith('d'));

Console.WriteLine($"Starts with d: {count}");
