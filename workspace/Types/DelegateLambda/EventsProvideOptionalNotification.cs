// イベントは省略可能な通知を提供します

MessagePublisher publisher = new();
// MessagePublishedイベントが発生したときに実行する処理を登録
// 第1引数は使わないので_で破棄し，第2引数のmessageだけ使用
publisher.MessagePublished += (_, message) => Console.WriteLine($"Received: {message}");

publisher.Publish("Records updated");