using System;
using System.Net;
using System.IO;
using System.Text;

namespace _030202
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("http://www.philpapers.org/");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader stream = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
            stream.Close();
            Console.WriteLine("Заголовки: ");
            foreach(string header in response.Headers)
            {
                Console.WriteLine("{0}:{1}", header, response.Headers[header]);
            }


        }
    }
}