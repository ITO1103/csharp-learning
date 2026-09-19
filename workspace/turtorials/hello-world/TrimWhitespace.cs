// 文字列から空白を削除する
string greeting = "    Hello world!    ";
Console.WriteLine($"[{greeting}]");

// 文字列の先頭までの空白文字を削除する
string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");

// 文字列の末尾から後の空白文字を削除する
trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");

// 文字列の先頭と末尾にある空白文字を削除する
trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");