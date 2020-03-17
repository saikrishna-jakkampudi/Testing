using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Testing
{
    public partial class Dtest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            BLclass BL = new BLclass();
            try
            {
                txtResult.Text = (BL.Divide(int.Parse(txtNumerator.Text), int.Parse(txtDenominator.Text))).ToString();
            }

            catch (DivideByZeroException E)
            {
                Response.Write(E.Message);
            }
        }
    }
}