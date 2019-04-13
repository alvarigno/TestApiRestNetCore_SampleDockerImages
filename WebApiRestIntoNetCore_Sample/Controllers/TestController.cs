using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiRestIntoNetCore_Sample.Utils;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiRestIntoNetCore_Sample.Controllers
{
    [Route("api/[controller]")]
    public class TestController : Controller
    {

        [HttpGet]
        public JsonResult Get(int CantPagina, int NumPagina)
        {
            //int CantPagina = 10; 
            //int NumPagina = 0;

            string _context = Herramientas.CreaDataContext();

            List<string[]> releases = new List<string[]>();
            using (SqlConnection connection = new SqlConnection(_context))
            {

                connection.Open();
                using (IDbCommand spCommand = connection.CreateCommand())
                {

                    SqlCommand cmd = new SqlCommand("sp_getRegistrosClientes", connection)
                    {
                        CommandType = System.Data.CommandType.StoredProcedure
                    };

                    cmd.Parameters.AddWithValue("@pageSize", CantPagina);
                    cmd.Parameters.AddWithValue("@pageNum", NumPagina);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            List<string> ldata = new List<string>();
                            if (reader.HasRows)
                            {

                                ldata.Add(reader["name"].ToString());
                                ldata.Add(reader["quantity"].ToString());

                            }

                            releases.Add(ldata.ToArray());

                        }


                    }

                }
                connection.Close();

            }

            return new JsonResult(releases);
        }

    }
}
