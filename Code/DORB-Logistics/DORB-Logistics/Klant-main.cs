using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DORB_Logistics
{
    public partial class Klant_main : Form
    {
        //Main
        public Klant_main(int id)
        {
            InitializeComponent();

            //set main stuff
            this.BackColor = Color.LightCoral;
            Customer_name.Text = Db.FullName(id);

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

        //===================================<Order-Info>==============================================
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
        #endregion
        //====================================<General>================================================
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
        }
        private void New_order_btn_Click(object sender, EventArgs e)
        {
            MenuTabs.SelectedIndex = 1;
        }
        #endregion
        //====================================<Bezorging>=============================================
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

        //====================================<Payment>===============================================
        //Set-Up bezorging from the form

        //Function in database class that needs a list of pallets and a class bezorging to setup data
        //The planner can see what is not planed yet by filering if Rit_ID = null 
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
    internal int HuisNr;
    internal string Postcode;
    internal string Plaats;
    internal string Land;

    internal string Ontvanger;
    internal string Datum;

    internal Bezorging(string straat, int huisNr, string postcode, string plaats, string land, string ontvanger, string datum)
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
