using System;
using Microsoft.Owin.Hosting;
using System.Threading;

namespace api
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			using (WebApp.Start<Startup> ("http://localhost:5000")) {
				Console.WriteLine ("Server started");
				while (true) {
					Thread.Sleep (200);
				}
			}
		}
	}
}
