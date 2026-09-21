// 条件付きコンパイル

// ファイルベースアプリの場合，デフォルトのビルド構成がDebugなので，Releaseにする場合は以下のコマンド
// dotnet run --file ConditionalCompilation.cs --configuration Release

// .NETの別バージョンでの動作を確認する場合はこのコンテナに別のバージョンを入れて下記で指定
// #:property TargetFramework=net8.0

ConfigureLogging();

static void ConfigureLogging()
{
#if DEBUG // デバッグビルドの場合
    Console.WriteLine("Debug logging enabled — verbose output active.");
#else // デバッグビルド以外の場合
    Console.WriteLine("Release logging — errors only.");
#endif
}

ShowPlatformInfo();


static void ShowPlatformInfo()
{
#if NET10_0_OR_GREATER // .NET10.0以上の場合(本環境)
    Console.WriteLine("Running on .NET 10 or later.");
#elif NET8_0_OR_GREATER
    Console.WriteLine("Running on .NET 8 or 9.");
#else
    Console.WriteLine("Running on an older .NET version.");
#endif
}