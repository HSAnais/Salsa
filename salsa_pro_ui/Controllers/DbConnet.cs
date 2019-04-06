using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace salsa_pro_ui.Controllers
{
    public class DbConnet
    {
        SqlConnection con;

        public DbConnet()
        {
            con = new SqlConnection("Data Source=Data Source=DESKTOP-P0DHDBR;Initial Catalog=TheSalUni;Integrated Security=True;Pooling=False");
        }

        public SqlConnection opencon()
        {
            try
            {
                con.Open();
            }
            catch (Exception)
            {


            }

            return con;
        }

        public void conclose()
        {
            try
            {
                con.Close();
            }
            catch (Exception)
            {


            }
        }

    }
}
