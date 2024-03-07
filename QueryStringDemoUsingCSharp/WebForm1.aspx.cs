using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QueryStringDemoCSharp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm2.aspx?firstname=" + TextBox1.Text + "&lastname=" + TextBox2.Text + "&Age=" + TextBox3.Text);

        }
    }
}