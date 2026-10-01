
Delivery? delivery1 = null;
Delivery delivery2 = new ExpressDelivery("EXP-12345");
Delivery delivery3 = new StandardDelivery(2);
Delivery delivery4 = new StandardDelivery(5);

Console.WriteLine(GetDeliveryMessage(delivery1));
Console.WriteLine(GetDeliveryMessage(delivery2));
Console.WriteLine(GetDeliveryMessage(delivery3));
Console.WriteLine(GetDeliveryMessage(delivery4));

Console.WriteLine();

PrintTrackingCode(delivery2);

Console.WriteLine();

PrintPackageStatus(delivery1);
PrintPackageStatus(delivery2);

Console.WriteLine();

PrintDeliveryUpdate(delivery1);
PrintDeliveryUpdate(delivery2);
PrintDeliveryUpdate(delivery3);

Console.WriteLine();

Console.WriteLine(GetStatusMessage(new StandardDelivery(0)));
Console.WriteLine(GetStatusMessage(new StandardDelivery(1)));
Console.WriteLine(GetStatusMessage(new StandardDelivery(3)));
Console.WriteLine(GetStatusMessage(new StandardDelivery(5)));

static string GetDeliveryMessage(Delivery? delivery) =>
    delivery switch
    {
        null => "No delivery was scheduled.",
        ExpressDelivery express => $"Express package {express.TrackingCode}",
        StandardDelivery { Days: <= 2 } => "Standard delivery arriving soon",
        _ => "Standard delivery"
    };

// isで一つの条件をテストする
static void PrintTrackingCode(Delivery delivery)
{
    if (delivery is ExpressDelivery express)
    {
        Console.WriteLine($"Track express package {express.TrackingCode}");
    }
}

static void PrintPackageStatus(Delivery? delivery)
{
    if (delivery is null)
    {
        Console.WriteLine("No package is available.");
    }
    else
    {
        Console.WriteLine("A package is ready to track.");
    }
}

// ステートメントまたは式を選択する
static void PrintDeliveryUpdate(Delivery? delivery)
{
    switch (delivery)
    {
        case null:
            Console.WriteLine("No delivery was scheduled.");
            break;
        case ExpressDelivery express:
            Console.WriteLine($"Express delivery {express.TrackingCode} is ready.");
            Console.WriteLine("Notify the priority desk.");
            break;
        case StandardDelivery standard:
            Console.WriteLine($"Standard delivery arrives in {standard.Days} days.");
            break;
        default:
            Console.WriteLine("Another delivery type is scheduled.");
            break;
    }
}

static string GetStatusMessage(StandardDelivery delivery) =>
    delivery.Days switch
    {
        0 => "Delivered today",
        1 => "Arriving tomorrow",
        <= 3 => "Arriving soon",
        _ => "In transit"
    };

// 配送の基底クラス
public class Delivery
{
}


// 速達配送
public class ExpressDelivery : Delivery
{
    public string TrackingCode {get;}

    public ExpressDelivery(string trackingCode)
    {
        TrackingCode = trackingCode;
    }
}


// 通常配送
public class StandardDelivery : Delivery
{
    public int Days {get;}

    public StandardDelivery(int days)
    {
        Days = days;
    }
}