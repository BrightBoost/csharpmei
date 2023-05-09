
using System;
namespace BasisCursusMei
{
	public class Person
	{
		private string _name;
		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				if (value.Length > 1)
				{
                    _name = value;
                }
            }
		}
		public int Age { get; set; }
		public List<string> Hobbies { get; set; }

		public Person(string name, int age, List<string> hobbies)
		{
			Name = name;
			Age = age;
			Hobbies = hobbies;
		}
	}
}

