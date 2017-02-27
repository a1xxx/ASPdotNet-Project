using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalASPGroupProj
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           SetLink();
        }

        public void SetLink()
        {
            //hyperlink1.Visible = false;


            if (Application["CustomerID"] == null)
            {
               hyperlink2.Visible = true;
               hyperlink3.Visible = true;
                hyperlink1.Visible = false;
                hyperlink4.Visible = false;
            }
            else 
            {
                hyperlink1.Visible = true;
                hyperlink4.Visible = true;
                hyperlink2.Visible = false;
                hyperlink3.Visible = false;
            }
        }
    }
}