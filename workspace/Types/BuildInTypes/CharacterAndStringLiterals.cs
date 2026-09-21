// 文字リテラルと文字列リテラル

// エスケープシーケンス \n \t \u
char newline = '\n';
Console.WriteLine(newline);

// unicodeでの表現も可能 (今回はA)
char unicode = '\u0041'; 
Console.WriteLine(unicode);

string dec = "new";
// $"{}"で文字列中に変数や式を入れる = 文字列補完
string message = $"Found {dec} items";
Console.WriteLine(message);

// @でエスケープ処理を無視させることができ，\\と書く必要がなくなる
string path = @"C:\Users\docs\file.txt";


// """で括ると生文字そのままになる = 生文字列リテラル
string json = """
    {"name": "Alice", "age": 30}
    """;

// $"""で文字列補完が使える
string raw = $"""
    Found {dec} items in "{greeting}"
    """;           