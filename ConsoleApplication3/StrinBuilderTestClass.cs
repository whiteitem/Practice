using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
	class StrinBuilderTestClass
	{
		public void StringBuilderTest()
		{
			StringBuilder sb = new StringBuilder();

			string temp = "";

			for (int i = 0; i < 10; i++)
			{
				sb.Remove(0, sb.Length);
				sb.AppendFormat("{0}{1} \n", i, i + 1);
				temp = sb.ToString();
				Console.WriteLine(temp);
			}

		}
	}
}
