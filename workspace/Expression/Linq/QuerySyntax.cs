// LINQ クエリ式構文

using System.Collections.Generic;
using System.Linq;

string[] names = ["Ana", "Ben", "Cleo", "Dara"];

IEnumerable<string> query =
    from name in names
    where name.Length >= 4
    orderby name
    select name;

foreach (string name in query)
{
    Console.WriteLine(name);
}
