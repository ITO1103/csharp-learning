// で 1 つの条件をテストする is

static void PrintTrackingCode(Delivery delivery)
{
    if (delivery is ExpressDelivery express)
    {
        Console.WriteLine($"Track express package {express.TrackingCode}");
    }
}