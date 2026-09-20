// for ループの処理
ExploreLoops();

void ExploreLoops(){
    for (int counter = 0; counter < 10; counter++)
    {
        Console.WriteLine($"Hello World! The counter is {counter}");
    }

    for (int row = 1; row < 11; row++)
    {
        for (char column = 'a'; column < 'k'; column++) // 文字をインクリメントすると次のアルファベットに行くと言う発見
        {
            Console.WriteLine($"The cell is ({row}, {column})");
        }
    }
}

