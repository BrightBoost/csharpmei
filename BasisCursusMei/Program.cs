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

       // Person p = new Person("Annemarie", 28, new List<string>() { "toneel", "hockey", "kamperen" });
        //Console.WriteLine(p.Name + " is " + p.Age + " en houdt van " + p.Hobbies[0]);
        Object o = new Object();
        //Object p1 = new Person("Annemarie", 28, new List<string>() { "toneel", "hockey", "kamperen" });
        Job job = new Job("Sitecore developer", "Developing sitecore stuff");
        Employee employee = new Employee("Annemarie", 28, new List<string>() { "toneel", "hockey", "kamperen" }, job);
        Console.WriteLine(employee.Job.Description);
        Celebrate(employee);
        Console.WriteLine(job);
    }

    public int Blabla()
    {
        Console.WriteLine(x);
        return 5;
    }

    public static void Celebrate(IPromotable p)
    {
        p.Promote();
        Console.WriteLine("Feest!");
        List<string> test = new List<string>();
    }
}

