using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_App_CI
{
  public partial class index : System.Web.UI.Page
  {
    protected void Page_Load( object sender , EventArgs e )
    {
      LoadData ( );
    }

    private void LoadData( )
    {
      SqlConnection _conn = new SqlConnection("Data Source=laptop-sambav1;Integrated Security=True;Persist Security Info=False;user id=sa;password=sa@123;Initial Catalog=TestCI;");
      SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Country",_conn);
      DataSet ds = new DataSet();
      adapter.Fill ( ds );

      grd.DataSource = ds.Tables [ 0 ];
      grd.DataBind ( );
    }
  }
}