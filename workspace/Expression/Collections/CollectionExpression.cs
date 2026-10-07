// コレクション式を使用してコレクションを作成する

using System.Collections.Generic;

string[] planned = ["design", "code"];
// .. plannedでplannedの各要素をコピーする
string[] upcoming = [.. planned, "test"];
List<string> blocked = ["docs"];

Console.WriteLine($"Upcoming: {string.Join(", ", upcoming)}");
Console.WriteLine($"Blocked: {string.Join(", ", blocked)}");
