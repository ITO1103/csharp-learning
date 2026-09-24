// Parse と TryParse を使用してテキストを解析する

string textValue = "512";
// Parseでstringをintに変換する
// 変換できない文字列の場合は例外が発生する
int parsed = int.Parse(textValue);

string userInput = "12x";
// TryParseでstringをintに変換できるか試す
// 成功した場合はtrueを返し，変換した値をsafeValueに入れる
// 失敗した場合はfalseを返し，例外は発生しない
bool parsedSuccessfully = int.TryParse(userInput, out int safeValue);


Console.WriteLine($"parsed: {parsed}");
// TryParseに成功していればsafeValueを表示し，失敗していればエラー文を表示
Console.WriteLine(parsedSuccessfully ? $"safe value: {safeValue}" : "Input is not a valid number.");