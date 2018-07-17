using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace test_work_twitter
{
   public static class Account
    {
       public static string login { get; set; }
       public static List<Twittes> ListTwittes = new List<Twittes>();

       public static void ParceTwittes()
       {
           string url = "https://twitter.com/" + login;
           if ((IsPageExists(url) == true)&&(login!=""))
           {
               try
               {
                   ListTwittes = SendTwitte.Parce(login);
               }
               catch { Console.WriteLine("Проверить правильность написания логина!"); }
           }
           else
           {
               Console.WriteLine("Такого аккаунта не существует!");
           }
       }

      private static bool IsPageExists(string url)
       {
           try
           {
               WebClient client = new WebClient();
               client.DownloadString(url);
           }
           catch (WebException ex)
           {
               HttpWebResponse response = ex.Response != null ? ex.Response as HttpWebResponse : null;
               if (response != null && response.StatusCode == HttpStatusCode.NotFound)
               {
                   return false;
               }
           }

           return true;
       }

    }
}
