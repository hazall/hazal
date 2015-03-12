using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    string a;
    string b;
    protected void Page_Load(object sender, EventArgs e)
    {
        //string constr = @"Data Source=HAZAL-HAZAL\DEV01;Initial Catalog=Crime;Integrated Security=True";
        //SqlConnection conn = new SqlConnection(constr);
        //conn.Open();
        //SqlCommand mycom = new SqlCommand("select * from MCrimeType", conn);
        //DataSet tb = new DataSet();
        //SqlDataAdapter adap = new SqlDataAdapter(mycom);
        //adap.Fill(tb);
        //DropDownList1.DataSource = tb;
        //DropDownList1.DataTextField = "CrimeName";     
        //DropDownList1.DataValueField = "TypeID";
        //DropDownList1.DataBind();
        //conn.Close();
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {

        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        a = DropDownList1.SelectedValue;
        b = DropDownList2.SelectedValue;
        string c = DropDownList3.SelectedValue;
        string constr = @"Data Source=HAZAL-HAZAL\DEV01;Initial Catalog=Crime;Integrated Security=True";
        SqlConnection conn = new SqlConnection(constr);
        conn.Open();
        SqlCommand mycom = new SqlCommand("select * from Offender inner join MCrimeType on Offender.TypeID=MCrimeType.TypeID where MCrimeType.CrimeName=@a and Offender.OAddress=@b and Offender.OGender=@c", conn);
        mycom.Parameters.Add("@a", SqlDbType.NVarChar).Value = a;
        mycom.Parameters.Add("@b", SqlDbType.NVarChar).Value = b;
        mycom.Parameters.Add("@c", SqlDbType.Char).Value = c;
        DataSet tb = new DataSet();
        SqlDataAdapter adap = new SqlDataAdapter(mycom);
        adap.Fill(tb);
        DataList1.DataSource = tb;
        DataList1.DataBind();
        conn.Close();
    }
}
