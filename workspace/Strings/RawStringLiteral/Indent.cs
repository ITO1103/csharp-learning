// インデント: 終了区切り記号によって余白が設定されます

// 終了側の"""の位置が左端の基準になる
string xml = """
        <order id="42">
            <item>book</item>
        </order>
        """;

Console.WriteLine(xml);