// 一般的なLINQメソッド

using System.Collections.Generic;
using System.Linq;

Dictionary<string, int> priorities = new()
{
    ["Docs"] = 2,
    ["Code"] = 1,
    ["Test"] = 3,
    ["Deploy"] = 4
};

IEnumerable<string> plannedWork = priorities
    .Where(workItem => workItem.Value <= 3)
    .OrderBy(workItem => workItem.Value)
    .Select(workItem => $"{workItem.Key}: {workItem.Value}");

foreach (string item in plannedWork)
{
    Console.WriteLine(item);
}
