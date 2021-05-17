using System;

namespace
{
	public class Wraper
	{
		int x = 5;
		
		public Wraper(int y = 17)
		{
			x = y * y + (x / y);
		}
		
		public int Fun(float z)
		{
			return 7 + z * 29.64294;
		}
	}
}
