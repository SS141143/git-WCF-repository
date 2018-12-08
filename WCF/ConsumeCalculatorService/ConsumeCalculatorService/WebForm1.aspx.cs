using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConsumeCalculatorService
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            ServiceReference1.CalculatorServiceClient client = new ServiceReference1.CalculatorServiceClient();
            lblResult.Text = Convert.ToString(client.AdditionOperation(Convert.ToDouble(TxtNumer1.Text), Convert.ToDouble(TxtNumber2.Text)));
        }

        protected void BtnSub_Click(object sender, EventArgs e)
        {
            ServiceReference1.CalculatorServiceClient client = new ServiceReference1.CalculatorServiceClient();
            lblResult.Text = Convert.ToString(client.SubractionOperation(Convert.ToDouble(TxtNumer1.Text), Convert.ToDouble(TxtNumber2.Text)));
        }
    }
}