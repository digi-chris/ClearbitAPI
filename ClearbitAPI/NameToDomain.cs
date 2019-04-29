using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace BarnardTechnology.ClearbitAPI
{
    public class NameToDomain
    {
        public static List<CompanyInfo> GetCompanies(string name)
        {
            HttpWebRequest wReq = (HttpWebRequest)HttpWebRequest.Create("https://company.clearbit.com/v1/domains/find?name=" + Uri.EscapeUriString(name));
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
