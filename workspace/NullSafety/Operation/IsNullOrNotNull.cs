// null パターンマッチング：is null と is not null

string? input = null;

// inputがnullか確認する
if (input is null)
{
    Console.WriteLine("No input provided.");
}

// == nullでも確認できる
if (input == null)
{
    Console.WriteLine("Still no input.");
}

string? value = "hello";

// nullではない場合だけ処理する
if (value is not null)
{
    Console.WriteLine(value.ToUpper());
}