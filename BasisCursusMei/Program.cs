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

        Person p = new Person("x", 28, new List<string>() { "toneel", "hockey", "kamperen" });
        Console.WriteLine(p.Name + " is " + p.Age + " en houdt van " + p.Hobbies[0]);
    }

    public int Blabla()
    {
        Console.WriteLine(x);
        return 5;
    }
}

