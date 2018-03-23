namespace DORB_Logistics
{
    partial class Planners
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Customer_name = new System.Windows.Forms.Label();
            this.Left_panel = new System.Windows.Forms.Panel();
            this.Planned_btn = new System.Windows.Forms.Button();
            this.Unplanned_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuTabs = new System.Windows.Forms.TabControl();
            this.Cur_Orders_tab = new System.Windows.Forms.TabPage();
            this.Container_unplanned = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.New_Order_tab = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.plan_order_tab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Chauffeur_cmb = new System.Windows.Forms.ComboBox();
            this.Vrachtwagen_cmb = new System.Windows.Forms.ComboBox();
            this.Datepicker = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.RP_straat = new System.Windows.Forms.Label();
            this.RP_huisnr = new System.Windows.Forms.Label();
            this.RP_postcode = new System.Windows.Forms.Label();
            this.RP_plaats = new System.Windows.Forms.Label();
            this.RP_land = new System.Windows.Forms.Label();
            this.RP_ontvanger = new System.Windows.Forms.Label();
            this.Save_btn = new System.Windows.Forms.Button();
            this.Left_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MenuTabs.SuspendLayout();
            this.Cur_Orders_tab.SuspendLayout();
            this.New_Order_tab.SuspendLayout();
            this.plan_order_tab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Customer_name
            // 
            this.Customer_name.AutoSize = true;
            this.Customer_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_name.Location = new System.Drawing.Point(91, 28);
            this.Customer_name.Name = "Customer_name";
            this.Customer_name.Size = new System.Drawing.Size(119, 20);
            this.Customer_name.TabIndex = 0;
            this.Customer_name.Text = "name de name";
            // 
            // Left_panel
            // 
            this.Left_panel.BackColor = System.Drawing.Color.Gray;
            this.Left_panel.Controls.Add(this.Planned_btn);
            this.Left_panel.Controls.Add(this.Unplanned_btn);
            this.Left_panel.Controls.Add(this.pictureBox1);
            this.Left_panel.Controls.Add(this.Customer_name);
            this.Left_panel.Location = new System.Drawing.Point(0, -2);
            this.Left_panel.Name = "Left_panel";
            this.Left_panel.Size = new System.Drawing.Size(266, 883);
            this.Left_panel.TabIndex = 1;
            // 
            // Planned_btn
            // 
            this.Planned_btn.BackgroundImage = global::DORB_Logistics.Properties.Resources.Planned;
            this.Planned_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Planned_btn.Location = new System.Drawing.Point(12, 221);
            this.Planned_btn.Name = "Planned_btn";
            this.Planned_btn.Size = new System.Drawing.Size(232, 43);
            this.Planned_btn.TabIndex = 2;
            this.Planned_btn.Text = "Planned";
            this.Planned_btn.UseVisualStyleBackColor = true;
            this.Planned_btn.Click += new System.EventHandler(this.Planned_btn_Click);
            // 
            // Unplanned_btn
            // 
            this.Unplanned_btn.BackgroundImage = global::DORB_Logistics.Properties.Resources.Unplanned;
            this.Unplanned_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Unplanned_btn.Location = new System.Drawing.Point(12, 172);
            this.Unplanned_btn.Name = "Unplanned_btn";
            this.Unplanned_btn.Size = new System.Drawing.Size(232, 43);
            this.Unplanned_btn.TabIndex = 1;
            this.Unplanned_btn.Text = "Unplanned";
            this.Unplanned_btn.UseVisualStyleBackColor = true;
            this.Unplanned_btn.Click += new System.EventHandler(this.Unplanned_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DORB_Logistics.Properties.Resources.User2;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MenuTabs
            // 
            this.MenuTabs.Controls.Add(this.Cur_Orders_tab);
            this.MenuTabs.Controls.Add(this.New_Order_tab);
            this.MenuTabs.Controls.Add(this.plan_order_tab);
            this.MenuTabs.Location = new System.Drawing.Point(272, 1);
            this.MenuTabs.Name = "MenuTabs";
            this.MenuTabs.SelectedIndex = 0;
            this.MenuTabs.Size = new System.Drawing.Size(1301, 880);
            this.MenuTabs.TabIndex = 2;
            // 
            // Cur_Orders_tab
            // 
            this.Cur_Orders_tab.Controls.Add(this.Container_unplanned);
            this.Cur_Orders_tab.Controls.Add(this.label1);
            this.Cur_Orders_tab.Location = new System.Drawing.Point(4, 25);
            this.Cur_Orders_tab.Name = "Cur_Orders_tab";
            this.Cur_Orders_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Cur_Orders_tab.Size = new System.Drawing.Size(1293, 851);
            this.Cur_Orders_tab.TabIndex = 0;
            this.Cur_Orders_tab.Text = "Unplanned";
            this.Cur_Orders_tab.UseVisualStyleBackColor = true;
            // 
            // Container_unplanned
            // 
            this.Container_unplanned.BackColor = System.Drawing.Color.Gainsboro;
            this.Container_unplanned.Location = new System.Drawing.Point(38, 72);
            this.Container_unplanned.Name = "Container_unplanned";
            this.Container_unplanned.Size = new System.Drawing.Size(1217, 770);
            this.Container_unplanned.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unplanned";
            // 
            // New_Order_tab
            // 
            this.New_Order_tab.Controls.Add(this.flowLayoutPanel1);
            this.New_Order_tab.Controls.Add(this.label7);
            this.New_Order_tab.Location = new System.Drawing.Point(4, 25);
            this.New_Order_tab.Name = "New_Order_tab";
            this.New_Order_tab.Padding = new System.Windows.Forms.Padding(3);
            this.New_Order_tab.Size = new System.Drawing.Size(1293, 851);
            this.New_Order_tab.TabIndex = 1;
            this.New_Order_tab.Text = "Planned";
            this.New_Order_tab.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Gainsboro;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(38, 72);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1217, 770);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Planned";
            // 
            // plan_order_tab
            // 
            this.plan_order_tab.Controls.Add(this.label2);
            this.plan_order_tab.Controls.Add(this.panel1);
            this.plan_order_tab.Location = new System.Drawing.Point(4, 25);
            this.plan_order_tab.Name = "plan_order_tab";
            this.plan_order_tab.Padding = new System.Windows.Forms.Padding(3);
            this.plan_order_tab.Size = new System.Drawing.Size(1293, 851);
            this.plan_order_tab.TabIndex = 2;
            this.plan_order_tab.Text = "plan order";
            this.plan_order_tab.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.Save_btn);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Datepicker);
            this.panel1.Controls.Add(this.Vrachtwagen_cmb);
            this.panel1.Controls.Add(this.Chauffeur_cmb);
            this.panel1.Location = new System.Drawing.Point(311, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 378);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rit Plannen";
            // 
            // Chauffeur_cmb
            // 
            this.Chauffeur_cmb.FormattingEnabled = true;
            this.Chauffeur_cmb.Location = new System.Drawing.Point(109, 69);
            this.Chauffeur_cmb.Name = "Chauffeur_cmb";
            this.Chauffeur_cmb.Size = new System.Drawing.Size(200, 24);
            this.Chauffeur_cmb.TabIndex = 4;
            // 
            // Vrachtwagen_cmb
            // 
            this.Vrachtwagen_cmb.FormattingEnabled = true;
            this.Vrachtwagen_cmb.Location = new System.Drawing.Point(109, 99);
            this.Vrachtwagen_cmb.Name = "Vrachtwagen_cmb";
            this.Vrachtwagen_cmb.Size = new System.Drawing.Size(200, 24);
            this.Vrachtwagen_cmb.TabIndex = 5;
            // 
            // Datepicker
            // 
            this.Datepicker.Location = new System.Drawing.Point(109, 129);
            this.Datepicker.Name = "Datepicker";
            this.Datepicker.Size = new System.Drawing.Size(200, 22);
            this.Datepicker.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.RP_ontvanger);
            this.panel2.Controls.Add(this.RP_land);
            this.panel2.Controls.Add(this.RP_plaats);
            this.panel2.Controls.Add(this.RP_postcode);
            this.panel2.Controls.Add(this.RP_huisnr);
            this.panel2.Controls.Add(this.RP_straat);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Location = new System.Drawing.Point(465, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 378);
            this.panel2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Chauffeur:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Vrachtwagen:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Date:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(13, 147);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(122, 17);
            this.label19.TabIndex = 55;
            this.label19.Text = "Ontvanger/bedrijf:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(13, 106);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 17);
            this.label18.TabIndex = 54;
            this.label18.Text = "Land:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(13, 89);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 17);
            this.label17.TabIndex = 53;
            this.label17.Text = "Plaats:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(13, 72);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 17);
            this.label16.TabIndex = 52;
            this.label16.Text = "Postcode:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(13, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 17);
            this.label15.TabIndex = 51;
            this.label15.Text = "Huis nr:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(13, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 17);
            this.label13.TabIndex = 50;
            this.label13.Text = "Straat:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 18);
            this.label6.TabIndex = 56;
            this.label6.Text = "Bezorgings Info:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 18);
            this.label8.TabIndex = 57;
            this.label8.Text = "Rit Info:";
            // 
            // RP_straat
            // 
            this.RP_straat.AutoSize = true;
            this.RP_straat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RP_straat.Location = new System.Drawing.Point(85, 38);
            this.RP_straat.Name = "RP_straat";
            this.RP_straat.Size = new System.Drawing.Size(31, 17);
            this.RP_straat.TabIndex = 57;
            this.RP_straat.Text = "info";
            // 
            // RP_huisnr
            // 
            this.RP_huisnr.AutoSize = true;
            this.RP_huisnr.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RP_huisnr.Location = new System.Drawing.Point(85, 55);
            this.RP_huisnr.Name = "RP_huisnr";
            this.RP_huisnr.Size = new System.Drawing.Size(31, 17);
            this.RP_huisnr.TabIndex = 58;
            this.RP_huisnr.Text = "info";
            // 
            // RP_postcode
            // 
            this.RP_postcode.AutoSize = true;
            this.RP_postcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RP_postcode.Location = new System.Drawing.Point(85, 72);
            this.RP_postcode.Name = "RP_postcode";
            this.RP_postcode.Size = new System.Drawing.Size(31, 17);
            this.RP_postcode.TabIndex = 59;
            this.RP_postcode.Text = "info";
            // 
            // RP_plaats
            // 
            this.RP_plaats.AutoSize = true;
            this.RP_plaats.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RP_plaats.Location = new System.Drawing.Point(85, 89);
            this.RP_plaats.Name = "RP_plaats";
            this.RP_plaats.Size = new System.Drawing.Size(31, 17);
            this.RP_plaats.TabIndex = 60;
            this.RP_plaats.Text = "info";
            // 
            // RP_land
            // 
            this.RP_land.AutoSize = true;
            this.RP_land.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RP_land.Location = new System.Drawing.Point(85, 106);
            this.RP_land.Name = "RP_land";
            this.RP_land.Size = new System.Drawing.Size(31, 17);
            this.RP_land.TabIndex = 61;
            this.RP_land.Text = "info";
            // 
            // RP_ontvanger
            // 
            this.RP_ontvanger.AutoSize = true;
            this.RP_ontvanger.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RP_ontvanger.Location = new System.Drawing.Point(13, 164);
            this.RP_ontvanger.Name = "RP_ontvanger";
            this.RP_ontvanger.Size = new System.Drawing.Size(31, 17);
            this.RP_ontvanger.TabIndex = 62;
            this.RP_ontvanger.Text = "Info";
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(185, 322);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(107, 39);
            this.Save_btn.TabIndex = 58;
            this.Save_btn.Text = "Save";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Planners
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1573, 880);
            this.Controls.Add(this.MenuTabs);
            this.Controls.Add(this.Left_panel);
            this.Name = "Planners";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Klant_main";
            this.Left_panel.ResumeLayout(false);
            this.Left_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MenuTabs.ResumeLayout(false);
            this.Cur_Orders_tab.ResumeLayout(false);
            this.Cur_Orders_tab.PerformLayout();
            this.New_Order_tab.ResumeLayout(false);
            this.New_Order_tab.PerformLayout();
            this.plan_order_tab.ResumeLayout(false);
            this.plan_order_tab.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Customer_name;
        private System.Windows.Forms.Panel Left_panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Unplanned_btn;
        private System.Windows.Forms.Button Planned_btn;
        private System.Windows.Forms.TabControl MenuTabs;
        private System.Windows.Forms.TabPage Cur_Orders_tab;
        private System.Windows.Forms.TabPage New_Order_tab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FlowLayoutPanel Container_unplanned;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabPage plan_order_tab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Chauffeur_cmb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker Datepicker;
        private System.Windows.Forms.ComboBox Vrachtwagen_cmb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label RP_ontvanger;
        private System.Windows.Forms.Label RP_land;
        private System.Windows.Forms.Label RP_plaats;
        private System.Windows.Forms.Label RP_postcode;
        private System.Windows.Forms.Label RP_huisnr;
        private System.Windows.Forms.Label RP_straat;
        private System.Windows.Forms.Button Save_btn;
    }
}