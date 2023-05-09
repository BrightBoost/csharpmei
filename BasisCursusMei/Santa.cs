using System;
namespace BasisCursusMei
{
	// singleton
	public class Santa
	{
		private static Santa instance = null;

		private Santa()
		{
		}

		public static Santa GetPerson()
		{
			if(instance == null)
			{
				instance = new Santa();
			}
			return instance;
		}
	}
}

