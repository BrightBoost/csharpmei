using System;
namespace BasisCursusMei
{
	public class Job
	{
		public string Title { get; set; }
		public string Description { get; set; }
		public Job(string title, string description)
		{
			Title = title;
			Description = description;
		}

		public void DoWork()
		{
			int dx = 3; // local variable
			if(dx > 4)
			{
				string s = "blabla";
				string s1 = Title;
			} 
		}

        public override string ToString()
        {
			return Title + " : " + Description;
        }
    }
}

