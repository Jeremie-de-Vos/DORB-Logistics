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
    public partial class Chauffeurs : Form
    {
        //Main
        public Chauffeurs()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            Customer_name.Text = LoginRolplayBased.loggedinName;
        }

        private void Chauffeurs_Load(object sender, EventArgs e)
        {

        }
    }
}
