using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        List<order> dorders = new List<order>();
        List<customer> dcustomers = new List<customer>();
        String login;

        protected void Page_Load(object sender, EventArgs e)
        {
            WebForm1 wbfrm1 = new WebForm1();
            //login = wbfrm1.getLogin();
            login = Request.QueryString["Name"];
            //Response.Write(login);
            populateTable();
            showDetails();
        }

        public void populateTable()
        {
            using (CustomersEntities1 myEntities = new CustomersEntities1())
            {
                var orders1 = from order in myEntities.orders where order.Name == login select order;
                dorders = orders1.ToList();
            }
            rptOrders.DataSource = dorders;
            rptOrders.DataBind();
        }

        public void showDetails()
        {
            using (CustomersEntities1 myEntities = new CustomersEntities1())
            {
                var customers1 = from customer in myEntities.customers where customer.Name == login select customer;
                dcustomers = customers1.ToList();
            }
            rptDetails.DataSource = dcustomers;
            rptDetails.DataBind();
        }

        protected void AddOrder(object sender, EventArgs e)
        {
            
        }

        protected void btnAddOrder_Click(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
            Label lbldeleteid = (Label)row.FindControl("lblID");
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("delete FROM detail where id='" + Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString()) + "'", conn);
            //cmd.ExecuteNonQuery();
            //conn.Close();
            //gvbind();
            showDetails();

        }
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            showDetails();
            //gvbind();
        }
        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int userid = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
            Label lblID = (Label)row.FindControl("lblID");
            //TextBox txtname=(TextBox)gr.cell[].control[];
            TextBox textName = (TextBox)row.Cells[0].Controls[0];
            TextBox textadd = (TextBox)row.Cells[1].Controls[0];
            TextBox textc = (TextBox)row.Cells[2].Controls[0];
            //TextBox textadd = (TextBox)row.FindControl("txtadd");
            //TextBox textc = (TextBox)row.FindControl("txtc");
            GridView1.EditIndex = -1;
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("SELECT * FROM detail", conn);
            //SqlCommand cmd = new SqlCommand("update detail set name='" + textName.Text + "',address='" + textadd.Text + "',country='" + textc.Text + "'where id='" + userid + "'", conn);
            //cmd.ExecuteNonQuery();
            //conn.Close();
            //gvbind();
            showDetails();
            //GridView1.DataBind();
        }
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            showDetails();
            //gvbind();
        }
        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            showDetails();
            //gvbind();
        }
    }

}
}