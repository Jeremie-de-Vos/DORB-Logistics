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
    public partial class Klant_main : Form
    {
        private int KlantID;
        //Main
        public Klant_main()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            KlantID = LoginRolplayBased.loggedinID;

            //set main stuff
            this.BackColor = Color.LightCoral;
            Customer_name.Text = Db.FullName(KlantID);
            _MyOrders();

            //Set NewOrder
            enabledTabs.Add(0);
            Check_enabledTabs();
            Statecheck();

            //Set MenuTabs
            MenuTabs.Appearance = TabAppearance.FlatButtons;
            MenuTabs.ItemSize = new Size(0, 1);
            MenuTabs.SizeMode = TabSizeMode.Fixed;

            //Clear order panel
            List<Control> listControls = new List<Control>();
            foreach (Control control in Pallet_Container.Controls)
            {
                listControls.Add(control);
            }
            foreach (Control control in listControls)
            {
                Pallet_Container.Controls.Remove(control);
                control.Dispose();
            }
        }

        #region Variable
        List<Pallets> palletsTemp = new List<Pallets>();
        Pallets currentedit = null;
        bool editing = false;
        int id_counter = 0;
        #endregion
        #region CRUD-Pallets
        //Check editing state
        private void Statecheck()
        {
            if (editing)
            {
                OI_Add_btn.Text = "Apply";
                OI_Clear_btn.Text = "New";
                Delete_btn.Visible = true;
            }
            else
            {
                OI_Add_btn.Text = "Add";
                OI_Clear_btn.Text = "Clear";
                Delete_btn.Visible = false;
            }
        }

        //Add-pallet
        private void OI_Add_btn_Click(object sender, EventArgs e)
        {
            OI_Add();
        }
        private void OI_Add()
        {
            //Create array with controls that have to be checked
            Control[] OI_Controls = new Control[] { OI_inhoud, OI_Gewicht, OI_Hoeveelheid };

            //check fields
            if (Check._Ctrl(OI_Controls, Methode.Color))
            {
                //if we are editing
                if (editing)
                {
                    //Load-Values-toList
                    for (int i = 0; i < palletsTemp.Count; i++)
                        //Find the list item that belongs to the panel
                        if (palletsTemp[i].P.Name == palletsTemp[i].ID + "_p")
                        {
                            //Update the item values
                            palletsTemp[i].Inhoud = OI_inhoud.Text;
                            palletsTemp[i].Gewicht = Convert.string_int(OI_Gewicht.Text);
                            palletsTemp[i].Hoeveelheid = Int64.Parse(OI_Hoeveelheid.Value.ToString());
                            palletsTemp[i].Notitie = OI_Notitie.Text;

                            //Update Right-Side UI Values
                            palletsTemp[i].N.Value = palletsTemp[i].Hoeveelheid;
                            palletsTemp[i].L.Text = palletsTemp[i].Inhoud;
                        }
                        else
                            MessageBox.Show("Name does not seem to be the same!");
                    editing = false;
                }
                //Not editing
                else
                {
                    //Create new and set values
                    id_counter++;
                    palletsTemp.Add(new Pallets(id_counter,OI_inhoud.Text, Convert.string_int(OI_Gewicht.Text), Int64.Parse(OI_Hoeveelheid.Value.ToString()), OI_Notitie.Text, null ,null, null));
                    Refresch_Pallet_list();
                }

                //Clear Fields and Update the Editing State
                OI_Clear();
                Statecheck();
            }
        }

        //Delete-pallet
        private void Delete_btn_Click(object sender, EventArgs e)
        {
            OI_Delete();
        }
        private void OI_Delete()
        {
            //if editing
            if (editing)
            {
                //loop list
                for (int i = 0; i < palletsTemp.Count; i++)
                    //if match wth item that we are editing
                    if (palletsTemp[i] == currentedit)
                    {
                        DialogResult dialogResult = MessageBox.Show("Do you like these pallets", "Delete Conformation", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            //Delete UI
                            palletsTemp[i].P.Dispose();
                            //Delet from list
                            palletsTemp.Remove(palletsTemp[i]);
                            //Clear-Update editing mode
                            OI_Clear();
                            editing = false;
                            Statecheck();
                            //Refresh List
                            Refresch_Pallet_list();
                        }
                    }
            }
            else
                MessageBox.Show("You can't delete because your not editing!");
        }

        //Clear-fields
        private void OI_Clear_btn_Click(object sender, EventArgs e)
        {
            //if we are editing
            if (editing)
            {
                OI_Clear();
                editing = false;
                Statecheck();
            }
            else
                OI_Clear();
        }
        private void OI_Clear()
        {
            //Clear all fields
            OI_inhoud.Text = null;
            OI_Gewicht.Text = null;
            OI_Hoeveelheid.Value = 0;
            OI_Notitie.Text = null;

            //Reset all Colors
            OI_inhoud.BackColor = Color.White;
            OI_Gewicht.BackColor = Color.White;
            OI_Hoeveelheid.BackColor = Color.White;
            OI_Notitie.BackColor = Color.White;
        }

        //Refresh-pallet-UI
        private void Refresch_Pallet_list()
        {
            //create new
            for (int i = 0; i < palletsTemp.Count; i++)
            {
                //check if there is already a UI for this Item
                if (palletsTemp[i].P == null)
                {
                    //Create Panel
                    Panel p = new Panel();
                    Pallet_Container.Controls.Add(p);
                    p.Width = Pallet_Container.Width;
                    p.Height = 33;
                    p.BackColor = Color.DarkGray;

                    //Create Inhoud Label
                    Label l = new Label();
                    p.Controls.Add(l);
                    l.Text = palletsTemp[i].Inhoud;
                    l.AutoSize = true;
                    l.Location = new Point(0, 6);

                    //Create Amount NumericUpDown
                    NumericUpDown n = new NumericUpDown();
                    p.Controls.Add(n);
                    n.Size = new Size(50, 20);
                    n.Value = palletsTemp[i].Hoeveelheid;
                    n.Location = new Point((p.Width - n.Width) - 5, 6);

                    //Add Events to UI Elementsss
                    p.DoubleClick += Control_DoubleClick;
                    n.ValueChanged += OI_pallet_amount_changed;

                    p.Name = palletsTemp[i].ID + "_p";

                    //Update the UI to the uptodate Values
                    palletsTemp[i].P = p;
                    palletsTemp[i].N = n;
                    palletsTemp[i].L = l;
                }
            }
        }
        #endregion
        #region Events-Handlers
        //Control events
        void Control_DoubleClick(object sender, EventArgs e)
        {
            for (int i = 0; i < palletsTemp.Count; i++)
                if(palletsTemp[i].P == ((Panel)sender))
                {
                    OI_Clear();

                    //load in
                    OI_inhoud.Text = palletsTemp[i].Inhoud;
                    OI_Gewicht.Text = palletsTemp[i].Gewicht.ToString();
                    OI_Hoeveelheid.Value = palletsTemp[i].Hoeveelheid;
                    OI_Notitie.Text = palletsTemp[i].Notitie;
                    editing = true;
                    Statecheck();

                    //set current edit item so we are able to delete it
                    currentedit = palletsTemp[i];
                }
        }
        void OI_pallet_amount_changed(object sender, EventArgs e)
        {
            //MessageBox.Show(((Panel)sender).Name + " clicked");
            for (int i = 0; i < palletsTemp.Count; i++)
                if (palletsTemp[i].N == ((NumericUpDown)sender))
                {
                    palletsTemp[i].Hoeveelheid = Int64.Parse(((NumericUpDown)sender).Value.ToString());
                    palletsTemp[i].N.Value = palletsTemp[i].Hoeveelheid;
                }

        }

        //Gewicht-Proceed-Handler
        private void OI_Gewicht_KeyPress(object sender, KeyPressEventArgs e)
        {
            Check.Check_textbox_int(e);
        }
        private void Proceed_btn_Click(object sender, EventArgs e)
        {
            //check if list is empty
            if (palletsTemp.Count == 0)
                MessageBox.Show("Please add some items to proceed!");
            else
                NewOrder_tabs.SelectedIndex = 1;
        }

        //Check-Out
        private void BZ_Proceed_btn_Click(object sender, EventArgs e)
        {
            //array with controls to check
            Control[] c = new Control[] { BZ_straat, BZ_HuisNr, BZ_Postcode, BZ_plaats, BZ_land, BZ_ontvanger, BZ_Datum };

            //Check if filled
            if (Check._Ctrl(c, Methode.Color))
            {
                if (palletsTemp.Count != 0)
                    NewOrder_tabs.SelectedIndex = 2;
                else
                    MessageBox.Show("There are no items added!");
            }
        }
        #endregion

        #region Variable
        //New order - Variables
        List<int> enabledTabs = new List<int>();
        #endregion
        #region TabSystem
        //Reset New order tab
        private void Reset_OrderTab()
        {
            //reset enabled tabs to none [+1 because the pallet tab has to be active]
            //empty all fields
        }
        //Check-enabledTabs
        private void Check_enabledTabs()
        {
            //foreach enabled tab in enabledTabs
            for (int i = 0; i < enabledTabs.Count; i++)
            {
                //if Selectedtab != not in enabledtabs list
                if (NewOrder_tabs.SelectedIndex != enabledTabs[i])
                    if (NewOrder_tabs.SelectedIndex != 0)
                        NewOrder_tabs.SelectedIndex = NewOrder_tabs.SelectedIndex - 1;
            }
        }

        //Step-NewOrder-Handlers
        private void Step_order_info_btn_Click(object sender, EventArgs e)
        {
            //check if there is atleast a pallet added
            //add next step for example in this case it would be add[1] "the bezorging page"
            enabledTabs.Add(1);
            NewOrder_tabs.SelectedIndex = 1;
        }
        //Selected-Index-Changed
        private void NewOrder_tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Check_enabledTabs();
        }

        //MenuTabs-Handlers
        private void Current_Orders_btn_Click(object sender, EventArgs e)
        {
            MenuTabs.SelectedIndex = 0;
            _MyOrders();
        }
        private void New_order_btn_Click(object sender, EventArgs e)
        {
            MenuTabs.SelectedIndex = 1;
        }
        #endregion
        #region Autofill-Handlers
        //Adress-Autofill
        private void AutoAdress()
        {
            //array with controls to check
            Control[] c = new Control[] { BZ_straat, BZ_HuisNr };

            //Check if the street name and number are filled in
            if (Check._Ctrl(c, Methode.Color))
            {
                //Request list with posible locations
                List<Address> list = Maps.PostalcodeResults(BZ_straat.Text, BZ_HuisNr.Text);

                //Check list = null
                if (list.Count != 0)
                {
                    BZ_Postcode.Text = list.First().zipcode;
                    BZ_plaats.Text = list.First().place;
                    BZ_land.Text = list.First().country;
                }
                else MessageBox.Show("No results for this address");
            }
        }
        private void BZ_straat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AutoAdress();
            }
        }
        private void BZ_HuisNr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AutoAdress();
            }
        }
        #endregion
        #region Order to Database
        private void PY_Confirm_btn_Click(object sender, EventArgs e)
        {
            PrepareOrder();
        }
        private void PrepareOrder()
        {
            //array with controls to check
            Control[] c = new Control[] { BZ_straat, BZ_HuisNr, BZ_Postcode, BZ_plaats, BZ_land, BZ_ontvanger, BZ_Datum };

            //Checkstate and proceed
            if (Check._Ctrl(c, Methode.Color) && palletsTemp.Count != 0)
            {
                Bezorging b = new Bezorging(BZ_straat.Text, Convert.string_int(BZ_HuisNr.Text), BZ_Postcode.Text, BZ_plaats.Text, BZ_land.Text, BZ_ontvanger.Text, BZ_Datum.Text);
                CreateOrder(palletsTemp, b);
            }

            //if not all fields are filled in
            else if (!Check._Ctrl(c, Methode.Color))
                MessageBox.Show("Not all Bezorging fields are filled in!");

            //if pallet_list is empty
            else if (palletsTemp.Count == 0)
                MessageBox.Show("There are no pallets please add some!");

            //if both above failed
            else
                MessageBox.Show("Something is wrong! [Both wrong?]");
        }
        private void CreateOrder(List<Pallets>p, Bezorging b)
        {
            #region Variable
            int Order_ID = 0;
            #endregion
            #region Order to Database
            using (MySqlConnection connection = new MySqlConnection(Db.ConString))
            {
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "" +
                        "INSERT INTO `orders`(`order_ID`, `klant_ID`, `rit_ID`, `postcode`, `straatnaam`, `huis_nr`, `plaats`, `land`, `ontvanger`, `datum`) " +
                        "VALUES (@order_ID,@klant_ID,@rit_ID,@postcode,@straatnaam,@huis_nr,@plaats,@land,@ontvanger,@datum)";


                    //Set parameters
                    command.Parameters.AddWithValue("@order_ID", "");
                    command.Parameters.AddWithValue("@klant_ID", KlantID);
                    command.Parameters.AddWithValue("@rit_ID", "");

                    command.Parameters.AddWithValue("@postcode", b.Postcode);
                    command.Parameters.AddWithValue("@straatnaam", b.Straat);
                    command.Parameters.AddWithValue("@huis_nr", b.HuisNr);
                    command.Parameters.AddWithValue("@plaats", b.Plaats);
                    command.Parameters.AddWithValue("@land", b.Land);
                    command.Parameters.AddWithValue("@ontvanger", b.Ontvanger);
                    command.Parameters.AddWithValue("@datum", b.Datum);

                    try
                    {
                        connection.Open();
                        int recordsAffected = command.ExecuteNonQuery();
                        MessageBox.Show("Order has added");
                    }
                    catch (SqlException)
                    {
                        throw;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            #endregion
            #region Search Created Order
            //create connection and open it
            MySqlConnection SelectCommand = new MySqlConnection(Db.ConString);
            SelectCommand.Open();

            //try to connect to database
            try
            {
                //Get Order_id and pass it
                MySqlCommand id_cmd = SelectCommand.CreateCommand();
                id_cmd.CommandText = "SELECT `order_ID` FROM `orders` " +
                    "WHERE `klant_ID`= @klant_ID " +
                    "AND `postcode`= @postcode " +
                    "AND `straatnaam`= @straatnaam " +
                    "AND `huis_nr`= @huis_nr " +
                    "AND `plaats`= @plaats " +
                    "AND `land`= @land " +
                    "AND `ontvanger`= @ontvanger " +
                    "AND `datum`= @datum";

                //Set params
                id_cmd.Parameters.AddWithValue("@klant_ID", KlantID);
                id_cmd.Parameters.AddWithValue("@postcode", b.Postcode);
                id_cmd.Parameters.AddWithValue("@straatnaam", b.Straat);
                id_cmd.Parameters.AddWithValue("@huis_nr", b.HuisNr);
                id_cmd.Parameters.AddWithValue("@plaats", b.Plaats);
                id_cmd.Parameters.AddWithValue("@land", b.Land);
                id_cmd.Parameters.AddWithValue("@ontvanger", b.Ontvanger);
                id_cmd.Parameters.AddWithValue("@datum", b.Datum);

                MySqlDataReader reader = id_cmd.ExecuteReader();

                //Read results and set Order ID
                if (reader.Read())
                    Order_ID = int.Parse(reader["order_ID"].ToString());
                else
                    MessageBox.Show("no match id found!");
            }
            //finally
            finally
            {
                //check state and clone
                if (SelectCommand.State == ConnectionState.Open)
                    SelectCommand.Clone();
            }
            #endregion
            #region Create pallets
            for (int i = 0; i < p.Count; i++)
            {
                using (MySqlConnection connection = new MySqlConnection(Db.ConString))
                {
                    using (MySqlCommand command = new MySqlCommand())
                    {

                        command.Connection = connection;
                        command.CommandType = CommandType.Text;
                        command.CommandText = "" +
                            "INSERT INTO `pallets`(`pallet_ID`, `order_ID`, `gewicht`, `inhoud`, `notitie`) " +
                            "VALUES (@pallet_ID,@order_ID,@gewicht,@inhoud,@notitie)";


                        //Set parameters
                        command.Parameters.AddWithValue("@pallet_ID", "");
                        command.Parameters.AddWithValue("@order_ID", Order_ID);
                        command.Parameters.AddWithValue("@gewicht", p[i].Gewicht);
                        command.Parameters.AddWithValue("@inhoud", p[i].Inhoud);
                        command.Parameters.AddWithValue("@notitie", p[i].Notitie);

                        try
                        {
                            connection.Open();
                            int recordsAffected = command.ExecuteNonQuery();
                            MessageBox.Show("Pallet has been added");
                        }
                        catch (SqlException)
                        {
                            throw;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
            #endregion
        }
        #endregion
        #region MyOrders
        private void _MyOrders()
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
                    "WHERE `klant_ID`= @klant_ID";

                //Set params
                id_cmd.Parameters.AddWithValue("@klant_ID", KlantID);

                //Set reader
                MySqlDataReader reader = id_cmd.ExecuteReader();

                //Write each order_id
                while (reader.Read())
                {
                    //MessageBox.Show(int.Parse(reader["order_ID"].ToString()).ToString());
                    //Create order panel
                    list.Add(new global::MyOrders(
                        int.Parse(reader["order_ID"].ToString()),
                        reader["postcode"].ToString(),
                        reader["straatnaam"].ToString(),
                        reader["huis_nr"].ToString(),
                        reader["plaats"].ToString(),
                        reader["land"].ToString(),
                        reader["ontvanger"].ToString()
                        ));
                }
                //create UI foreach item
                UI_MyOrders(list);
            }
            //finally
            finally
            {
                //check state and clone
                if (SelectCommand.State == ConnectionState.Open)
                    SelectCommand.Clone();
            }
        }
        private void UI_MyOrders(List<global::MyOrders> list)
        {
            //Clear Controls
            while (Cur_order_Container.Controls.Count > 0) Cur_order_Container.Controls[0].Dispose();

            for (int i = 0; i < list.Count; i++)
            {
                //Create Panel
                Panel p = new Panel();
                Cur_order_Container.Controls.Add(p);
                p.Width = Cur_order_Container.Width;
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
                l.Location = new Point(0, (p.Height - 8)/2);
                l.Font = new Font(l.Font.FontFamily, 8);
            }
        }
        #endregion
    }
}
class Pallets
{
    internal int ID;
    internal string Inhoud;
    internal Int64 Gewicht;
    internal Int64 Hoeveelheid;
    internal string Notitie;

    internal Panel P;
    internal Label L;
    internal NumericUpDown N;

    internal Pallets(int id, string inhoud, Int64 gewicht, Int64 hoeveelheid, string notitie, Panel p, Label l ,NumericUpDown n)
    {
        ID = id;
        Inhoud = inhoud;
        Gewicht = gewicht;
        Hoeveelheid = hoeveelheid;
        Notitie = notitie;
        P = p;
        N = n;
        L = l;
    }
}
class Bezorging
{
    internal string Straat;
    internal Int64 HuisNr;
    internal string Postcode;
    internal string Plaats;
    internal string Land;

    internal string Ontvanger;
    internal string Datum;

    internal Bezorging(string straat, Int64 huisNr, string postcode, string plaats, string land, string ontvanger, string datum)
    {
        Straat = straat;
        HuisNr = huisNr;
        Postcode = postcode;
        Plaats = plaats;
        Land = land;
        Ontvanger = ontvanger;
        Datum = datum;
    }
}
class MyOrders
{
    internal int _ID;
    internal string _postcode;
    internal string _straatnaam;
    internal string _huisnr;
    internal string _plaats;
    internal string _land;
    internal string _ontvanger;

    public MyOrders (int ID, string postcode, string straatnaam, string huisnr, string plaats, string land, string ontvanger)
    {
        _ID = ID;
        _postcode = postcode;
        _straatnaam = straatnaam;
        _huisnr = huisnr;
        _plaats = plaats;
        _land = land;
        _ontvanger = ontvanger;
    }
}
