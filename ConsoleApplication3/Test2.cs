using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace ConsoleApplication3
{
	class Test2
	{
		public static void SendMessage()
		{
			string uri = "http://someRquest";
			WebClient webClient = new WebClient();
			Stream stream = webClient.OpenRead(uri);
			string responseJSON = new StreamReader(stream).ReadToEnd();
		}
		
	}
}
