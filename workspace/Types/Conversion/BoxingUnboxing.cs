// ボックス化とアンボックス化とは

int temperature = 72;
// ボックス化
object boxedTemperature = temperature;
//アンボックス化
int unboxedTemperature = (int)boxedTemperature;

Packet packet = new(7);
// インターフェース参照によるボックス化
ILabelled labelledPacket = packet;

Console.WriteLine($"Unboxed: {unboxedTemperature}, Label: {labelledPacket.Label}");


struct Packet : ILabelled
{
    public int Id {get;}

    public Packet(int id)
    {
        Id = id;
    }

    public string Label => $"Packet-{Id}";
}

interface ILabelled
{
    string Label {get;}
}