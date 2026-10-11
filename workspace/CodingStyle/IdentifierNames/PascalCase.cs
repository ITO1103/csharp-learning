// パスカル ケース

using System;

IWorkerQueue workerQueue = new WorkerQueue();
DataService dataService = new(workerQueue);
Console.WriteLine(dataService.GetQueueCount());

ExampleEvents exampleEvents = new(workerQueue)
{
    IsValid = true
};
exampleEvents.EventProcessing += () => Console.WriteLine("EventProcessing");
exampleEvents.StartEventProcessing();

PhysicalAddress address = new("1 Main St", "Redmond", "WA", "98052");
ValueCoordinate coordinate = new() { X = 2, Y = 3 };
DelegateType printMessage = message => Console.WriteLine(message);

Console.WriteLine($"{address.City}: {coordinate.X}, {coordinate.Y}, {exampleEvents.IsValid}");
printMessage("Started");

public class DataService(IWorkerQueue workerQueue)
{
    private IWorkerQueue _workerQueue = workerQueue;

    // publicなメンバーやメソッドはPascalCaseで付ける
    public int GetQueueCount() => _workerQueue.Count;
}

public record PhysicalAddress(
    string Street,
    string City,
    string StateOrProvince,
    string ZipCode);

public struct ValueCoordinate
{
    public int X { get; init; }
    public int Y { get; init; }
}

public delegate void DelegateType(string message);

public interface IWorkerQueue
{
    int Count { get; }
}

public class WorkerQueue : IWorkerQueue
{
    public int Count => 2;
}

public class ExampleEvents(IWorkerQueue workerQueue)
{
    public bool IsValid;
    public IWorkerQueue WorkerQueue { get; init; } = workerQueue;
    public event Action? EventProcessing;

    public void StartEventProcessing()
    {
        // ローカル関数もPascalCaseで付ける
        static int CountQueueItems(IWorkerQueue queue) => queue.Count;

        Console.WriteLine(CountQueueItems(WorkerQueue));
        EventProcessing?.Invoke();
    }
}
