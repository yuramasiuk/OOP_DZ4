
using System.Security.Cryptography.X509Certificates;
using DZ4_4;
internal class Program
{
    private static void Main(string[] args)
    {
        int choose;
        double X, Y, Speed, Length, Peak;
        string Name, Chars;


        Console.WriteLine("What would you like to choose: ");
        Console.WriteLine("1 - River: ");
        Console.WriteLine("2 - Rock: ");
        choose = Convert.ToInt32(Console.ReadLine());
        switch (choose)
        {
            case 1:
                Console.Write("Write X: ");
                X = Convert.ToDouble(Console.ReadLine());
                Console.Write("Write Y: ");
                Y = Convert.ToDouble(Console.ReadLine());
                Console.Write("Write Name: ");
                Name = Console.ReadLine() ?? throw new ArgumentNullException(nameof(Name));
                Console.Write("Write Characteristic: ");
                Chars = Console.ReadLine() ?? throw new ArgumentNullException(nameof(Chars));
                Console.Write("Write Speed: ");
                Speed = Convert.ToDouble(Console.ReadLine());
                Console.Write("Write Length: ");
                Length = Convert.ToDouble(Console.ReadLine());
                River river = new River(X, Y, Name, Chars, Speed, Length);
                river.GetInfo();
                break;
            case 2:

                Console.Write("Write X: ");
                X = Convert.ToDouble(Console.ReadLine());
                Console.Write("Write Y: ");
                Y = Convert.ToDouble(Console.ReadLine());
                Console.Write("Write Name: ");
                Name = Console.ReadLine() ?? throw new ArgumentNullException(nameof(Name));
                Console.Write("Write Characteristic: ");
                Chars = Console.ReadLine() ?? throw new ArgumentNullException(nameof(Chars));
                Console.Write("Write Peak: ");
                Peak = Convert.ToDouble(Console.ReadLine());
                Rock rock = new Rock(X, Y, Name, Chars, Peak);
                rock.GetInfo();
                break;




        }



    }
}




