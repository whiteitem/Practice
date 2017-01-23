using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
        class Class3
        {
			static void Main(string[] args) 
			{
				StringBuilder sb = new StringBuilder();

				string temp = "";

				for(int i=0; i< 10; i++){

					sb.AppendFormat("{0}{1}", i, i+1);
					temp = sb;
				}
				Console.WriteLine(temp);

			}
        }
}
