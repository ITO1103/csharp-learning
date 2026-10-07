// クエリを構成する

using System.Collections.Generic;
using System.Linq;

{
    (string Title, int Priority, bool IsOpen)[] items =
    [
        ("docs", 2, true),
        ("tests", 1, true),
        ("deploy", 3, false),
        ("api", 1, true)
    ];

    IEnumerable<(string Title, int Priority, bool IsOpen)> openItems =
        from item in items
        where item.IsOpen
        select item;

    IEnumerable<string> topOpenItems =
        from item in openItems
        where item.Priority == 1
        orderby item.Title
        select item.Title;

    foreach (string title in topOpenItems)
    {
        Console.WriteLine(title);
    }
}

{
    (string Title, string Area, bool IsOpen)[] items =
    [
        ("write docs", "docs", true),
        ("fix tests", "tests", true),
        ("deploy site", "deploy", false)
    ];

    bool onlyDocs = true;

    IEnumerable<(string Title, string Area, bool IsOpen)> query =
        items.Where(item => item.IsOpen);
    if (onlyDocs)
    {
        query = query.Where(item => item.Area == "docs");
    }

    foreach (string title in query.Select(item => item.Title))
    {
        Console.WriteLine(title);
    }
}

{
    List<(string Title, int Priority, bool IsOpen)> items =
    [
        ("docs", 2, true),
        ("tests", 1, true),
        ("deploy", 3, false)
    ];
    List<(string Title, int Priority, bool IsOpen)> openItems = items
        .Where(item => item.IsOpen)
        .ToList();

    items.Add(("api", 1, true));

    IEnumerable<string> cachedTopOpenItems = openItems
        .Where(item => item.Priority == 1)
        .OrderBy(item => item.Title)
        .Select(item => item.Title);

    foreach (string title in cachedTopOpenItems)
    {
        Console.WriteLine(title);
    }
}
