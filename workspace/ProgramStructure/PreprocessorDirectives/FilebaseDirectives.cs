#!/usr/bin/env dotnet // シバン
// ファイル ベースのアプリ ディレクティブ
// #:でファイルベースアプリのパッケージや設定，オプションを構成する"ビルドシステムディレクティブ"
// packageでNuGetパッケージを追加している
// @*で最新バージョンをPull
#:package Spectre.Console@*

using Spectre.Console; // コンソールの描画をリッチにするライブラリ

AnsiConsole.MarkupLine("[bold green]Hello[/] from a file-based app!");