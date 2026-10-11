// 型パラメーターの名前付けガイドライン

ISessionChannel<Session> channel = new SessionChannel<Session>(new Session("Learn"));
Converter<string, int> converter = int.Parse;
Box<int> box = new(10);

int number = converter("42");
Console.WriteLine($"{channel.Session.Name}: {number}, {box.Value}");

public interface ISession { }

public record Session(string Name) : ISession;

// TSessionの型はISessionを実装する
public interface ISessionChannel<TSession> where TSession : ISession
{
    TSession Session { get; }
}

public class SessionChannel<TSession>(TSession session) : ISessionChannel<TSession>
    where TSession : ISession
{
    public TSession Session { get; } = session;
}

// 型パラメーター名に入力と出力の役割を含める
public delegate TOutput Converter<TInput, TOutput>(TInput from);

public record Box<T>(T Value);
