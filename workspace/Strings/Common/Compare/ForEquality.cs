// 等しいかどうかを比較する

string root = @"C:\users";
string root2 = @"C:\Users";

// Equalsと==はどちらもデフォルトでは大文字小文字を区別して比較する
Console.WriteLine(root.Equals(root2));
Console.WriteLine(root == root2);

// StringComparisonを指定することで比較方法を明示的に指定できる
Console.WriteLine(root.Equals(root2, StringComparison.Ordinal));

// OrdinalIgnoreCaseで大文字小文字を無視して比較できる
bool equalIgnoringCase = string.Equals(root, root2, StringComparison.OrdinalIgnoreCase);
Console.WriteLine(equalIgnoringCase);