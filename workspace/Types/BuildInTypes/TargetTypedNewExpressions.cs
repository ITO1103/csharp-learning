// ターゲット型の new 式

// 左辺から型を推論できるため，new()の型名を省略できる
// List<string> name = new List<string>() {"Alice", "Bob", "Charlie"};
List<string> names = new() {"Alice", "Bob", "Charlie"};


// Dictionaryも同じく左辺から型を推論できるため，new()の型名を省略できる
// Dictionary<string, int> score = new Dictionary<string, int>
// {
//     ["Alice"] = 95,
//     ["Bob"] = 87
// };
Dictionary<string, int> scores = new()
{
    ["Alice"] = 95,
    ["Bob"] = 87
};