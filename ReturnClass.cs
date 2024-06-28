using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trivia_game_4
{
    internal class ReturnClass
    {
    
      private string connstring = ConfigurationManager.ConnectionString["test"].ConnectionString;


        public string scalarReturn(string q)
        {
            string s;
            SqlConnection conn = new SqlConnection(connstring); //connection obj
            conn.Open(); //opening connection
            try
            {
                SqlCommand cmd = new SqlCommand(q, conn);  //query execution

                s = cmd.ExecuteScalar().ToString;
            }
            catch (Exception)
            {
                s = "";
            }
            conn.Close();

            return s;
        }

    }
}
