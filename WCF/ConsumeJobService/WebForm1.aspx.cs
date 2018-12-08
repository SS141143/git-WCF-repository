using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConsumeJobService
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnHttp_Click(object sender, EventArgs e)
        {
            ServiceReference1.JobServiceClient client = new ServiceReference1.JobServiceClient("BasicHttpBinding_IJobService");
            GridView1.DataSource = client.OpeningJobs();
            GridView1.DataBind();
        }

        protected void BtnTcp_Click(object sender, EventArgs e)
        {
            ServiceReference1.JobServiceClient client = new ServiceReference1.JobServiceClient("BasicHttpBinding_IJobService");
            GridView1.DataSource = client.OpeningJobsByRole(TxtRole.Text);
            GridView1.DataBind();
        }
    }
}