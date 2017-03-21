using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Services;
using System.Xml;

namespace CAS_Client
{
    
    /// Summary description for ExchangeRateService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class ExchangeRateService : System.Web.Services.WebService
    {
        [WebMethod]
        public string ExchangeRate(string fromCurrency, string toCurrency, decimal amount)
        {
            string apiURL = String.Format("https://www.google.com/finance/converter?a={0}&from={1}&to={2}&meta={3}", amount, fromCurrency, toCurrency, Guid.NewGuid().ToString());
            
            var webRequest = WebRequest.Create(apiURL);
            
            var streamReader = new StreamReader(webRequest.GetResponse().GetResponseStream(), System.Text.Encoding.ASCII);
            
            var Result = Regex.Matches(streamReader.ReadToEnd(), "<span class=\"?bld\"?>([^<]+)</span>")[0].Groups[1].Value;
            
            return Result;
        }
    }
}
