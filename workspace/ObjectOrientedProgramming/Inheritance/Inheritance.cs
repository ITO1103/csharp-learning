// 継承 - より特殊な動作を作成するための型の派生

using System;

WorkItem item = new(
    "Fix Bugs",
    "Fix all bugs in my code branch",
    new TimeSpan(3, 4, 0, 0));

ChangeRequest change = new(
    "Change Base Class Design",
    "Add members to the class",
    new TimeSpan(4, 0, 0),
    1);

Console.WriteLine(item.ToString());

change.Update(
    "Change the Design of the Base Class",
    new TimeSpan(4, 0, 0));

Console.WriteLine(change.ToString());

public class WorkItem
{
    private static int _currentId;

    protected int Id { get; set; }
    protected string Title { get; set; } = "";
    protected string Description { get; set; } = "";
    protected TimeSpan JobLength { get; set; }

    public WorkItem()
    {
        Id = 0;
        Title = "Default title";
        Description = "Default description.";
        JobLength = new TimeSpan();
    }

    public WorkItem(string title, string description, TimeSpan jobLength)
    {
        Id = GetNextId();
        Title = title;
        Description = description;
        JobLength = jobLength;
    }

    static WorkItem() => _currentId = 0;

    protected int GetNextId() => ++_currentId;

    public void Update(string title, TimeSpan jobLength)
    {
        Title = title;
        JobLength = jobLength;
    }

    public override string ToString() => $"{Id} - {Title}";
}

public class ChangeRequest : WorkItem
{
    protected int OriginalItemId { get; set; }

    public ChangeRequest() { }

    // WorkItemから継承したメンバーを初期化する
    public ChangeRequest(
        string title,
        string description,
        TimeSpan jobLength,
        int originalId)
    {
        Id = GetNextId();
        Title = title;
        Description = description;
        JobLength = jobLength;
        OriginalItemId = originalId;
    }
}
