// 定数文字列をビルドする

const string Audience = "world";
const string Greeting = $"Hello, {Audience}!"; // 全ての補完式がstringである場合は定数補完文字列を作成可能
Console.WriteLine(Greeting);