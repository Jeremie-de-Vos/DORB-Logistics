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
    public partial class Planners : Form
    {
        //Main
        public Planners()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            Customer_name.Text = LoginRolplayBased.loggedinName;

            //Set MenuTabs
            MenuTabs.Appearance = TabAppearance.FlatButtons;
            MenuTabs.ItemSize = new Size(0, 1);
            MenuTabs.SizeMode = TabSizeMode.Fixed;
            MenuTabs.SelectedIndex = 0;
            UnplannedOrders();
        }

        private void UnplannedOrders()
        {
            //List with all orders
            List<global::MyOrders> list = new List<global::MyOrders>();

            //create connection and open it
            MySqlConnection SelectCommand = new MySqlConnection(Db.ConString);
            SelectCommand.Open();

            //try to connect to database
            try
            {
                //Get Order_id and pass it
                MySqlCommand id_cmd = SelectCommand.CreateCommand();
                id_cmd.CommandText = "SELECT `order_ID`, `klant_ID`, `rit_ID`, `postcode`, `straatnaam`, `huis_nr`, `plaats`, `land`, `ontvanger`, `datum` FROM `orders` " +
                    "WHERE `rit_ID` = 0";

                //Set reader
                MySqlDataReader reader = id_cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new MyOrders(
                        int.Parse(reader["order_ID"].ToString()),
                        "KlantID: " + reader["klant_ID"].ToString(),
                        "RitID: " + reader["rit_ID"].ToString(),
                        "Huisnr: " + reader["huis_nr"].ToString(),
                        "Plaats: " + reader["plaats"].ToString(),
                        "Land: " + reader["land"].ToString(),
                        "Ontvanger: " + reader["ontvanger"].ToString()
                        ));
                }
                //create UI foreach item
                UI_Unplanned(list);
            }
            //finally
            finally
            {
                //check state and clone
                if (SelectCommand.State == ConnectionState.Open)
                    SelectCommand.Clone();
            }
        }
        private void clearRitplanner()
        {
            Chauffeur_cmb.Items.Clear();
            Chauffeur_cmb.Items.Add("None");
            Vrachtwagen_cmb.Items.Clear();
            Vrachtwagen_cmb.Items.Add("None");
        }

        #region Info-Setup
        private void ChauffeurSetup()
        {
            //create connection and open it
            MySqlConnection SelectCommand = new MySqlConnection(Db.ConString);
            SelectCommand.Open();

            //try to connect to database
            try
            {
                //Get Order_id and pass it
                MySqlCommand id_cmd = SelectCommand.CreateCommand();
                id_cmd.CommandText = "SELECT `chauffeur_ID`, `voornaam`, `tussenvoegsel`, `achternaam`, `soortrijbewijs`, `nationaliteit_rijbewijs`, `werkdagen`, `inlognaam` " +
                    "FROM `chauffeurs`";

                //Set reader
                MySqlDataReader reader = id_cmd.ExecuteReader();

                //Write each order_id
                while (reader.Read())
                {
                    if (reader["tussenvoegsel"].ToString() != string.Empty)
                    {
                        Chauffeur_cmb.Items.Add(reader["voornaam"] + " " +
                            reader["tussenvoegsel"] + " " +
                            reader["achternaam"].ToString());
                    }
                    else
                    {
                        Chauffeur_cmb.Items.Add(reader["voornaam"] + " " +
                            reader["achternaam"].ToString());
                    }
                }
                Chauffeur_cmb.SelectedIndex = 0;
            }
            //finally
            finally
            {
                //check state and clone
                if (SelectCommand.State == ConnectionState.Open)
                    SelectCommand.Clone();
            }
        }
        private void VrachtwagenSetup()
        {
            //create connection and open it
            MySqlConnection SelectCommand = new MySqlConnection(Db.ConString);
            SelectCommand.Open();

            //try to connect to database
            try
            {
                //Get Order_id and pass it
                MySqlCommand id_cmd = SelectCommand.CreateCommand();
                id_cmd.CommandText = "SELECT `vrachtwagen_ID`, `soort`, `kenteken`, `apk_tot`, `status` FROM `vrachtwagens` WHERE `status`= 'Beschikbaar'";


                //Set reader
                MySqlDataReader reader = id_cmd.ExecuteReader();

                //Write each order_id
                while (reader.Read())
                {
                    Vrachtwagen_cmb.Items.Add(reader["soort"] + "   " +
                        reader["kenteken"].ToString());
                }
                Vrachtwagen_cmb.SelectedIndex = 0;
            }
            //finally
            finally
            {
                //check state and clone
                if (SelectCommand.State == ConnectionState.Open)
                    SelectCommand.Clone();
            }
        }
        private void DeliveryInfoSetup(int ID)
        {
            MyOrders o = null;

            //create connection and open it
            MySqlConnection SelectCommand = new MySqlConnection(Db.ConString);
            SelectCommand.Open();

            //try to connect to database
            try
            {
                MySqlCommand id_cmd = SelectCommand.CreateCommand();
                id_cmd.CommandText = "SELECT `order_ID`, `klant_ID`, `rit_ID`, `postcode`, `straatnaam`, `huis_nr`, `plaats`, `land`, `ontvanger`, `datum` FROM `orders` " +
                    "WHERE `order_ID` = " + ID;

                //Set reader
                MySqlDataReader reader = id_cmd.ExecuteReader();

                //Write each order_id
                while (reader.Read())
                {
                    o = new MyOrders(
                        int.Parse(reader["order_ID"].ToString()),
                        reader["postcode"].ToString(),
                        reader["straatnaam"].ToString(),
                        reader["huis_nr"].ToString(),
                        reader["plaats"].ToString(),
                        reader["land"].ToString(),
                        reader["ontvanger"].ToString()
                        );
                }
                //create UI foreach item
                UIDeliveryInfoSetup(o);
            }
            //finally
            finally
            {
                //check state and clone
                if (SelectCommand.State == ConnectionState.Open)
                    SelectCommand.Clone();
            }
        }
        private void UIDeliveryInfoSetup(MyOrders o)
        {
            RP_straat.Text = o._straatnaam;
            RP_postcode.Text = o._postcode;
            RP_plaats.Text = o._plaats;
            RP_ontvanger.Text = o._ontvanger;
            RP_land.Text = o._land;
            RP_huisnr.Text = o._huisnr;
        }
        #endregion
        #region UI-Builds
        private void UI_Unplanned(List<MyOrders> list)
        {
            //Clear Controls
            while (Container_unplanned.Controls.Count > 0) Container_unplanned.Controls[0].Dispose();

            for (int i = 0; i < list.Count; i++)
            {
                //Create Panel
                Panel p = new Panel();
                Container_unplanned.Controls.Add(p);
                p.Width = Container_unplanned.Width;
                p.Height = 35;
                p.BackColor = Color.DarkGray;

                //Create Inhoud Label
                Label l = new Label();
                p.Controls.Add(l);
                l.Text =
                    list[i]._postcode + "   " +
                    list[i]._straatnaam + "   " +
                    list[i]._huisnr + "   " +
                    list[i]._plaats + "   " +
                    list[i]._land + "   " +
                    list[i]._ontvanger + "   ";
                l.AutoSize = true;
                l.Location = new Point(0, (p.Height - 8) / 2);
                l.Font = new Font(l.Font.FontFamily, 8);

                //Create plan now button
                Button b = new Button();
                p.Controls.Add(b);
                b.Size = new Size(p.Height*3,p.Height-4);
                b.Location = new Point((p.Width - b.Width) - 8, (p.Height - b.Height)/2);
                b.Name = list[i]._ID.ToString();
                b.Text = "Plan now";
                b.Click += PlanNow;
            }
        }
        private void PlanNow(object sender, EventArgs e)
        {
            Button b = sender as Button;
            //MessageBox.Show("Order ID = "+ b.Name);
            clearRitplanner();
            VrachtwagenSetup();
            ChauffeurSetup();
            DeliveryInfoSetup(int.Parse(b.Name));
            MenuTabs.SelectedIndex = 2;
        }
        #endregion
        #region Button-Handlers
        private void Unplanned_btn_Click(object sender, EventArgs e)
        {
            MenuTabs.SelectedIndex = 0;
            UnplannedOrders();
        }
        private void Planned_btn_Click(object sender, EventArgs e)
        {
            MenuTabs.SelectedIndex = 1;
        }
        #endregion

        private int GetChauffeurID(string voledige_naam)
        {
            //create connection and open it
            MySqlConnection SelectCommand = new MySqlConnection(Db.ConString);
            SelectCommand.Open();

            //try to connect to database
            try
            {
                //Get Order_id and pass it
                MySqlCommand id_cmd = SelectCommand.CreateCommand();
                string[] words = voledige_naam.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                MessageBox.Show(voledige_naam+" "+words.Length.ToString());

                //Set parameters
                if (words.Length < 2)
                {
                    id_cmd.CommandText = "SELECT `chauffeur_sID`, `voornaam`, `tussenvoegsel`, `achternaam` FROM `chauffeurs` " +
                        "WHERE `voornaam` = @voornaam AND `achternaam` = @lastname AND 'tussenvoegsel' = @tussenvoegsel";
                    id_cmd.Parameters.AddWithValue("@voornaam", words[0]);
                    id_cmd.Parameters.AddWithValue("@tussenvoegsel", words[1]);
                    id_cmd.Parameters.AddWithValue("@lastname", words[2]);
                }
                else
                {
                    id_cmd.CommandText = "SELECT `chauffeur_ID`, `voornaam`, `tussenvoegsel`, `achternaam` FROM `chauffeurs` " +
                        "WHERE `voornaam` = @voornaam AND `achternaam` = @lastname";
                    id_cmd.Parameters.AddWithValue("@voornaam", words[0]);
                    id_cmd.Parameters.AddWithValue("@tussenvoegsel", "");
                    id_cmd.Parameters.AddWithValue("@lastname", words[1]);
                }

                //Set reader
                MySqlDataReader reader = id_cmd.ExecuteReader();

                //Write each order_id
                while (reader.Read())
                {
                    return int.Parse(reader["chauffeur_ID"].ToString());
                }
                return 0;
            }
            //finally
            finally
            {
                //check state and clone
                if (SelectCommand.State == ConnectionState.Open)
                    SelectCommand.Clone();
            }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            Control[] c = {Chauffeur_cmb, Vrachtwagen_cmb };
            if (Check._Ctrl(c, Methode.Color))
            {
                //RittoDB();
                MessageBox.Show(GetChauffeurID(Chauffeur_cmb.Text).ToString());
            }
        }
        private void RittoDB(int ChauffeurID, int VrachtwagenID, string rijDatum)
        {
            //create connection and open it
            MySqlConnection SelectCommand = new MySqlConnection(Db.ConString);
            SelectCommand.Open();

            //try to connect to database
            try
            {
                //Get Order_id and pass it
                MySqlCommand id_cmd = SelectCommand.CreateCommand();
                id_cmd.CommandText = "INSERT INTO `ritten`(`rit_ID`, `chauffeur_ID`, `vrachtwagen_ID`, `rijDatum`) " +
                    "VALUES ([value-1],[value-2],[value-3],[value-4])";

                id_cmd.Parameters.AddWithValue("@chauffeurID", "");
                id_cmd.Parameters.AddWithValue("@vrachtwagenID", "");
                id_cmd.Parameters.AddWithValue("@rijDatum", "");


                //Set reader
                MySqlDataReader reader = id_cmd.ExecuteReader();

                //Write each order_id
                while (reader.Read())
                {
                    Vrachtwagen_cmb.Items.Add(reader["soort"] + "   " +
                        reader["kenteken"].ToString());
                }
                Vrachtwagen_cmb.SelectedIndex = 0;
            }
            //finally
            finally
            {
                //check state and clone
                if (SelectCommand.State == ConnectionState.Open)
                    SelectCommand.Clone();
            }
        }
    }
}

