namespace DORB_Logistics
{
    partial class Klant_main
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
            this.MenuTabs = new System.Windows.Forms.TabControl();
            this.Cur_Orders_tab = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Cur_order_Container = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.New_Order_tab = new System.Windows.Forms.TabPage();
            this.NewOrder_tabs = new System.Windows.Forms.TabControl();
            this.Order_info_tab = new System.Windows.Forms.TabPage();
            this.Bezorging_tab = new System.Windows.Forms.TabPage();
            this.Payment_tab = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Pallet_Container = new System.Windows.Forms.FlowLayoutPanel();
            this.OI_inhoud = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.OI_Gewicht = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.OI_Notitie = new System.Windows.Forms.RichTextBox();
            this.OI_Hoeveelheid = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.BZ_straat = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.BZ_HuisNr = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.BZ_Postcode = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.BZ_plaats = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.BZ_land = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.BZ_ontvanger = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.BZ_Datum = new System.Windows.Forms.DateTimePicker();
            this.OI_Add_btn = new System.Windows.Forms.Button();
            this.OI_Clear_btn = new System.Windows.Forms.Button();
            this.Proceed_btn = new System.Windows.Forms.Button();
            this.BZ_Proceed_btn = new System.Windows.Forms.Button();
            this.New_order_btn = new System.Windows.Forms.Button();
            this.Current_Orders_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label21 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.PY_Bezorging = new System.Windows.Forms.Label();
            this.PY_pallets = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.PY_tataal = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.PY_Confirm_btn = new System.Windows.Forms.Button();
            this.Left_panel.SuspendLayout();
            this.MenuTabs.SuspendLayout();
            this.Cur_Orders_tab.SuspendLayout();
            this.Cur_order_Container.SuspendLayout();
            this.panel1.SuspendLayout();
            this.New_Order_tab.SuspendLayout();
            this.NewOrder_tabs.SuspendLayout();
            this.Order_info_tab.SuspendLayout();
            this.Bezorging_tab.SuspendLayout();
            this.Payment_tab.SuspendLayout();
            this.Pallet_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OI_Hoeveelheid)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.Left_panel.Controls.Add(this.New_order_btn);
            this.Left_panel.Controls.Add(this.Current_Orders_btn);
            this.Left_panel.Controls.Add(this.pictureBox1);
            this.Left_panel.Controls.Add(this.Customer_name);
            this.Left_panel.Location = new System.Drawing.Point(0, -2);
            this.Left_panel.Name = "Left_panel";
            this.Left_panel.Size = new System.Drawing.Size(266, 883);
            this.Left_panel.TabIndex = 1;
            // 
            // MenuTabs
            // 
            this.MenuTabs.Controls.Add(this.Cur_Orders_tab);
            this.MenuTabs.Controls.Add(this.New_Order_tab);
            this.MenuTabs.Location = new System.Drawing.Point(272, 1);
            this.MenuTabs.Name = "MenuTabs";
            this.MenuTabs.SelectedIndex = 0;
            this.MenuTabs.Size = new System.Drawing.Size(1301, 880);
            this.MenuTabs.TabIndex = 2;
            // 
            // Cur_Orders_tab
            // 
            this.Cur_Orders_tab.Controls.Add(this.label5);
            this.Cur_Orders_tab.Controls.Add(this.label4);
            this.Cur_Orders_tab.Controls.Add(this.Cur_order_Container);
            this.Cur_Orders_tab.Controls.Add(this.label1);
            this.Cur_Orders_tab.Location = new System.Drawing.Point(4, 25);
            this.Cur_Orders_tab.Name = "Cur_Orders_tab";
            this.Cur_Orders_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Cur_Orders_tab.Size = new System.Drawing.Size(1293, 851);
            this.Cur_Orders_tab.TabIndex = 0;
            this.Cur_Orders_tab.Text = "Cur-orders";
            this.Cur_Orders_tab.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1078, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Delivery Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Order:";
            // 
            // Cur_order_Container
            // 
            this.Cur_order_Container.BackColor = System.Drawing.Color.Gainsboro;
            this.Cur_order_Container.Controls.Add(this.panel1);
            this.Cur_order_Container.Location = new System.Drawing.Point(38, 78);
            this.Cur_order_Container.Name = "Cur_order_Container";
            this.Cur_order_Container.Size = new System.Drawing.Size(1217, 770);
            this.Cur_order_Container.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1214, 51);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1022, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "<Delivery Date>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "<Name order>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Orders";
            // 
            // New_Order_tab
            // 
            this.New_Order_tab.Controls.Add(this.label7);
            this.New_Order_tab.Controls.Add(this.NewOrder_tabs);
            this.New_Order_tab.Location = new System.Drawing.Point(4, 25);
            this.New_Order_tab.Name = "New_Order_tab";
            this.New_Order_tab.Padding = new System.Windows.Forms.Padding(3);
            this.New_Order_tab.Size = new System.Drawing.Size(1293, 851);
            this.New_Order_tab.TabIndex = 1;
            this.New_Order_tab.Text = "New-Order";
            this.New_Order_tab.UseVisualStyleBackColor = true;
            // 
            // NewOrder_tabs
            // 
            this.NewOrder_tabs.Controls.Add(this.Order_info_tab);
            this.NewOrder_tabs.Controls.Add(this.Bezorging_tab);
            this.NewOrder_tabs.Controls.Add(this.Payment_tab);
            this.NewOrder_tabs.Location = new System.Drawing.Point(38, 78);
            this.NewOrder_tabs.Name = "NewOrder_tabs";
            this.NewOrder_tabs.SelectedIndex = 0;
            this.NewOrder_tabs.Size = new System.Drawing.Size(1217, 770);
            this.NewOrder_tabs.TabIndex = 0;
            this.NewOrder_tabs.SelectedIndexChanged += new System.EventHandler(this.NewOrder_tabs_SelectedIndexChanged);
            // 
            // Order_info_tab
            // 
            this.Order_info_tab.Controls.Add(this.OI_Add_btn);
            this.Order_info_tab.Controls.Add(this.OI_Clear_btn);
            this.Order_info_tab.Controls.Add(this.OI_Hoeveelheid);
            this.Order_info_tab.Controls.Add(this.OI_Notitie);
            this.Order_info_tab.Controls.Add(this.label11);
            this.Order_info_tab.Controls.Add(this.label10);
            this.Order_info_tab.Controls.Add(this.OI_Gewicht);
            this.Order_info_tab.Controls.Add(this.label9);
            this.Order_info_tab.Controls.Add(this.OI_inhoud);
            this.Order_info_tab.Controls.Add(this.label8);
            this.Order_info_tab.Controls.Add(this.Proceed_btn);
            this.Order_info_tab.Controls.Add(this.Pallet_Container);
            this.Order_info_tab.Controls.Add(this.label6);
            this.Order_info_tab.Location = new System.Drawing.Point(4, 25);
            this.Order_info_tab.Name = "Order_info_tab";
            this.Order_info_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Order_info_tab.Size = new System.Drawing.Size(1209, 741);
            this.Order_info_tab.TabIndex = 0;
            this.Order_info_tab.Text = "Order-info";
            this.Order_info_tab.UseVisualStyleBackColor = true;
            // 
            // Bezorging_tab
            // 
            this.Bezorging_tab.Controls.Add(this.BZ_Proceed_btn);
            this.Bezorging_tab.Controls.Add(this.BZ_Datum);
            this.Bezorging_tab.Controls.Add(this.label20);
            this.Bezorging_tab.Controls.Add(this.BZ_ontvanger);
            this.Bezorging_tab.Controls.Add(this.label19);
            this.Bezorging_tab.Controls.Add(this.BZ_land);
            this.Bezorging_tab.Controls.Add(this.label18);
            this.Bezorging_tab.Controls.Add(this.BZ_plaats);
            this.Bezorging_tab.Controls.Add(this.label17);
            this.Bezorging_tab.Controls.Add(this.BZ_Postcode);
            this.Bezorging_tab.Controls.Add(this.label16);
            this.Bezorging_tab.Controls.Add(this.BZ_HuisNr);
            this.Bezorging_tab.Controls.Add(this.label15);
            this.Bezorging_tab.Controls.Add(this.label14);
            this.Bezorging_tab.Controls.Add(this.BZ_straat);
            this.Bezorging_tab.Controls.Add(this.label13);
            this.Bezorging_tab.Location = new System.Drawing.Point(4, 25);
            this.Bezorging_tab.Name = "Bezorging_tab";
            this.Bezorging_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Bezorging_tab.Size = new System.Drawing.Size(1209, 741);
            this.Bezorging_tab.TabIndex = 1;
            this.Bezorging_tab.Text = "Bezorging";
            this.Bezorging_tab.UseVisualStyleBackColor = true;
            // 
            // Payment_tab
            // 
            this.Payment_tab.Controls.Add(this.PY_Confirm_btn);
            this.Payment_tab.Controls.Add(this.PY_tataal);
            this.Payment_tab.Controls.Add(this.label27);
            this.Payment_tab.Controls.Add(this.PY_pallets);
            this.Payment_tab.Controls.Add(this.label25);
            this.Payment_tab.Controls.Add(this.PY_Bezorging);
            this.Payment_tab.Controls.Add(this.label22);
            this.Payment_tab.Controls.Add(this.panel3);
            this.Payment_tab.Controls.Add(this.label21);
            this.Payment_tab.Location = new System.Drawing.Point(4, 25);
            this.Payment_tab.Name = "Payment_tab";
            this.Payment_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Payment_tab.Size = new System.Drawing.Size(1209, 741);
            this.Payment_tab.TabIndex = 2;
            this.Payment_tab.Text = "Payment";
            this.Payment_tab.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Order-Info";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "New-Order";
            // 
            // Pallet_Container
            // 
            this.Pallet_Container.BackColor = System.Drawing.Color.LightGray;
            this.Pallet_Container.Controls.Add(this.panel2);
            this.Pallet_Container.Location = new System.Drawing.Point(967, 67);
            this.Pallet_Container.Name = "Pallet_Container";
            this.Pallet_Container.Size = new System.Drawing.Size(242, 503);
            this.Pallet_Container.TabIndex = 2;
            // 
            // OI_inhoud
            // 
            this.OI_inhoud.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OI_inhoud.Location = new System.Drawing.Point(367, 171);
            this.OI_inhoud.Name = "OI_inhoud";
            this.OI_inhoud.Size = new System.Drawing.Size(245, 26);
            this.OI_inhoud.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(283, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 20);
            this.label8.TabIndex = 36;
            this.label8.Text = "Inhoud:";
            // 
            // OI_Gewicht
            // 
            this.OI_Gewicht.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OI_Gewicht.Location = new System.Drawing.Point(367, 204);
            this.OI_Gewicht.Name = "OI_Gewicht";
            this.OI_Gewicht.Size = new System.Drawing.Size(245, 26);
            this.OI_Gewicht.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(283, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 20);
            this.label9.TabIndex = 38;
            this.label9.Text = "Gewicht:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(283, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 20);
            this.label10.TabIndex = 40;
            this.label10.Text = "Hoeveelheid:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(283, 307);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 20);
            this.label11.TabIndex = 42;
            this.label11.Text = "Notitie:";
            // 
            // OI_Notitie
            // 
            this.OI_Notitie.Location = new System.Drawing.Point(287, 330);
            this.OI_Notitie.Name = "OI_Notitie";
            this.OI_Notitie.Size = new System.Drawing.Size(325, 100);
            this.OI_Notitie.TabIndex = 43;
            this.OI_Notitie.Text = "";
            // 
            // OI_Hoeveelheid
            // 
            this.OI_Hoeveelheid.Location = new System.Drawing.Point(395, 243);
            this.OI_Hoeveelheid.Name = "OI_Hoeveelheid";
            this.OI_Hoeveelheid.Size = new System.Drawing.Size(217, 22);
            this.OI_Hoeveelheid.TabIndex = 44;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.numericUpDown2);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 33);
            this.panel2.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 20);
            this.label12.TabIndex = 47;
            this.label12.Text = "<Inhoud>";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(173, 6);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(48, 22);
            this.numericUpDown2.TabIndex = 47;
            // 
            // BZ_straat
            // 
            this.BZ_straat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BZ_straat.Location = new System.Drawing.Point(501, 161);
            this.BZ_straat.Name = "BZ_straat";
            this.BZ_straat.Size = new System.Drawing.Size(220, 26);
            this.BZ_straat.TabIndex = 39;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(417, 164);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 20);
            this.label13.TabIndex = 38;
            this.label13.Text = "Straat:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(18, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(138, 25);
            this.label14.TabIndex = 40;
            this.label14.Text = "Bezorging-info";
            // 
            // BZ_HuisNr
            // 
            this.BZ_HuisNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BZ_HuisNr.Location = new System.Drawing.Point(501, 195);
            this.BZ_HuisNr.Name = "BZ_HuisNr";
            this.BZ_HuisNr.Size = new System.Drawing.Size(220, 26);
            this.BZ_HuisNr.TabIndex = 42;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(417, 198);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 20);
            this.label15.TabIndex = 41;
            this.label15.Text = "Huis nr:";
            // 
            // BZ_Postcode
            // 
            this.BZ_Postcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BZ_Postcode.Location = new System.Drawing.Point(501, 230);
            this.BZ_Postcode.Name = "BZ_Postcode";
            this.BZ_Postcode.Size = new System.Drawing.Size(220, 26);
            this.BZ_Postcode.TabIndex = 44;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(417, 233);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 20);
            this.label16.TabIndex = 43;
            this.label16.Text = "Postcode:";
            // 
            // BZ_plaats
            // 
            this.BZ_plaats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BZ_plaats.Location = new System.Drawing.Point(501, 263);
            this.BZ_plaats.Name = "BZ_plaats";
            this.BZ_plaats.Size = new System.Drawing.Size(220, 26);
            this.BZ_plaats.TabIndex = 46;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(417, 266);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 20);
            this.label17.TabIndex = 45;
            this.label17.Text = "Plaats:";
            // 
            // BZ_land
            // 
            this.BZ_land.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BZ_land.Location = new System.Drawing.Point(501, 296);
            this.BZ_land.Name = "BZ_land";
            this.BZ_land.Size = new System.Drawing.Size(220, 26);
            this.BZ_land.TabIndex = 48;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(417, 299);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 20);
            this.label18.TabIndex = 47;
            this.label18.Text = "Land:";
            // 
            // BZ_ontvanger
            // 
            this.BZ_ontvanger.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BZ_ontvanger.Location = new System.Drawing.Point(557, 382);
            this.BZ_ontvanger.Name = "BZ_ontvanger";
            this.BZ_ontvanger.Size = new System.Drawing.Size(164, 26);
            this.BZ_ontvanger.TabIndex = 50;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(417, 385);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(142, 20);
            this.label19.TabIndex = 49;
            this.label19.Text = "Ontvanger/bedrijf:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(417, 418);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(154, 20);
            this.label20.TabIndex = 51;
            this.label20.Text = "Bezorgings Datum:";
            // 
            // BZ_Datum
            // 
            this.BZ_Datum.Location = new System.Drawing.Point(577, 418);
            this.BZ_Datum.Name = "BZ_Datum";
            this.BZ_Datum.Size = new System.Drawing.Size(144, 22);
            this.BZ_Datum.TabIndex = 53;
            // 
            // OI_Add_btn
            // 
            this.OI_Add_btn.BackgroundImage = global::DORB_Logistics.Properties.Resources.Next;
            this.OI_Add_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OI_Add_btn.Location = new System.Drawing.Point(471, 436);
            this.OI_Add_btn.Name = "OI_Add_btn";
            this.OI_Add_btn.Size = new System.Drawing.Size(141, 43);
            this.OI_Add_btn.TabIndex = 46;
            this.OI_Add_btn.Text = "Add";
            this.OI_Add_btn.UseVisualStyleBackColor = true;
            // 
            // OI_Clear_btn
            // 
            this.OI_Clear_btn.BackgroundImage = global::DORB_Logistics.Properties.Resources.Next;
            this.OI_Clear_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OI_Clear_btn.Location = new System.Drawing.Point(287, 436);
            this.OI_Clear_btn.Name = "OI_Clear_btn";
            this.OI_Clear_btn.Size = new System.Drawing.Size(141, 43);
            this.OI_Clear_btn.TabIndex = 45;
            this.OI_Clear_btn.Text = "Clear";
            this.OI_Clear_btn.UseVisualStyleBackColor = true;
            // 
            // Proceed_btn
            // 
            this.Proceed_btn.BackgroundImage = global::DORB_Logistics.Properties.Resources.Next;
            this.Proceed_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Proceed_btn.Location = new System.Drawing.Point(967, 567);
            this.Proceed_btn.Name = "Proceed_btn";
            this.Proceed_btn.Size = new System.Drawing.Size(242, 43);
            this.Proceed_btn.TabIndex = 5;
            this.Proceed_btn.Text = "Proceed";
            this.Proceed_btn.UseVisualStyleBackColor = true;
            // 
            // BZ_Proceed_btn
            // 
            this.BZ_Proceed_btn.BackgroundImage = global::DORB_Logistics.Properties.Resources.Checkout_Card;
            this.BZ_Proceed_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BZ_Proceed_btn.Location = new System.Drawing.Point(467, 462);
            this.BZ_Proceed_btn.Name = "BZ_Proceed_btn";
            this.BZ_Proceed_btn.Size = new System.Drawing.Size(232, 43);
            this.BZ_Proceed_btn.TabIndex = 3;
            this.BZ_Proceed_btn.Text = "Proceed checkout";
            this.BZ_Proceed_btn.UseVisualStyleBackColor = true;
            // 
            // New_order_btn
            // 
            this.New_order_btn.BackgroundImage = global::DORB_Logistics.Properties.Resources.AddCard;
            this.New_order_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.New_order_btn.Location = new System.Drawing.Point(12, 221);
            this.New_order_btn.Name = "New_order_btn";
            this.New_order_btn.Size = new System.Drawing.Size(232, 43);
            this.New_order_btn.TabIndex = 2;
            this.New_order_btn.Text = "New Order";
            this.New_order_btn.UseVisualStyleBackColor = true;
            this.New_order_btn.Click += new System.EventHandler(this.New_order_btn_Click);
            // 
            // Current_Orders_btn
            // 
            this.Current_Orders_btn.BackgroundImage = global::DORB_Logistics.Properties.Resources.Card;
            this.Current_Orders_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Current_Orders_btn.Location = new System.Drawing.Point(12, 172);
            this.Current_Orders_btn.Name = "Current_Orders_btn";
            this.Current_Orders_btn.Size = new System.Drawing.Size(232, 43);
            this.Current_Orders_btn.TabIndex = 1;
            this.Current_Orders_btn.Text = "Current Orders";
            this.Current_Orders_btn.UseVisualStyleBackColor = true;
            this.Current_Orders_btn.Click += new System.EventHandler(this.Current_Orders_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DORB_Logistics.Properties.Resources.User;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(18, 14);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(180, 25);
            this.label21.TabIndex = 41;
            this.label21.Text = "Payment-Checkout";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Location = new System.Drawing.Point(361, 388);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(455, 5);
            this.panel3.TabIndex = 42;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(357, 352);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(85, 20);
            this.label22.TabIndex = 43;
            this.label22.Text = "Bezorging";
            // 
            // PY_Bezorging
            // 
            this.PY_Bezorging.AutoSize = true;
            this.PY_Bezorging.Enabled = false;
            this.PY_Bezorging.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PY_Bezorging.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.PY_Bezorging.Location = new System.Drawing.Point(493, 352);
            this.PY_Bezorging.Name = "PY_Bezorging";
            this.PY_Bezorging.Size = new System.Drawing.Size(111, 20);
            this.PY_Bezorging.TabIndex = 44;
            this.PY_Bezorging.Text = "<bezorgings>";
            // 
            // PY_pallets
            // 
            this.PY_pallets.AutoSize = true;
            this.PY_pallets.Enabled = false;
            this.PY_pallets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PY_pallets.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.PY_pallets.Location = new System.Drawing.Point(493, 332);
            this.PY_pallets.Name = "PY_pallets";
            this.PY_pallets.Size = new System.Drawing.Size(115, 20);
            this.PY_pallets.TabIndex = 46;
            this.PY_pallets.Text = "<total pallets>";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(357, 332);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(111, 20);
            this.label25.TabIndex = 45;
            this.label25.Text = "Pallets totaal:";
            // 
            // PY_tataal
            // 
            this.PY_tataal.AutoSize = true;
            this.PY_tataal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PY_tataal.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.PY_tataal.Location = new System.Drawing.Point(493, 407);
            this.PY_tataal.Name = "PY_tataal";
            this.PY_tataal.Size = new System.Drawing.Size(171, 20);
            this.PY_tataal.TabIndex = 48;
            this.PY_tataal.Text = "<bezorging + pallets>";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(357, 407);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(60, 20);
            this.label27.TabIndex = 47;
            this.label27.Text = "Totaal:";
            // 
            // PY_Confirm_btn
            // 
            this.PY_Confirm_btn.BackgroundImage = global::DORB_Logistics.Properties.Resources.Confirm;
            this.PY_Confirm_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PY_Confirm_btn.Location = new System.Drawing.Point(361, 474);
            this.PY_Confirm_btn.Name = "PY_Confirm_btn";
            this.PY_Confirm_btn.Size = new System.Drawing.Size(232, 43);
            this.PY_Confirm_btn.TabIndex = 3;
            this.PY_Confirm_btn.Text = "Confirm";
            this.PY_Confirm_btn.UseVisualStyleBackColor = true;
            // 
            // Klant_main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1573, 880);
            this.Controls.Add(this.MenuTabs);
            this.Controls.Add(this.Left_panel);
            this.Name = "Klant_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Klant_main";
            this.Left_panel.ResumeLayout(false);
            this.Left_panel.PerformLayout();
            this.MenuTabs.ResumeLayout(false);
            this.Cur_Orders_tab.ResumeLayout(false);
            this.Cur_Orders_tab.PerformLayout();
            this.Cur_order_Container.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.New_Order_tab.ResumeLayout(false);
            this.New_Order_tab.PerformLayout();
            this.NewOrder_tabs.ResumeLayout(false);
            this.Order_info_tab.ResumeLayout(false);
            this.Order_info_tab.PerformLayout();
            this.Bezorging_tab.ResumeLayout(false);
            this.Bezorging_tab.PerformLayout();
            this.Payment_tab.ResumeLayout(false);
            this.Payment_tab.PerformLayout();
            this.Pallet_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OI_Hoeveelheid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Customer_name;
        private System.Windows.Forms.Panel Left_panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Current_Orders_btn;
        private System.Windows.Forms.Button New_order_btn;
        private System.Windows.Forms.TabControl MenuTabs;
        private System.Windows.Forms.TabPage Cur_Orders_tab;
        private System.Windows.Forms.TabPage New_Order_tab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel Cur_order_Container;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl NewOrder_tabs;
        private System.Windows.Forms.TabPage Order_info_tab;
        private System.Windows.Forms.TabPage Bezorging_tab;
        private System.Windows.Forms.TabPage Payment_tab;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Proceed_btn;
        private System.Windows.Forms.FlowLayoutPanel Pallet_Container;
        private System.Windows.Forms.RichTextBox OI_Notitie;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox OI_Gewicht;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox OI_inhoud;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown OI_Hoeveelheid;
        private System.Windows.Forms.Button OI_Add_btn;
        private System.Windows.Forms.Button OI_Clear_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox BZ_straat;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox BZ_land;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox BZ_plaats;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox BZ_Postcode;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox BZ_HuisNr;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker BZ_Datum;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox BZ_ontvanger;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button BZ_Proceed_btn;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label PY_tataal;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label PY_pallets;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label PY_Bezorging;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button PY_Confirm_btn;
    }
}