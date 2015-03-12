using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Detail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int a = Convert.ToInt32(Request.QueryString["id"]);
        string constr = @"Data Source=HAZAL-HAZAL\DEV01;Initial Catalog=Crime;Integrated Security=True";
        SqlConnection conn = new SqlConnection(constr);
        conn.Open();
        SqlCommand mycom = new SqlCommand("select * from Offender inner join Location on Offender.OffID = Location.OID where Offender.OffID=@id ",conn);
        mycom.Parameters.Add("@id", SqlDbType.Int).Value = a;
        SqlDataAdapter adap = new SqlDataAdapter(mycom);
        DataTable tb = new DataTable();
        adap.Fill(tb);
        GridView1.DataSource = tb;
        GridView1.DataBind();
        Label1.Text = tb.Rows[0]["OName"].ToString();
        Label2.Text = tb.Rows[0]["OSurname"].ToString();
        Label3.Text = tb.Rows[0]["OGender"].ToString();
        
        conn.Close();
    }
}