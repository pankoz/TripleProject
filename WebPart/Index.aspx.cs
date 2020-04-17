using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPart
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        LibraryPart.Class1 selector = new LibraryPart.Class1();

        protected void Page_Load(object sender, EventArgs e)
        {
            txbx_Output.Text = selector.TestMethod();
            txbx_Output.Text += "FROM SECOND";
        }

        protected void btn_CallMethodDll_Click(object sender, EventArgs e)
        {
            txbx_Output.Text = selector.TestMethod();
            txbx_Output.Text += "FROM SECOND";
        }
    }
}