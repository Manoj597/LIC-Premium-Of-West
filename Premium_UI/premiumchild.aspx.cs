using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;

public partial class premiumchild : System.Web.UI.Page
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [System.Web.Script.Services.ScriptService]
    [WebMethod()]
   
    protected void Page_Load(object sender, EventArgs e)
    {
        //int age = Convert.ToInt32(txtAge.Text);

        ////DropDownList drpdwnTerm=new DropDownList();
        ////  drpdwnTerm.DataTextField="5 Years";
        ////  drpdwnTerm.DataTextField="5 Years";
        ////  drpdwnTerm.DataTextField="5 Years";
        ////  drpdwnTerm.DataTextField="5 Years";
        ////  drpdwnTerm.DataTextField="5 Years";



        //if (age > 65)
        //{
        //    DropDownList drpdwnTerm = new DropDownList();
        //    drpdwnTerm.DataTextField = "5 Years";
        //    drpdwnTerm.DataTextField = "10 Years";
        //    drpdwnTerm.DataTextField = "15 Years";
        //    drpdwnTerm.DataTextField = "20 Years";
        //    drpdwnTerm.DataTextField = "25 Years";
        //}
        //if (age > 69 && age < 75)
        //{
        //    DropDownList drpdwnTerm = new DropDownList();
        //    drpdwnTerm.DataTextField = "5 Years";
        //    drpdwnTerm.DataTextField = "10 Years";
        //    drpdwnTerm.DataTextField = "15 Years";
        //}

        


    }



   
    protected void btnSveExt_Click(object sender, EventArgs e)
    {
        Session["name"] = txtName.Text;
        Session["policytype"] = drpdwnType.SelectedItem;
        Session["policyterm"] = drpdwnTerm.SelectedItem;
        Session["age"] = txtAge.Text;
        Session["insuredAmt"] = txtAmt.Text;
        Response.Redirect(@"~/PremiumCalprint.aspx");
    }


    protected void btnSveQte_Click(object sender, EventArgs e)
    {

    }

    protected void btnPremiumCal_Click1(object sender, EventArgs e)
    {


       


    }
}