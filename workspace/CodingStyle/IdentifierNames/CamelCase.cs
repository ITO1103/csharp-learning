// Camel 形式

using System;

IWorkerQueue workerQueue = new WorkerQueue();
DataService dataService = new(workerQueue, new ConsoleLogger());
dataService.ProcessData();

Point point = new(3, 4);
Person person = new("Ana", "Smith");
Address address = new("1 Main St", "Redmond", "WA", "98052");

Console.WriteLine(point.Distance);
Console.WriteLine($"{person.FirstName} {person.LastName}: {address.City}");
Console.WriteLine(DataService.ThreadTime);

public class DataService(IWorkerQueue workerQueue, ILogger logger)
{
    // インスタンスフィールドは_から始める
    private IWorkerQueue _workerQueue = workerQueue;

    // staticフィールドはs_から始める
    private static IWorkerQueue s_workerQueue = new WorkerQueue();

    // ThreadStaticフィールドはt_から始める
    [ThreadStatic]
    private static TimeSpan t_timeSpan;

    public static TimeSpan ThreadTime => t_timeSpan;

    public void ProcessData()
    {
        logger.LogInformation("Processing data");
        _workerQueue.Enqueue("data");
        s_workerQueue.Enqueue("shared data");
        t_timeSpan = TimeSpan.FromSeconds(1);
    }
}

public interface IWorkerQueue
{
    int Count { get; }
    void Enqueue(string item);
}

public class WorkerQueue : IWorkerQueue
{
    public int Count { get; private set; }

    public void Enqueue(string item) => Count++;
}

public interface ILogger
{
    void LogInformation(string message);
}

public class ConsoleLogger : ILogger
{
    public void LogInformation(string message) => Console.WriteLine(message);
}

public struct Point(double x, double y)
{
    public double Distance => Math.Sqrt(x * x + y * y);
}

public record Person(string FirstName, string LastName);
public record Address(string Street, string City, string StateOrProvince, string PostalCode);
