// 中かっこをエスケープし、エスケープ シーケンスを使用する

int[] xs = [1, 2, 7, 9];
int[] ys = [7, 9, 12];
// {}はエスケープされるので，表示したい場合は{{}}にする
Console.WriteLine($"Find the intersection of the {{{string.Join(", ", xs)}}} and {{{string.Join(", ", ys)}}} sets.");

var userName = "Jane";
var stringWithEscapes = $"C:\\Users\\{userName}\\Documents"; // \もエスケープされるので\\と2つにする
var rawInterpolated = $"""C:\Users\{userName}\Documents"""; // """で括るとエスケープされない
Console.WriteLine(stringWithEscapes);
Console.WriteLine(rawInterpolated);