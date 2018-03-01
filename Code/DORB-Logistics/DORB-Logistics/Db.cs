using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace DORB_Logistics
{
    class Db
    {
        public static string datasource = "localhost";
        public static string username = "root";
        public static string password = "";
        public static string database = "dorp-logistics";

        public static string ConString = "datasource = "+ datasource + "; username = " + username+ "; password=" + password + "; database = " + database;

        public static void Load(DataGridView view1)
        {
            //create connection and open it
            MySqlConnection connection = new MySqlConnection(ConString);
            connection.Open();

            //try to connect to database
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM chauffeurs";

                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                view1.DataSource = ds.Tables[0].DefaultView;
            }
            //catch exceptions
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Clone();
            }
        }
        enum Table
        {
            //put all the table names so you can easly switch with for example a combobox
        }
    }
}
