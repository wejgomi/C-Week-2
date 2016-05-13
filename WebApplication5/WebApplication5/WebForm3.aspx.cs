using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "The card is " + ((Checkno(Convert.ToInt64(TextBox1.Text)) == 0) ? "valid" : "invalid");
        }

        public static int Checkno(long cardno)
        {
             String cardstring = Convert.ToString(cardno);
             int j = 0;
             for (int i = 14; i >= 0; i-=2)
             {
                j += (Convert.ToString(Convert.ToInt32(cardstring[i]) * 2).Length > 1) ? Convert.ToString(Convert.ToInt32(cardstring[i]) * 2)[0] + Convert.ToString(Convert.ToInt32(cardstring[i]) * 2)[1] + Convert.ToInt32(cardstring[i + 1]) : (Convert.ToInt32(cardstring[i]) * 2) + Convert.ToInt32(cardstring[i + 1]);
             }
             return (j % 10);
         }
    }
}