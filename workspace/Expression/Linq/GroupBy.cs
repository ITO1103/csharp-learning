// 関連する値をグループ化する

using System.Collections.Generic;
using System.Linq;

string[] labels = ["api", "auth", "docs", "deploy"];

IEnumerable<IGrouping<char, string>> groups = labels.GroupBy(label => label[0]);

foreach (IGrouping<char, string> group in groups)
{
    Console.WriteLine($"{group.Key}: {string.Join(", ", group)}");
}
