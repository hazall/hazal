using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        string constr = @"Data Source=HAZAL-HAZAL\DEV01;Initial Catalog=Crime;Integrated Security=True";
        SqlConnection conn = new SqlConnection(constr);
        conn.Open();
        SqlCommand mycom = new SqlCommand("select * from Victim inner join Offender on Victim.OffID=Offender.OffID where Offender.OffID=@a", conn);
        mycom.Parameters.Add("@a", SqlDbType.Int).Value = Request.QueryString["id"];
        DataSet tb = new DataSet();
        SqlDataAdapter adap = new SqlDataAdapter(mycom);
        adap.Fill(tb);
        DataList1.DataSource = tb;
        DataList1.DataBind();
        GridView1.DataSource = tb;
        GridView1.DataBind();
        conn.Close();
    }
}