// インデックスと範囲を使用して位置から読み取る

using System.Collections.Generic;

string[] phases = ["design", "code", "test", "deploy"];
List<string> checklist = ["design", "test", "review"];

Console.WriteLine($"Last: {phases[^1]}");
Console.WriteLine($"Middle: {string.Join(", ", phases[1..3])}");
Console.WriteLine($"Last two: {string.Join(", ", phases[^2..])}");
Console.WriteLine($"Without ends: {string.Join(", ", phases[1..^1])}");
Console.WriteLine($"First two: {string.Join(", ", phases[..2])}");
Console.WriteLine($"From third: {string.Join(", ", phases[2..])}");
Console.WriteLine($"All phases: {string.Join(", ", phases[..])}");
Console.WriteLine($"List last: {checklist[^1]}");
Console.WriteLine($"List first two: {string.Join(", ", checklist[0..2])}");
