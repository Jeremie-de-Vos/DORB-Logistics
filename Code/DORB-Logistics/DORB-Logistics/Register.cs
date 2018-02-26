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
    public partial class Register : Form
    {
        //main
        public Register()
        {
            InitializeComponent();
            B_P_cmb.SelectedIndex = 0;
        }
 
        //Create Btn click
        private void Create_btn_Click_1(object sender, EventArgs e)
        {
            TextBox[] textboxen = new TextBox[] {
                Naam_txt,
                Tussenvg_txt,
                Achternaam_txt,
                Geboorte_txt,
                email_txt,
                tel_txt,
                postcode_txt,
                plaats_txt,
                straat_txt,
                Huisnr_txt,
                land_txt,
                iban_txt,
                ww_txt,
                ww_H_txt
            };
            Check.TextBoxState(textboxen, Methode.Color,this);
        }

        //Bedrij-particulier Changes
        private void B_P_cmb_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //if bedrijf
            if (B_P_cmb.SelectedIndex != 1)
            {
                B_P_cmb.BackColor = Color.White;
                bedrijfnaam_txt.BackColor = Color.White;

                bedrijnaam_lbl.Enabled = false;
                bedrijfnaam_txt.Enabled = false;
            }
            else
            {
                bedrijnaam_lbl.Enabled = true;
                bedrijfnaam_txt.Enabled = true;
            }
        }
    }
}
