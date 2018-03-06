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
        //Database-Variable
        internal protected static string datasource = "localhost";
        internal protected static string username = "root";
        internal protected static string password = "";
        internal protected static string database = "dorp-logistics";
        internal protected static string ConString = "datasource = "+ datasource + "; username = " + username+ "; password=" + password + "; database = " + database;

        //Load Chauffeurs data to Datagrid
        internal static void Load(DataGridView view1)
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

        //Get fullname From ID
        internal static string FullName(int id)
        {
            //create connection and open it
            MySqlConnection connection = new MySqlConnection(ConString);
            connection.Open();

            //try to connect to database
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT `voornaam`, `tussenvoegsel`, `achternaam` FROM `klanten` WHERE `klant_id`="+id+"";
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                    return reader["voornaam"] + " " + reader["tussenvoegsel"] + " " + reader["achternaam"].ToString();
                else
                    return "no match";
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
