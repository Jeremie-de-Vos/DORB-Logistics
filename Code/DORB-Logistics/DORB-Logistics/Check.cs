using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DORB_Logistics
{
    class Check
    {
        //Textbox state
        internal static void TextBoxState(TextBox[] textboxes, Methode methode, Form frm)
        {
            /*/Color
            foreach (TextBox t in textboxes)
                if(t.Text == "warning")
                    SetState_color(t, State.warning);
                else if (t.Text == string.Empty)
                    SetState_color(t, State.empty);
                else
                    SetState_color(t, State.filled);*/
           
            
            //new tst
            foreach (TextBox t in textboxes)
            {
                //Warning
                if (t.Text == "warning" || methode == Methode.Both) { SetState_color(t, State.warning); SetState_icon(t, State.warning, frm); }         //Both
                else if (t.Text == "warning" || methode == Methode.Color) { SetState_color(t, State.warning); }                                         //Color
                else if (t.Text == "warning" || methode == Methode.Icon) { SetState_icon(t, State.warning, frm); }                                      //Icon

                //Empty
                else if (t.Text == string.Empty || methode == Methode.Both) { SetState_color(t, State.empty); SetState_icon(t, State.empty, frm); }      //Both
                else if (t.Text == string.Empty || methode == Methode.Color) { SetState_color(t, State.empty); }                                         //Color
                else if (t.Text == string.Empty || methode == Methode.Icon) { SetState_icon(t, State.empty, frm); }                                      //Icon

                //Filled
                else if (t.Text != string.Empty || methode == Methode.Both) { SetState_color(t, State.filled); SetState_icon(t, State.filled, frm); }     //Both
                else if (t.Text != string.Empty || methode == Methode.Color) { SetState_color(t, State.filled); }                                         //Color
                else if (t.Text != string.Empty || methode == Methode.Icon) { SetState_icon(t, State.filled, frm); }                                      //Icon
            }
        }
        private static void SetState_icon(TextBox t, State s, Form frm)
        {
            PictureBox p = null;

            //Check if exist
            foreach (Control x in frm.Controls)
                if (x is PictureBox)
                    if (x.Name == t.Name + "_icon")
                        p = x as PictureBox;
                    else { }
                else
                {
                    //Create image
                    p = new PictureBox();
                    frm.Controls.Add(p);
                    p.Size = new Size(t.Height, t.Height);
                    p.Location = new Point(t.Location.X + t.Width + 2, t.Location.Y);
                    p.Name = t.Name + "_icon";
                }

            //set image ICON based on state
            if (s == State.empty)
            { p.Image = Properties.Resources.email; }
            else if (s == State.warning)
            { p.Image = Properties.Resources.cross; }
            else if (s == State.filled)
            { p.Image = Properties.Resources.cross; }
        }
        private static void SetState_color(TextBox t, State s)
        {
            if(s == State.empty)
                t.BackColor = Color.Orange;
            else if (s == State.warning)
                t.BackColor = Color.Red;
            else if (s == State.filled)
                t.BackColor = Color.LightGreen;
        }
    }
    internal enum State
    {
        empty,
        warning,
        filled
    }
    internal enum Methode
    {
        Color,
        Icon,
        Both
    }
}
