// 「はい」か「いいえ」で答えられる質問をする

object destination = new Navi();
Console.WriteLine(CanRoute(destination));

static bool CanRoute(object? destination) =>
    destination is IRouteStop; // IRouteStopインタフェースを持つか確認


public interface IRouteStop
{
    
}

public class Navi : IRouteStop
{
    
}