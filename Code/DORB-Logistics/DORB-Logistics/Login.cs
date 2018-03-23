using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DORB_Logistics
{
    public partial class Login_frm : Form
    {
        //Main
        public Login_frm()
        {
            InitializeComponent();
            this.BackColor = Color.LightGreen;
        }

        //Load
        private void Login_frm_Load(object sender, EventArgs e)
        {
            
        }

        //Login-handler
        private void Login()
        {

            
            //array with texboxes to check
            Control[] t = new Control[] { Email, Password };

            //Check if fields are filled in
            if (Check._Ctrl(t,Methode.Color))
            {
                //create connection and open it
                MySqlConnection connection = new MySqlConnection(Db.ConString);
                connection.Open();

                //try to connect to database
                try
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM klanten WHERE `email`= @email AND `wachtwoord`= @password", connection);
                    cmd.Parameters.AddWithValue("@email", Email.Text);
                    cmd.Parameters.AddWithValue("@password", Password.Text);

                    //Get Customer_id and pass it to the Klant-Main form
                    MySqlCommand id_cmd = connection.CreateCommand();
                    id_cmd.CommandText = "SELECT `klant_id` FROM `klanten` WHERE `email`= '" + Email.Text + "'";
                    MySqlDataReader reader = id_cmd.ExecuteReader();

                    //Read results
                    if (reader.Read())
                    {
                        //create form
                        //Klant_main frm = new Klant_main(int.Parse(reader["klant_id"].ToString()));
                        //frm.Show();
                    }
                    else
                        MessageBox.Show("no match [YOU ARE NOT GRANTED WITH ACCESS]");
                }
                //finally
                finally
                {
                    //check state and clone
                    if (connection.State == ConnectionState.Open)
                        connection.Clone();
                }
            }
            else
                Log.Text = "Not all area's has been filled in!";
        }

        //Login-Button
        private void Login_btn_Click(object sender, EventArgs e)
        {
            LoginRolplayBased.Login(Email.Text, Password.Text);
            //Login();
        }

        //Cancel-Button
        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            Email.Text = string.Empty;
            Password.Text = string.Empty;
        }

        //Register-click
        private void label6_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.Show();
        }
    }
}
