// 複数行の生文字列

// 複数行の文字列もそのまま書ける
string sql = """
    SELECT id, name
    FROM customers
    WHERE active = 1
    """;

Console.WriteLine(sql);

// 概要で結構説明しているせいでかなり内容が被っている...