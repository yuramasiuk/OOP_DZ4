
namespace DZ4_4;

internal class Rock : GeograficObj
{

    private double Peak;

    public Rock(double x, double y, string name, string characteristic, double peak) : base(x, y, name, characteristic)
    {
        Peak = peak;
    }
    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"Highest point of the mountain  = {Peak}");
    }



}
