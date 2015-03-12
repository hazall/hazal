using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Suclular : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string constr = @"Data Source=HAZAL-HAZAL\DEV01;Initial Catalog=Crime;Integrated Security=True";
        SqlConnection conn = new SqlConnection(constr);
        conn.Open();
        SqlCommand mycom = new SqlCommand("select * from Offender", conn);
        DataSet tb = new DataSet();
        SqlDataAdapter adap = new SqlDataAdapter(mycom);
        adap.Fill(tb);
        DataList1.DataSource = tb;
        DataList1.DataBind();
        conn.Close();
    }
    protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {


    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

        if (DropDownList1.SelectedValue == "Name")
        {
            string constr = @"Data Source=HAZAL-HAZAL\DEV01;Initial Catalog=Crime;Integrated Security=True";
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand mycom2 = new SqlCommand("select OName from Offender", conn);
            DataSet tb2 = new DataSet();
            SqlDataAdapter adap2 = new SqlDataAdapter(mycom2);
            adap2.Fill(tb2);
            
            DataList2.DataSource = tb2;
            DataList2.DataBind();
            DataList3.DataSource = null;
            DataList3.DataBind();
            DataList4.DataSource = null;
            DataList4.DataBind();
        }
        if (DropDownList1.SelectedValue == "Surname")
        {
            string constr = @"Data Source=HAZAL-HAZAL\DEV01;Initial Catalog=Crime;Integrated Security=True";
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand mycom3 = new SqlCommand("select OSurname from Offender", conn);
            DataSet tb3 = new DataSet();
            SqlDataAdapter adap3 = new SqlDataAdapter(mycom3);
            adap3.Fill(tb3);
            DataList2.DataSource = null;
            DataList2.DataBind();
            DataList3.DataSource = tb3;
            DataList3.DataBind();
            DataList4.DataSource = null;
            DataList4.DataBind();

        }
        if (DropDownList1.SelectedValue == "Female")
        {
            string constr = @"Data Source=HAZAL-HAZAL\DEV01;Initial Catalog=Crime;Integrated Security=True";
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand mycom4 = new SqlCommand("select OName from Offender where OGender=@id", conn);
            mycom4.Parameters.Add("@id", SqlDbType.Char).Value = "K";
            DataSet tb4 = new DataSet();
            SqlDataAdapter adap4 = new SqlDataAdapter(mycom4);
            adap4.Fill(tb4);
            DataList2.DataSource = null;
            DataList2.DataBind();
            DataList3.DataSource = null;
            DataList3.DataBind();
            DataList4.DataSource = tb4;
            DataList4.DataBind();

        }
        if (DropDownList1.SelectedValue == "Male")
        {
            string constr = @"Data Source=HAZAL-HAZAL\DEV01;Initial Catalog=Crime;Integrated Security=True";
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand mycom4 = new SqlCommand("select OName from Offender where OGender=@id", conn);
            mycom4.Parameters.Add("@id", SqlDbType.Char).Value = "E";
            DataSet tb4 = new DataSet();
            SqlDataAdapter adap4 = new SqlDataAdapter(mycom4);
            adap4.Fill(tb4);
            DataList2.DataSource = null;
            DataList2.DataBind();
            DataList3.DataSource = null;
            DataList3.DataBind();
            DataList4.DataSource = tb4;
            DataList4.DataBind();

        }
    }
}