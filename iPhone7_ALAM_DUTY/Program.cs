using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace iPhone7_ALAM_DUTY
{
    class Program
    {
        static void Main(string[] args)
        {
            GetDataFromURL();
        }
        public static void GetDataFromURL()
        {
            using (WebClient client = new WebClient())
            {
                string htmlCode = client.DownloadString("http://dutyfree.alm.co.il/dutyfree/Category.aspx?cid=1&vmenu=5");
                var IndexofIphone7 = htmlCode.IndexOf("iPhone 7 32GB");
                var StringContainsOutOfStock = htmlCode.Substring(IndexofIphone7, 248);
                if (StringContainsOutOfStock.Contains("outOfStock"))
                    Email.sendEmail();
                else
                    Email.sendEmail();

            }
        }
    }
}
