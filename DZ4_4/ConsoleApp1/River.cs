
namespace DZ4_4;

internal class River : GeograficObj
{
    private double RiverSpeed;
    private double RiverLength;

    public River(double x, double y, string name, string characteristic, double speed, double length) : base(x, y, name, characteristic)
    {
        RiverSpeed = speed;
        RiverLength = length;

    }

    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"River Speed = {RiverSpeed}");
        Console.WriteLine($"River Length = {RiverLength}");
    }
}
