using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CAS_Client
{
    public partial class ExchangeRate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                lblResult.ForeColor = System.Drawing.Color.DarkBlue;
                ExchangeRateServiceReference.ExchangeRateServiceSoapClient client = new ExchangeRateServiceReference.ExchangeRateServiceSoapClient();
                lblResult.Text = client.ExchangeRate(txtFromCurrency.Text, txtToCurrency.Text, Convert.ToDecimal(txtAmount.Text));
            }
            catch(Exception ex)
            {
                lblResult.ForeColor = System.Drawing.Color.Red;
                lblResult.Text = ex.Message;
            }
        }
    }
}