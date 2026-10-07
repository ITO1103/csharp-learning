// ラムダ式とLINQ

using System.Collections.Generic;
using System.Linq;

string[] names = ["Ana", "Ben", "Cleo"];

IEnumerable<string> shortNames = names
    .Where(name => name.Length == 3)
    .Select(name => name.ToUpperInvariant());

foreach (string name in shortNames)
{
    Console.WriteLine(name);
}

string[] workItems = ["docs", "test", "deploy"];

IEnumerable<string> querySyntax =
    from item in workItems
    where item.Length == 4
    select item;
IEnumerable<string> methodSyntax =
    workItems.Where(item => item.Length == 4);

foreach (string item in querySyntax)
{
    Console.WriteLine($"Result: {item}");
}

foreach (string item in methodSyntax)
{
    Console.WriteLine($"Result: {item}");
}
