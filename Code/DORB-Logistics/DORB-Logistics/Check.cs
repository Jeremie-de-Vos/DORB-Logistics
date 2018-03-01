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
        //Check-textbox-input-ints
        internal static void Check_textbox_int(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }


        //=======================================================================================
        static Color disabled = Color.White;
        static Color error = Color.Red;
        static Color empty = Color.Orange;
        static Color filled = Color.LightGreen;

        //Decision maker
        internal static bool _Ctrl(Control[] con, Methode methode)
        {
            //notfilled is that not everything has been filled yet
            bool NotFilled = false;

            //strart loop foreach control
            foreach (Control c in con){

                //determ what type of control it is
                if (c.Enabled){

                    if (c is TextBox){
                        if (!TextBoxState(c as TextBox, methode))//if not filled
                            NotFilled = true;}

                    else if (c is RichTextBox){
                        if (!RichTextBoxState(c as RichTextBox, methode))
                            NotFilled = true;}

                    else if (c is ComboBox){
                        if (!ComboBoxState(c as ComboBox, methode))
                            NotFilled = true;}

                    else if (c is PictureBox){
                        if (!PictureBoxState(c as PictureBox, methode))
                            NotFilled = true;}

                    else if (c is Label){
                        if (!LabelState(c as Label, methode))
                            NotFilled = true;}

                    //if nothing above is returned
                    else  MessageBox.Show("Unknown Control! Or not not added yet :P");
                }
                //if control is diabled set color state to white
                else c.BackColor = Color.White;
            }

            //check if a field was not filled
            if (NotFilled)
                return false;
            else
                return true;
        }

        //Controls State checkers
        private static bool TextBoxState(TextBox t, Methode methode)
        {
            //variable
            bool filled = false;
            State state;

            //Check what the current state is
            if (t.Text == string.Empty)
            { state = State.empty; }
            else if (t.Text == "error")
            { state = State.error; }
            else
            { state = State.filled; filled = true; }

            //Check what the methode is and make the action that belongs to it
            if (methode == Methode.Color)
                SetState_color(t, state);

            //check if a field was not filled
            return filled;
        }
        private static bool LabelState(Label t, Methode methode)
        {
            //variable
            bool Filled = false;
            State state;

            //Check what the current state is
            if (t.Text == string.Empty)
            { state = State.empty; }
            else if (t.Text == "error")
            { state = State.error; }
            else
            { state = State.filled; Filled = true; }

            //Check what the methode is and make the action that belongs to it
            if (methode == Methode.Color)
                SetState_color(t, state);

            //check if a field was not filled
            return Filled;
        }
        private static bool RichTextBoxState(RichTextBox t, Methode methode)
        {
            //variable
            bool Filled = false;
            State state;

            //Check what the current state is
            if (t.Text == string.Empty)
            { state = State.empty; }
            else if (t.Text == "error")
            { state = State.error; }
            else
            { state = State.filled; Filled = true; }

            //Check what the methode is and make the action that belongs to it
            if (methode == Methode.Color)
                SetState_color(t, state);

            //check if a field was not filled
            return Filled;
        }
        private static bool ComboBoxState(ComboBox t, Methode methode)
        {
            //variable
            bool Filled = false;
            State state;

            //Check what the current state is
            if (t.SelectedIndex == 0)
            { state = State.empty; }
            else
            { state = State.filled; Filled = true; }

            //Check what the methode is and make the action that belongs to it
            if (methode == Methode.Color)
                SetState_color(t, state);

            //check if a field was not filled
            return Filled;
        }
        private static bool PictureBoxState(PictureBox t, Methode methode)
        {
            //variable
            bool Filled = false;
            State state;

            //Check what the current state is
            if (t.Image == null)
            { state = State.empty; }
            else
            { state = State.filled; Filled = true; }

            //Check what the methode is and make the action that belongs to it
            if (methode == Methode.Color)
                SetState_color(t, state);

            //check if a field was not filled
            return Filled;
        }

        //Set visuals
        private static void SetState_color(Control t, State s)
        {
            if (s == State.empty)
                t.BackColor = empty;
            else if (s == State.error)
                t.BackColor = error;
            else if (s == State.filled)
                t.BackColor = filled;
        }
    }
}
    internal enum State
    {
        empty,
        error,
        filled
    }
    internal enum Methode
    {
        Color
    }
