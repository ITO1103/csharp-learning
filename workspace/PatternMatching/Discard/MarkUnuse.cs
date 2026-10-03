// 未使用のラムダ パラメーターをマークする

ShowLambdaDiscards();

static void ShowLambdaDiscards()
{
    // senderとEventArgsのどちらも使わないので_で無視する
    EventHandler handler = (_, _) => Console.WriteLine("Timer tick");
    handler(null, EventArgs.Empty);
}