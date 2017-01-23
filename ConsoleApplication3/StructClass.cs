using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

enum tempenum
{
	yes,
	no
}

namespace ConsoleApplication3
{
	public class Product
	{
		private string name;
		public string Name { get { return name; } set { name = value; } }

		private int price;
		public int Price { get { return price; } set { price = value; } }

		public Product(string name, int price)
		{
			this.name = name;
			this.price = price;
		}

		public static ArrayList GetSampleData()
		{
			ArrayList list = new ArrayList();

			list.Add(new Product("p", 10));
			list.Add(new Product("d", 20));
			list.Add(new Product("a", 30));
			list.Add(new Product("c", 40));
			list.Add(new Product("pe", 50));
			list.Add(new Product("pf", 60));

			return list;
		}

		public override string ToString()
		{
			return string.Format("Name : {0}  Price : {1}", Name, Price);
		}

	}

	public class StructClass
	{
		static void Main2(string[] args)
		{
		//	MakePlunderUserClass.MakePlunderUser();
			
			/*string dirPath = "D:/Procedure"; 

			if(System.IO.Directory.Exists(dirPath))
			{
				System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(dirPath);
				foreach(var item in di.GetFiles())
				{
					using (var stream = item.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None))
					{
						string result = String.Empty;
						using (StreamReader sr = new StreamReader(stream))
						{
							string test_text = sr.ReadToEnd();

							if (test_text.Contains("`thumb`@`localhost`"))
							{
								result = test_text.Replace("`thumb`@`localhost`", "'arkadmin@%'");
							}

							using (StreamWriter sw = new StreamWriter(stream))
							{
								stream.SetLength(0);
								sw.Write(result);

								sw.Close();
							}

							sr.Close();
						}
						
						stream.Close();
					}

				}
			}*/
			
		}

		
	}

}

