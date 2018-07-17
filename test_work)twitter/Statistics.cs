using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test_work_twitter
{
    public static class Statistics
    {
        public static string SymbolsCount(string str)
        {
            string result = "";
            string s = str;
            var x = from c in s
                    group c by c into g
                    let count = g.Count()
                    orderby g.Key ascending
                    select new
                    {
                        Value = g.Key,
                        Count = count,

                    };
            int i = 0;
            foreach (var count in x)
            {

                double a = Convert.ToDouble(count.Count) / s.Length;
                a = Math.Round(a, 5);
                double b = Math.Round(-1 * a * Math.Log(a, 2), 5);
                if (i == 0)
                {
                    result += count.Value + ":'" + count.Count + "'";
                }
                else
                {
                    result += ","+count.Value + ":'" + a + "'";
                }
                i++;

            }
            return result;
        }

    }
}
