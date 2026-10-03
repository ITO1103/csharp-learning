// スライス パターンを使用して残余の要素を許可する

Console.WriteLine(GetInputFile(["--verbose", "input.txt"]));
Console.WriteLine(GetInputFile(["--verbose", "abc", "def", "input.txt"]));
Console.WriteLine(GetInputFile(["abc", "input.txt"]));
Console.WriteLine(GetInputFile([]));

static string GetInputFile(string[] arguments) =>
    arguments switch
    {
        // 最初が"--verbose"で，最後の要素をfileNameとして取得する
        ["--verbose", .., var fileName] => $"Verbose processing: {fileName}",

        // 最後の要素をfileNameとして取得する．それより前は何個あってもよい
        [.., var fileName] => $"Processing: {fileName}",

        // 要素が0個の場合
        [] => "No input file was provided"
    };