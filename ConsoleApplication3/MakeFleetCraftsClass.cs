using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{


    /*
     * use arkgame;
SELECT craft_no, flyweight, craft_enchant_level, durability
		FROM FLEET_CRAFT
		WHERE craft_no IN 
		(SELECT craft_no 
			FROM FLEET_GROUP
			WHERE user_no = 787 ) AND 
		user_no = 787 AND 
		repair_second = 0 AND 
		durability > 0;	
     * */



    class MakeFleetCraftsClass
    {
        public void MakeFleetCrafts()
        {
            int count = 300  ;

            long craft_no = count;
            long user_no = count/12+1;
            long fleet_no = count/3+1;
            int flyweight =0;
            short craft_enchant_level=0;
            int durability=0;
            int repair_second = 0;

            char comma = ',';
            string insertData;

            switch(count%7){
                case 0: flyweight = 1100; durability = 0; break;
                case 1: flyweight = 1001100; durability = 0; break;
                case 2: flyweight = 3605; durability = 32604; craft_enchant_level = 5; break;
                case 3: flyweight = 3405; durability = 45114; craft_enchant_level = 5; break;
                case 4: flyweight = 4105; durability = 101448; craft_enchant_level = 5; break;
                case 5: flyweight = 3505; durability = 19586; craft_enchant_level = 5; break;
                case 6: flyweight = 3504; durability = 16990; craft_enchant_level = 5; break;
            }



       /*     INSERT INTO `plunder_user` (user_no, active_user, league, power_level)
        VALUE (i, 1, i%8, i%21);
        SET i = i + 1;*/
  /*      
            System.IO.File.WriteAllLines(@"D:\test\test.txt", lines);
                       
            string text = "A class is the most powerful data type in C#. Like a structure, " +
                           "a class defines the data and behavior of the data type. ";

            System.IO.File.WriteAllText(@"D:\test\test.txt", text);*/
  
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"D:/fleetCraft.txt"))
            {
                while (count < 2000000)
                {
                    craft_no = count;
                    user_no = count/12+1;
                    fleet_no = count/3+1;
                    switch(count%7){
                        case 0: flyweight = 1100; durability = 0; craft_enchant_level = 0; break;
                        case 1: flyweight = 1001100; durability = 0; craft_enchant_level = 0; break;
                        case 2: flyweight = 3605; durability = 32604; craft_enchant_level = 5; break;
                        case 3: flyweight = 3405; durability = 45114; craft_enchant_level = 5; break;
                        case 4: flyweight = 4105; durability = 101448; craft_enchant_level = 5; break;
                        case 5: flyweight = 3505; durability = 19586; craft_enchant_level = 5; break;
                        case 6: flyweight = 3504; durability = 16990; craft_enchant_level = 5; break;
                    }
                    insertData = craft_no.ToString() + comma + user_no + comma + fleet_no + comma + flyweight + comma 
                        + craft_enchant_level + comma + durability + comma + repair_second + comma ;
                    file.WriteLine(insertData);
                    count++;
                }
               
            }

          /*  using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"D:\test\test2.txt", true))
            {
                file.WriteLine("Fourth line");
            }*/
        }
    }


    
}
