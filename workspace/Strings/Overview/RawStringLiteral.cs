// 未加工の文字列リテラル

// """を使うとエスケープせずに複数行の文字列を書ける(JSONやSQLで便利)
string json = """
    {
        "name": "Ada",
        "roles": ["admin", "editor"]
    }
    """;

string sql = """
    SELECT Id, Name
    FROM   Users
    WHERE  Name = 'O''Brien'
    """;

Console.WriteLine(json);
Console.WriteLine(sql);