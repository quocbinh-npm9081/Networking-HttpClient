using System;
using System.Net;
using System.Net.NetworkInformation;
namespace NetWorking{
    class Program
    {
        static void Main(string[] args){
            string url = "https://xuanthulab.net/lap-trinh/csharp/?page=3#acff";
            var uri = new Uri(url);
            Console.WriteLine(uri.Port);
            var uriType = uri.GetType();
            // uriType.GetProperties().ToList().ForEach(property => {
            //     Console.WriteLine($"{property.Name} - {property.GetValue(uri)}");
            // });
            Console.WriteLine(uri.Port);
            

            //Host name
            var hostName = Dns.GetHostName();
            Console.WriteLine(hostName); //DESKTOP-JNTN2DM host hien tai

            //ping remote
            var ping = new Ping();
            var pingReply = ping.Send("google.com.vn"); /// ping den dns google
            Console.WriteLine("+++ PING MAY GOOGLE DNS");
            Console.WriteLine(pingReply.Status);
            if (pingReply.Status == IPStatus.Success)
            {
                Console.WriteLine(pingReply.RoundtripTime);
                Console.WriteLine(pingReply.Address);
            }
   
        }
    }
}