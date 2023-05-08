namespace BasisCursusMei;
class Program
{
    public int x = 3;
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World! Hoe oud ben je?");
        string age = Console.ReadLine();
        int year = 2023 - Convert.ToInt32(age);
        Console.WriteLine("Mogelijk geboortejaar: " + year);
        int weekDag = (int)WeekDag.DINSDAG;
        Console.WriteLine(weekDag);
        WeekDag dagVanDeWeek = WeekDag.MAANDAG;
        foreach(var e in Enum.GetValues(typeof(WeekDag))) {
            Console.WriteLine(e);
        }
        
        Math.Sqrt(16);

        ExampleSwitch.DoSwitch(3);
    }

    public int Blabla()
    {
        Console.WriteLine(x);
        return 5;
    }
}

