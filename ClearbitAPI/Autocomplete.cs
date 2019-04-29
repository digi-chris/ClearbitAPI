using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

using Newtonsoft.Json;

namespace BarnardTechnology.ClearbitAPI
{
    public class Autocomplete
    {
        public static List<CompanyInfo> GetCompanies(string name)
        {
            HttpWebRequest wReq = (HttpWebRequest)HttpWebRequest.Create("https://autocomplete.clearbit.com/v1/companies/suggest?query=" + Uri.EscapeUriString(name));
            using (HttpWebResponse wResp = (HttpWebResponse)wReq.GetResponse())
            {
                using (StreamReader sRead = new StreamReader(wResp.GetResponseStream()))
                {
                    List<CompanyInfo> companies = JsonConvert.DeserializeObject<List<CompanyInfo>>(sRead.ReadToEnd());
                    return companies;
                }
            }
        }
    }
}
