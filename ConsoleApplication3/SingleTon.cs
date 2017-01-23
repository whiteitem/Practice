using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
	class SingleTon
	{
		private static SingleTon singeton = new SingleTon();

		private SingleTon()
		{
		}

		public static SingleTon getInstance()
		{
			return singeton;
		}

		public void ToString(string temp)
		{
			Console.WriteLine(temp + temp);
		}

	}
}
