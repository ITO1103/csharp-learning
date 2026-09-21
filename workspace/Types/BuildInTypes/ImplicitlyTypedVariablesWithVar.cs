// 暗黙的に型指定された変数 var
// コンパイラが初期化の値から型推論をする

// int
var count = 10;

// string
var name = "C#";

// List<int?>
var items = new List<int>();

// 右辺を見ると型が明らかな場合に使用すると視覚的に良い
// 例
Dictionary<string, List<int>> scores = new Dictionary<string, List<int>>();
// 上下は同じ
var goodscores = new Dictionary<string, List<int>>();