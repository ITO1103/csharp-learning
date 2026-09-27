// null 合体演算子 ??

string? username = null;

// usernameがnullなので"Guest"を使用する
string display = username ?? "Guest";

Console.WriteLine(display);

username = "alice";

// usernameに値があるのでその値を使用する
display = username ?? "Guest";

Console.WriteLine(display);