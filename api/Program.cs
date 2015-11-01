using System;
using Microsoft.Owin.Hosting;

namespace api
{
	class MainClass
	{
		public static void Main (string[] args)
		{


			using (WebApp.Start<Startup> ("http://localhost:5000")) {
				
				Console.WriteLine ("Server started");
				Console.ReadLine ();
			}
		}
	}
}
