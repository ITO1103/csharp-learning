// クラスとインターフェイスを照合する

ShowCompatibility();

static void ShowCompatibility()
{
    object destination = new ExpressRouteStop("8 Oak Avenue");

    Console.WriteLine($"Exact class: {destination is ExpressRouteStop}"); // 型がExpressRouteStopかチェック
    Console.WriteLine($"Base class: {destination is RouteStop}"); // 基底クラスがRouteStopかチェック
    Console.WriteLine($"Interface: {destination is IRouteStop}"); // インタフェースがIRouteStopかチェック
}
interface IRouteStop{}

// 基底クラス (これ自身のインスタンスを作れない)
abstract class RouteStop(string street) : IRouteStop
{
    public string Street {get;} = street;
    public string GetDisplayName => Street;
}

// 継承先
sealed class ExpressRouteStop(string street) : RouteStop(street)
{
}

