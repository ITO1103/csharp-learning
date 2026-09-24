// 暗黙的および明示的な数値変換

int itemCount = 42;
long widened = itemCount; // 暗黙的な型変換
// 暗黙的な型変換は常に成功するらしい？？？

double average = 19.75;
int truncated = (int)average; // 明示的な型変換
// 明示的な変換は失敗もしくは情報が失われる(double→intで少数が消える)可能性がある

Console.WriteLine($"widened: {widened}, truncated: {truncated}");