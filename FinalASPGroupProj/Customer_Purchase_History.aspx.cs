//created by Mike Rabtich Jan 2017
//Page that displays the purchase history of a customer

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Drawing;
using System.Globalization;
using FinalASPGroupProj.AppCode;

namespace FinalASPGroupProj
{
    public partial class Customer_Purchase_History : System.Web.UI.Page
    {
        private BindingSource bind1 = new BindingSource();

        protected void Page_Load(object sender, EventArgs e)
        {
            txtCustIdGridView.Text = Convert.ToString(Application["CustomerID"]);
            btnCustHist_Click();
        }

        protected void btnCustHist_Click()
        {
            //int I = Convert.ToInt32(txtCustIdGridView.Text);


            // Justins Code
            int I = (int)Application["CustomerID"];
            List<BookingDetails> II = new List<BookingDetails>();
            II = BookingDetailsDB.bookingDetails((int)I);

            List<money> III = new List<money>();

            III = BookingDetailsDB.getPrice((int) I);
            decimal price = 0;
          
            foreach (money a in III)
            {
                price = price + a.vacationCost;

               
            }
            lblTotal.Text = price.ToString("C");
            GridView1.DataSource = II;
            GridView1.DataBind();


        }

        protected void txtCustIdGridView_TextChanged(object sender, EventArgs e)
        {

        }
    }
}