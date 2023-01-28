using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Text;
namespace NetWorking{
    class Program
    {
        static void ShowHeader(HttpResponseHeaders headers){
          foreach (var header in headers)
          {
            Console.WriteLine($"{header.Key} - {header.Value}");
          }
        }

        public static async Task<string> GetWebContent(string url){
            using var httpClient = new HttpClient();
            try
            {
                HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(url);               

                ShowHeader(httpResponseMessage.Headers);
                string responseHtml = await httpResponseMessage.Content.ReadAsStringAsync();

                return "adasd";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return "Loi";
            }
       
        }
        static void Main(string[] args){
            var url = "https://xuanthulab.net/networking-su-dung-httpclient-trong-c-tao-cac-truy-van-http.html";
            Task<string> respone  =  GetWebContent(url);
            respone.Wait();
            var html = respone.Result;
            Console.WriteLine("Get respone ");
            Console.WriteLine(html);
   
        }
    }
}