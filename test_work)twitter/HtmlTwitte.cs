using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace test_work_twitter
{
    public static class HtmlTwitte
    {

        public static List<Twittes> parce(string login)
        {
            string url = @"https://twitter.com/" + login;
            List<Twittes> ListTwittes = new List<Twittes>();
            List<string> Mass = new List<string>();
            string str = getResponse(@"http://www.cyberforum.ru/");
            Console.WriteLine(str);
            return ListTwittes;
        }
        private static string getResponse(string uri)
        {
            StringBuilder sb = new StringBuilder();
            byte[] buf = new byte[8192];
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream resStream = response.GetResponseStream();
            int count = 0;
            do
            {
                count = resStream.Read(buf, 0, buf.Length);
                if (count != 0)
                {
                    sb.Append(Encoding.Default.GetString(buf, 0, count));
                }
            }
            while (count > 0);
            return sb.ToString();
        }
    }
}
