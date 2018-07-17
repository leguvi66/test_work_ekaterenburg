using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;


namespace test_work_twitter
{
    public static class Json_object
    {
         public static string JsonTwittes(Twittes twitte )
       {
           return JsonConvert.SerializeObject(twitte); 
       }

           
        
    }
}
