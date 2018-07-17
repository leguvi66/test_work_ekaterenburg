 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TweetSharp;
using System.IO;
using Newtonsoft;
namespace test_work_twitter
{
     public static class SendTwitte
    {

         private static TwitterService twitterService = new TwitterService("7dhZVbG8t4ezMHos2249U56Dc",
                 "vN1nn4dg1DFVAogvRfzNqbWazSOutOgcwqFhzAw7DJg2iGlpzJ", "1018623332013477888-vEYk2DAxXnSORkQ1lEiYjHICGIZbqg", "DSBvKskgAB1MeiMlaD9yttO4XKIDA5NFtmNneM4SmcGTt");
         public static void Send(string text)
         {
             twitterService.SendTweet(new SendTweetOptions() {Status=text });
         }
        public static List<Twittes> Parce(string inputUser)
        {
            List<Twittes> ListTwitte = new List<Twittes>();
            var twittes = twitterService.ListTweetsOnUserTimeline(new ListTweetsOnUserTimelineOptions() { ScreenName = inputUser, Count = 5 });
            foreach (var twite in twittes)
            {
                string statics = Statistics.SymbolsCount(twite.Text);
                var twitte = new Twittes() { NameTwitte = twite.User.Name, Date = twite.CreatedDate.ToString(), UserId = twite.User.ScreenName, StatisticTwitte = statics };
                ListTwitte.Add(twitte);
            }
            return ListTwitte;
        }
    
    }
}
