// スレッドセーフなデリゲートの呼び出し

EventHandler? clicked = null;

// clickedがnullなので何も実行しない
clicked?.Invoke(null, EventArgs.Empty);

// イベントに処理を登録する
clicked += (_, _) => Console.WriteLine("Button clicked!");

// clickedがnullではないので登録した処理を実行する
clicked?.Invoke(null, EventArgs.Empty);