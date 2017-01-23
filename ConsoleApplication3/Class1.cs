using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

using System.IO;

namespace ConsoleApplication3
{
    class Class1
    {
		static void Main8(string[] args) 
        {
			int k = 2;
			int k2 = 4;

         /*   int count = 0;
            bool ok = true;
            XmlDocument xmlDoc = new XmlDocument();

            xmlDoc.Load("/LocaleString2.xml");


            XmlElement root = xmlDoc.DocumentElement;

            XmlNodeList elemList = root.ChildNodes;


            List<String> OverData = new List<String>();

            foreach (XmlNode item in elemList)
            {
                count = 0;
                ok = true;
                string temp = item.Attributes["Index"].InnerText;
                foreach (XmlNode item2 in elemList)
                {
                    string temp2 =  item2.Attributes["Index"].InnerText;
                    if (temp.Equals(temp2))
                    {
                        count++;
                        if (count > 1)
                        {
                            foreach (string temp3 in OverData)
                            {
                                if(temp3.Equals(temp2)){
                                    ok = false;
                                }
                            }
                            if (ok)
                            {
                                OverData.Add(temp2);
                            }
                        }
                    }
                }
            }


            List<String> OverData2 = new List<String>();
            OverData2 = OverData;

            for (int i = 0; i < elemList.Count; i++)
            {

                //Console.WriteLine(elemList[i].InnerXml);
                //if ( i > 10 ) break;
            }

            return;

            //foreach (XmlNode node in xmlDoc["NODE"].ChildNodes)

            try
            {
                using (StreamWriter sw = new StreamWriter(new FileStream("output.text", FileMode.OpenOrCreate)))
                {

                    foreach (XmlNode node in elemList)
                    {

                        try
                        {
                            if (node.Attributes["Index"].Value != null)
                            {
                                if (node.Attributes["Index"].Value.Trim() != "")
                                    Console.WriteLine(node.Attributes["Index"].Value);

                                if (node.Attributes["Index"].Value.Trim() != "")
                                    sw.WriteLine("'" + node.Attributes["Index"].Value + "',");
                            }
                        }
                        catch
                        {

                        }
                    }
                }
            }
            catch (Exception e)
            {

            }*/

        }
    }
}