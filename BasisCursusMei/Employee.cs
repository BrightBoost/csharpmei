using System;
namespace BasisCursusMei
{
	public class Employee : Person, IPromotable
	{
		public Job Job { get; set; }

		public Employee(string name, int age, List<string> hobbies, Job job) : base(name, age, hobbies)
		{
			Job = job;
		}

        public override void Greet()
        {
			Console.WriteLine("Goedemiddag");
        }

        public void Promote()
        {
            Console.WriteLine("Woehoe.");
        }
    }
}

