using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        List<login> dlogins = new List<login>();
        //String loginacc;

        //public String getLogin()
        //{
        //    return loginacc;
        //}
        
        protected void Page_Load(object sender, EventArgs e)
        {
            pulldata();
        }

        public void pulldata()
        {
            using (CustomersEntities1 myEntities = new CustomersEntities1())
            {
                var logins1 = from Login in myEntities.logins select Login;
                dlogins = logins1.ToList();
            }
        }

        protected void Login_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            foreach (login i in dlogins)
            {
                if (Login.Text == i.Login1 && Password.Text == i.Password)
                {
                    Result.Text = "Login success: " + i.Login1;
                    //loginacc = i.Name;
                    Response.AddHeader("REFRESH", "3;URL=WebForm2.aspx?Name=" + i.Name);
                    break;
                }
                if (i.Equals(dlogins.Last()) && Login.Text != i.Login1 && Password.Text != i.Password)
                {
                    Result.Text = "Login failed!";
                }
            }
        }
    }
}