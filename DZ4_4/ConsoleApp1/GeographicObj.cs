namespace DZ4_4;

public abstract class GeograficObj
{
    private double X;
    private double Y;
    private string Name;
    private string Characteristic;

    protected GeograficObj(double x, double y, string name, string characteristic)
    {
        X = x;
        Y = y;
        Name = name;
        Characteristic = characteristic;
    }

    public virtual void GetInfo()
    {
        Console.WriteLine($"X = {X}   Y = {Y}");
        Console.WriteLine($"Name = {Name}");
        Console.WriteLine($"Characteristic = {Characteristic}");
    }



}
