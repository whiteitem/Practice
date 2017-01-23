using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Timers;


[Flags]
enum Border
{
	None = 0,
	Top = 1,
	Right = 2,
	Bottom = 4,
	Left = 8
}


namespace ConsoleApplication3
{

	
	

	class Egg
	{
		private string d_name;
		private int d_price;
		protected string Name{get{return d_name;}set{d_name= value;}}
		protected int Price { get { return d_price; } set { d_price = value; } }


		public string ToInfo()
		{
			return "2";
		}

		public void Test()
		{
			Console.WriteLine(this.GetType().Name);
		}
		

	}

	class Egg2 : Egg
	{
		private bool run = false;
		public string ToInfo()
		{
			return string.Format("Name : {0}    Price : {1}", this.Name, this.Price);
		}

		public Egg2(string name, int price, bool run)
		{
			this.Name = name;
			this.Price = price;
			this.run = run;
		}

		public string Run()
		{
			return string.Format("Run : {0}", run);
		}

	}

	public static class MyUtility
	{
		private static int ver;

		static MyUtility()
		{
			ver = 1;
		}

		public static string Convert(int i)
		{
			Console.WriteLine("Convert");
			return i.ToString().ToUpper();
		}

		public static int ConvertBack(string s)
		{
			Console.WriteLine("ConvertBack");

			return int.Parse(s);
		}
	}



	public class myList
	{
		private int[] data = { 1, 2, 3, 4, 5 };

		public IEnumerator GetEnumerator()
		{
			int i = 0;
			while (true)
			{
				yield return i;
				i++;
				System.Threading.Thread.Sleep(1000);
			}
		}
	}

	class TestClass
	{
		public string name;
		public string pro;
		public string str;
	}

	class TestAnimal
	{
		public string name;
		public int age;
		public int movespeed;
		public int jump;
		public int sound;

		public TestAnimal(string name, int age, int movespeed, int jump, int sound)
		{
			this.name = name;
			this.age = age;
			this.movespeed = movespeed;
			this.jump = jump;
			this.sound = sound;
		}

		public static TestAnimal[] GetSample()
		{
			TestAnimal[] sample = new TestAnimal[5];
			sample[0] = new TestAnimal("hi", 1, 2, 3, 4);
			sample[1] = new TestAnimal("22i", 222, 33, 44, 554);
			sample[2] = new TestAnimal("3hi", 222, 33, 44, 4);
			sample[3] = new TestAnimal("4hi", 222, 33, 3, 4);
			sample[4] = new TestAnimal("5hi", 222, 2, 3, 4);

			return sample;	
		}

			
		public override string ToString()
		{
			return string.Format("name : {0}, age : {1}, movespeed : {2}, jump : {3}, sound : {4}", this.name, this.age, this.movespeed, this.jump, this.sound);
		}

	}

	class TestMain
	{

		private T[] ConverList<T>(string[] strArray)
		{
			T[] resultArray = new T[strArray.Length];

			for (int i = 0; i < strArray.Length; i++)
			{
			//	resultArray[i] = (T)Convert.ChangeType(strArray[i], typeof(T));

			}
			return resultArray;
		}



		static public string ConvertInputToString(params object[] inputParameters)
		{
			StringBuilder sb = new StringBuilder();
			string paramName;
			foreach (var data in inputParameters)
			{
				foreach (FieldInfo data2 in data.GetType().GetFields())
				{
					paramName = data2.Name;
					sb.AppendFormat("{0} : {1} / ", paramName, data2.GetValue(data));
				}
			}

			return sb.ToString();
		}


		static public bool AdminActionLog(string procedureName, params object[] input)
		{

			string temp = ConvertInputToString(input);

			return true;
		}

		public class testClass3
		{
			public int num;
			public string name;
		}

		public static void Main(string[] args)
		{

			var classtest = new testClass3()
			{
				num = 1,
				name = "aa"
			};
			var classtest2 = new testClass3()
			{
				num = 2,
				name = "bb"
			};



			
			int durr = (int)((1211 /5000) * 100);

			int kksdf = (int)(1211f / 2000 * 100);
			int sdfsdf = 1;



			for (int j = 2; j < 100; j++)
			{
				Console.WriteLine((j+(j-1))/2+1);
			}


			TestAnimal[] animal = TestAnimal.GetSample();
			TestAnimal saaa = new TestAnimal("aa", 11, 11, 11, 11);

			int count = 0;
			Console.WriteLine();

			foreach(var item in animal)
			{
				Console.WriteLine("==============================");

				Type sampType = item.GetType();
				var member = sampType.GetMembers();
				var field = sampType.GetFields();
				var method = sampType.GetMethods();
				Console.WriteLine(item.ToString());

				foreach(var data in sampType.GetMembers())
				{
					Console.WriteLine(count + ". GetMembers : " + data.Name);
				}
				Console.WriteLine();
				foreach (var data in sampType.GetFields())
				{
					Console.WriteLine(count + ". GetFields : " + data.Name);
				}
				Console.WriteLine();
				foreach (var data in sampType.GetMethods())
				{
					Console.WriteLine(count + ". GetMethods : " + data.Name);
				}
				Console.WriteLine();
				count++;
			}

			SingleTon tes = SingleTon.getInstance();
			tes.ToString("aaaaa");

			TestClass testcl = new TestClass();
			testcl.name = "1";
			testcl.pro = "2";
			testcl.str = "33";

			string tempcl = "insert string";
			Object tempppp = tempcl;

			bool tete = AdminActionLog("sdfsdf", tempppp);

			;


			DateTime resetTime = DateTime.UtcNow.AddMinutes(0).Date.AddMinutes(-540);




			int testNum = 540;

			DateTime time01 = DateTime.UtcNow.AddMinutes(testNum);
			DateTime time02 = time01.Date.AddMinutes(-testNum);
	//		DateTime resetTime = DateTime.UtcNow.AddMinutes(testNum).Date.AddMinutes(-testNum);


			StringBuilder sb = new StringBuilder();
			string billing_tran_no = "aa,dd,ff,aa,zz";

			string[] arr_billing_tran_no = billing_tran_no.Split(new char[] { ',' });

			TestMain tempte = new TestMain();

			var tetetetete = tempte.ConverList<long>(arr_billing_tran_no);
			




			var list = new myList();

			foreach(var item in list)
			{
				Console.WriteLine(item);
			}

			IEnumerator it = list.GetEnumerator();

			Timer ss = new Timer();

			

			it.MoveNext();
			Console.WriteLine(it.Current);
			it.MoveNext();
			Console.WriteLine(it.Current);

			var tempp = list.GetEnumerator();

			tempp.MoveNext();
			Console.WriteLine(tempp.Current);
			tempp.MoveNext();
			Console.WriteLine(tempp.Current);

			var teaa = GetNumber();

			foreach(var item in Test1())
			{
				Console.WriteLine(item);
			}

			foreach(var item in Test2())
			{
				Console.WriteLine(item);
			}
		/*	foreach (int num in GetNumber())
			{
				Console.WriteLine(num);
			}*/

			Border b = Border.Top | Border.Bottom;

			Console.WriteLine(b.ToString());

			if ((b & Border.Top) != 0)
			{
				if(HasFlag(b, Border.Bottom))
				{
					Console.WriteLine(b.ToString());
				}
			}


			string testtt = b.ToString();

			int testttt = (int)b;






			string str = MyUtility.Convert(123);
			int i = MyUtility.ConvertBack(str);
			Console.WriteLine(i);

			Egg2 eg = new Egg2("Fire", 100, false);
			Egg2 eg2 = new Egg2("Ice", 100, true);

			Egg egg = new Egg();
			eg2 = egg as Egg2;
			egg = eg as Egg;

			Console.WriteLine("{0}{1}", eg2, egg);
			

			bool te = egg is Egg;
			bool tee = eg2 is Egg2;
			bool tetete = egg is Egg2;
			bool tetetete = eg2 is Egg;

			Console.WriteLine("{0} / {1} / {2} / {3}", te, tee, tetete, tetetete);

			Console.WriteLine(eg.ToInfo());
			Console.WriteLine(eg.Run());

			//Console.WriteLine(eg2.ToInfo());
		//	Console.WriteLine(eg2.Run());
			eg.Test();
		//	eg2.Test();

		}

		static IEnumerable<int> GetNumber()
		{
			yield return 10;
			yield return 120;
			yield return 130;
			yield return 140;
		}


		public static IEnumerable Test1()
		{
			yield return "q1";
			yield return "q2";
			yield return "q31";
			yield return "q41";
		}


		


		public static IEnumerable Test2()
		{
			for (int i = 0; i < 20; i++) 
			{
				yield return i;
			}
			yield return "sss";
			yield return "aa";
			yield return "dd";
			yield return "ff";
			
		}

		IEnumerator CorTest()
		{

			yield return "dd";
			
		}

		static bool HasFlag(Border f1, Border f2)
		{
			return ((f1 & f2) != 0);
		}

	}


}
