using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{

	class MakePlunderUserClass
    {
		public static void MakePlunderUser()
        {
            int count = 0;
			long user_no = 0;
            int league = 0;
            int power_level = 0;
			int random_key = 0;
           // char comma = ',';

            //string insertData;

			StringBuilder sb = new StringBuilder();


       /*     INSERT INTO `plunder_user` (user_no, active_user, league, power_level)
        VALUE (i, 1, i%8, i%21);
        SET i = i + 1;*/
  /*      
            System.IO.File.WriteAllLines(@"D:\test\test.txt", lines);
                       
            string text = "A class is the most powerful data type in C#. Like a structure, " +
                           "a class defines the data and behavior of the data type. ";

            System.IO.File.WriteAllText(@"D:\test\test.txt", text);*/
  
			//	 user_no,	 active_user,	 exclude,	league,	 power_level,	 random_key

			string dirPath = "D:/Plunder_user";
			string dirpathback = ".txt";
			int cnt = 0;
			int startcount = 100000000;
			
			for (int i = 0; i < 30; i++)
			{
				int endcount = startcount + 10000000;
				StringBuilder sbdir = new StringBuilder();
				sbdir.AppendFormat("{0}{1}{2}", dirPath, cnt, dirpathback);

				using (System.IO.StreamWriter file = new System.IO.StreamWriter(sbdir.ToString()))
				{
		
					Random r = new Random();
					while (startcount < endcount)
					{
						sb.Remove(0, sb.Length);
						user_no = startcount;
						league = startcount % 9;
						power_level = startcount % 12;
						random_key = r.Next(0, 100000000);
						sb.AppendFormat("{0},{1},{2},{3}", user_no, random_key, league, power_level);
						//insertData = user_no.ToString() + comma + active_user + comma + exclude + comma + league + comma + power_level + comma + random_key + comma;
						file.WriteLine(sb);
						startcount++;
					}

				}

				startcount = endcount;
				cnt++;
			}

			

         /*   using (System.IO.StreamWriter file =
                new System.IO.StreamWriter("D:/Plunder_user9.txt"))
            {
				Random r = new Random();
                while (count < 11)
                {
					sb.Remove(0, sb.Length);
					user_no = count;
					league = count % 9;
					power_level = count % 12;
					random_key = r.Next(0,100000000);
					sb.AppendFormat("{0},{1},{2},{3}", user_no, random_key, league, power_level);
					//insertData = user_no.ToString() + comma + active_user + comma + exclude + comma + league + comma + power_level + comma + random_key + comma;
					file.WriteLine(sb);
                    count++;
                }
               
            }*/

          /*  using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"D:\test\test2.txt", true))
            {
                file.WriteLine("Fourth line");
            }*/
        }
    }


    
}
