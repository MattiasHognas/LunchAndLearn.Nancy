using System;
using Nancy.Hosting.Self;

namespace Nancy.UI.Web
{
    class Program
    {
        static void Main(string[] args)
        {
            var uri =
                new Uri("http://localhost:1234");

            using (var host = new NancyHost(uri))
            {
                host.Start();

                Console.WriteLine("Your application is running on " + uri);
                Console.WriteLine("Press any [Enter] to close the host.");
                Console.ReadLine();
            }
        }
    }
}
