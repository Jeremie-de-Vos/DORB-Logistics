﻿using MySql.Data.MySqlClient;
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
    public partial class Register : Form
    {
        //this frm
        static Register frm;

        //main
        public Register()
        {
            InitializeComponent();
            B_P_cmb.SelectedIndex = 0;
            frm = this;
            this.BackColor = Color.LightBlue;
        }

        //Register-Function-Call-Master
        private void Register_()
        {
            //array with texboxes to check
            Control[] c = new Control[] {
                Naam_txt,
                Achternaam_txt,
                GeboorteData,
                email_txt,
                tel_txt,
                postcode_txt,
                plaats_txt,
                straat_txt,
                Huisnr_txt,
                land_txt,
                iban_txt,
                ww_txt,
                ww_H_txt,
                B_P_cmb,
                bedrijfnaam_txt
            }; //Not tussevoegsel

            //Check if fields are filled in
            if (Check._Ctrl(c, Methode.Color))
            {
                using (MySqlConnection connection = new MySqlConnection(Db.ConString))
                {
                    using (MySqlCommand command = new MySqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;
                        command.CommandText = "" +
                            "INSERT INTO `klanten`(`voornaam`, `tussenvoegsel`, `achternaam`, ` geboortedatum`, `email`, ` telefoonNr`, ` postcode`, ` straatnaam`, ` huisNr`, ` plaats`, ` land`, `bedrijf_particulier`, ` iban_nr`, `wachtwoord`) " +
                                          "VALUES (@voornaam, @tussenvoegsel, @achternaam, @geboortedatum, @email, @telefoonNr, @postcode, @straatnaam, @huisNr, @plaats, @land, @bedrijf_particulier, @iban_nr, @wachtwoord)";

                        //Convert-tiny-status-from-combobox
                        int b_p = 0;
                        if (B_P_cmb.SelectedIndex == 1)
                            b_p = 1;
                        else
                            b_p = 0;

                        //Set parameters
                        command.Parameters.AddWithValue("@klant_id", "");
                        command.Parameters.AddWithValue("@voornaam", Naam_txt.Text);
                        command.Parameters.AddWithValue("@tussenvoegsel", Tussenvg_txt.Text);
                        command.Parameters.AddWithValue("@achternaam", Achternaam_txt.Text);
                        command.Parameters.AddWithValue("@geboortedatum", GeboorteData.Text.ToString());
                        command.Parameters.AddWithValue("@email", email_txt.Text);

                        command.Parameters.AddWithValue("@telefoonNr", Convert.string_int(tel_txt.Text));
                        command.Parameters.AddWithValue("@postcode", postcode_txt.Text);
                        command.Parameters.AddWithValue("@straatnaam", straat_txt.Text);
                        command.Parameters.AddWithValue("@huisNr", Convert.string_int(Huisnr_txt.Text));

                        command.Parameters.AddWithValue("@plaats", plaats_txt.Text);
                        command.Parameters.AddWithValue("@land", land_txt.Text);
                        command.Parameters.AddWithValue("@bedrijf_particulier", b_p);
                        command.Parameters.AddWithValue("@iban_nr", Convert.string_int(iban_txt.Text));
                        command.Parameters.AddWithValue("@wachtwoord", ww_txt.Text);

                        try
                        {
                            connection.Open();
                            int recordsAffected = command.ExecuteNonQuery();
                            MessageBox.Show("customer added");
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
            else
                Log.Text = "Not all area's has been filled in!";
        }
 
        //Create-click
        private void Create_btn_Click_1(object sender, EventArgs e)
        {
            Register_();
        }

        //Bedrijf-particulier Changes
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

        //Adress-Autofill
        public static void AutoAdress()
        {
            //array with controls to check
            Control[] c = new Control[] {frm.straat_txt, frm.Huisnr_txt};

            //Check if the street name and number are filled in
            if (Check._Ctrl(c, Methode.Color))
            {
                //Request list with posible locations
                List<Address> list = Maps.PostalcodeResults(frm.straat_txt.Text, frm.Huisnr_txt.Text);

                //Check list = null
                if (list.Count != 0)
                {
                    frm.postcode_txt.Text = list.First().zipcode;
                    frm.plaats_txt.Text = list.First().place;
                    frm.land_txt.Text = list.First().country;
                }else MessageBox.Show("No results for this address");
            }
        }

        //Int-Handlers
        private void tel_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Check.Check_textbox_int(e);
        }
        private void Huisnr_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Check.Check_textbox_int(e);
        }
        private void iban_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Check.Check_textbox_int(e);
        }
        private void postcode_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Check.Check_textbox_int(e);
        }

        //Key-Press
        private void postcode_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==Keys.Enter)
            {
                AutoAdress();
            }
        }
        private void Huisnr_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AutoAdress();
            }
        }
        private void straat_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AutoAdress();
            }
        }
    }
}
