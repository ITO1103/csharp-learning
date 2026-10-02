// var パターンを使用してガードの結果をキャプチャする



static string GetDeliveryMessage(object delivery) =>
    delivery switch
    {
        // ExpressDelivery型ならexpressとして受け取る
        ExpressDelivery express
            // EstimateDays(express)の結果をdaysに入れ，2日以下か確認する
            when EstimateDays(express) is var days && days <= 2
                => $"Arrives in {days} day{(days == 1 ? "" : "s")}",
        // ExpressDelivery型で上の条件(days <= 2)には一致しなかった場合
        ExpressDelivery => "Express delivery for your location takes more than two days",
        // それ以外
        _ => "Standard delivery"
    };

// 距離に応じて配送日数を返す
static int EstimateDays(ExpressDelivery delivery) =>
    delivery.MilesAway <= 500 ? 1 :
    delivery.MilesAway <= 1_000 ? 2 : 3;

// 配送先までの距離を持つレコード
record ExpressDelivery(int MilesAway);