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
        public static async Task<string> GetWebContent(string url){
            var httpClient = new HttpClient();
            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(url);
            string responseHtml = await httpResponseMessage.Content.ReadAsStringAsync();
            return responseHtml;
        }
        static void Main(string[] args){
            var url = "https://xuanthulab.net/networking-su-dung-httpclient-trong-c-tao-cac-truy-van-http.html";
            Task<string> result  = GetWebContent(url);
            Console.WriteLine("Get respone ");
            Console.WriteLine(result);
   
        }
    }
}