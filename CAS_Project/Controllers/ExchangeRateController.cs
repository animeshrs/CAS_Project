using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace CAS_Project.Controllers
{
    public class ExchangeRateController : ApiController
    {
        // GET: ExchangeRate
        public HttpResponseMessage Get(string amountString,string fromCurrency,string toCurrency)
        {
            try
            {
                int amount = Convert.ToInt32(amountString);
                string apiURL = String.Format("https://www.google.com/finance/converter?a={0}&from={1}&to={2}&meta={3}", amount, fromCurrency, toCurrency, Guid.NewGuid().ToString());

                var webRequest = WebRequest.Create(apiURL);

                var streamReader = new StreamReader(webRequest.GetResponse().GetResponseStream(), System.Text.Encoding.ASCII);

                var Result = Regex.Matches(streamReader.ReadToEnd(), "<span class=\"?bld\"?>([^<]+)</span>")[0].Groups[1].Value;


                return Request.CreateResponse(HttpStatusCode.OK, Result);
                
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

    }
}