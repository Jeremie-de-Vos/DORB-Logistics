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

            //Set MenuTabs
            MenuTabs.Appearance = TabAppearance.FlatButtons;
            MenuTabs.ItemSize = new Size(0, 1);
            MenuTabs.SizeMode = TabSizeMode.Fixed;
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




        //=================================================================================
        //New order - Variables
        List<int> enabledTabs = new List<int>();

        //reset New order tab
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
    }
}
