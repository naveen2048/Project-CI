using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System.Data.SqlClient;

namespace Web_App_CI.Controllers
{
  public class DbController : ApiController
  {
    // GET api/<controller>
    public DataSet Get( )
    {
      return GetData ( );
      //return new string [ ] { "value1" , "value2" };
    }

    private DataSet GetData( )
    {
      SqlConnection _conn = new SqlConnection("Data Source=laptop-sambav1;Integrated Security=True;Persist Security Info=False;user id=sa;password=sa@123;Initial Catalog=TestCI;");
      SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Country",_conn);
      DataSet ds = new DataSet();
      adapter.Fill ( ds );

      return ds;
    }

    // GET api/<controller>/5
    public string Get( int id )
    {
      return "value";
    }

    // POST api/<controller>
    public void Post( [FromBody]string value )
    {
    }

    // PUT api/<controller>/5
    public void Put( int id , [FromBody]string value )
    {
    }

    // DELETE api/<controller>/5
    public void Delete( int id )
    {
    }
  }
}