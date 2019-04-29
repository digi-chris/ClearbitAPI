using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;

namespace BarnardTechnology.ClearbitAPI
{
    public class Logo
    {
        public static Bitmap GetCompanyLogo(string domain)
        {
            HttpWebRequest wReq = (HttpWebRequest)HttpWebRequest.Create("http://logo.clearbit.com/" + domain);
            using (HttpWebResponse wResp = (HttpWebResponse)wReq.GetResponse())
            {
                return new Bitmap(wResp.GetResponseStream());
            }
        }
    }
}
