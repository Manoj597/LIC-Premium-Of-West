using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Premium_BLL;
using BusinessObjects;

public partial class PremiumCalprint : System.Web.UI.Page
{
   

    protected void Page_Load(object sender, EventArgs e)
    {
        lblNameDisplay.Text = Convert.ToString( Session.Contents["name"]);
        lblPolicyTypeDisplay.Text = Convert.ToString(Session.Contents["policytype"]);
        lblPolicyTermDisplay.Text = Convert.ToString(Session.Contents["policyterm"]);
        lblAgeDisplay.Text = Convert.ToString(Session.Contents["age"]);
        lblInsuredAmountDisplay.Text = Convert.ToString(Session.Contents["insuredAmt"]);

    }
   public void btnSubmit_Click(object sender, EventArgs e)
    {

        PremiumCalc cal = new PremiumCalc();

    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect(@"~/premiumchild.aspx");
    }
}