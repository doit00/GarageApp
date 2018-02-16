using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GarageApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClientHttp();
            WebRequestHtp();

        }

        private static void WebRequestHtp()
        {
            var req = WebRequest.Create("http://google.pl") as HttpWebRequest;
            req.Method = "GET";
            var resp = req.GetResponse() as HttpWebResponse;
            Console.WriteLine(resp.StatusCode);
            var rs = resp.GetResponseStream();
            rs.CopyTo(new FileStream("google.html", FileMode.CreateNew));
        }

        private static void WebClientHttp()
        {
            WebClient cli = new WebClient();
            var page = cli.DownloadString("http://google.pl");
            File.AppendAllText("out.html", page);
            cli.Dispose();
        }
    }

}
