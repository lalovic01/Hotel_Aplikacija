
namespace ProjekatPrvi5220
{
    partial class Form3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.datumPr = new System.Windows.Forms.DateTimePicker();
            this.resetujGBtn = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.rezervacijeLb = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.datumGost = new System.Windows.Forms.DateTimePicker();
            this.dodajBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.telefonGTb = new System.Windows.Forms.TextBox();
            this.prezimeGTb = new System.Windows.Forms.TextBox();
            this.imeGTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbCena = new System.Windows.Forms.Label();
            this.lbBrKreveta = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cenaTrb = new System.Windows.Forms.TrackBar();
            this.krevetiTrb = new System.Windows.Forms.TrackBar();
            this.luxCb = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cenaTxb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tipCb = new System.Windows.Forms.ComboBox();
            this.sobaCb = new System.Windows.Forms.ComboBox();
            this.gostCb = new System.Windows.Forms.ComboBox();
            this.datumPrijava = new System.Windows.Forms.DateTimePicker();
            this.datumOdjave = new System.Windows.Forms.DateTimePicker();
            this.cenaBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.odjavaBtn = new System.Windows.Forms.Button();
            this.sacuvajBtn = new System.Windows.Forms.Button();
            this.refresujBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cenaTrb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.krevetiTrb)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.exitLbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 100);
            this.panel1.TabIndex = 8;
            // 
            // exitLbl
            // 
            this.exitLbl.AutoSize = true;
            this.exitLbl.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exitLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitLbl.Location = new System.Drawing.Point(1240, 9);
            this.exitLbl.Name = "exitLbl";
            this.exitLbl.Size = new System.Drawing.Size(28, 25);
            this.exitLbl.TabIndex = 1;
            this.exitLbl.Text = "X";
            this.exitLbl.Click += new System.EventHandler(this.exitLbl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(468, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "RECEPCIONER";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Controls.Add(this.datumPr);
            this.panel4.Controls.Add(this.resetujGBtn);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.rezervacijeLb);
            this.panel4.Location = new System.Drawing.Point(38, 155);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(589, 288);
            this.panel4.TabIndex = 16;
            // 
            // datumPr
            // 
            this.datumPr.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(216)))));
            this.datumPr.Location = new System.Drawing.Point(183, 198);
            this.datumPr.MaxDate = new System.DateTime(2022, 12, 16, 0, 0, 0, 0);
            this.datumPr.Name = "datumPr";
            this.datumPr.Size = new System.Drawing.Size(148, 20);
            this.datumPr.TabIndex = 34;
            this.datumPr.Value = new System.DateTime(2022, 4, 22, 0, 0, 0, 0);
            this.datumPr.ValueChanged += new System.EventHandler(this.datumPr_ValueChanged);
            // 
            // resetujGBtn
            // 
            this.resetujGBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.resetujGBtn.FlatAppearance.BorderSize = 0;
            this.resetujGBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetujGBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resetujGBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.resetujGBtn.Location = new System.Drawing.Point(214, 237);
            this.resetujGBtn.Name = "resetujGBtn";
            this.resetujGBtn.Size = new System.Drawing.Size(80, 33);
            this.resetujGBtn.TabIndex = 13;
            this.resetujGBtn.Text = "Resetuj";
            this.resetujGBtn.UseVisualStyleBackColor = false;
            this.resetujGBtn.Click += new System.EventHandler(this.resetujGBtn_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(179, 152);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(164, 23);
            this.label13.TabIndex = 1;
            this.label13.Text = "Tekuće rezervacije";
            // 
            // rezervacijeLb
            // 
            this.rezervacijeLb.FormattingEnabled = true;
            this.rezervacijeLb.ItemHeight = 14;
            this.rezervacijeLb.Location = new System.Drawing.Point(0, 0);
            this.rezervacijeLb.Name = "rezervacijeLb";
            this.rezervacijeLb.Size = new System.Drawing.Size(589, 130);
            this.rezervacijeLb.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.datumGost);
            this.panel2.Controls.Add(this.dodajBtn);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.telefonGTb);
            this.panel2.Controls.Add(this.prezimeGTb);
            this.panel2.Controls.Add(this.imeGTb);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(38, 471);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(589, 174);
            this.panel2.TabIndex = 35;
            // 
            // datumGost
            // 
            this.datumGost.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(216)))));
            this.datumGost.Location = new System.Drawing.Point(224, 74);
            this.datumGost.MaxDate = new System.DateTime(2022, 12, 16, 0, 0, 0, 0);
            this.datumGost.Name = "datumGost";
            this.datumGost.Size = new System.Drawing.Size(148, 20);
            this.datumGost.TabIndex = 34;
            this.datumGost.Value = new System.DateTime(2022, 4, 22, 0, 0, 0, 0);
            // 
            // dodajBtn
            // 
            this.dodajBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.dodajBtn.FlatAppearance.BorderSize = 0;
            this.dodajBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dodajBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodajBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dodajBtn.Location = new System.Drawing.Point(214, 128);
            this.dodajBtn.Name = "dodajBtn";
            this.dodajBtn.Size = new System.Drawing.Size(80, 33);
            this.dodajBtn.TabIndex = 13;
            this.dodajBtn.Text = "Dodaj";
            this.dodajBtn.UseVisualStyleBackColor = false;
            this.dodajBtn.Click += new System.EventHandler(this.dodajBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(375, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Telefon";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(223, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "Datum";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(138, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "Prezime";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(51, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 15);
            this.label11.TabIndex = 9;
            this.label11.Text = "Ime";
            // 
            // telefonGTb
            // 
            this.telefonGTb.Location = new System.Drawing.Point(378, 74);
            this.telefonGTb.Name = "telefonGTb";
            this.telefonGTb.Size = new System.Drawing.Size(80, 20);
            this.telefonGTb.TabIndex = 6;
            // 
            // prezimeGTb
            // 
            this.prezimeGTb.Location = new System.Drawing.Point(141, 74);
            this.prezimeGTb.Name = "prezimeGTb";
            this.prezimeGTb.Size = new System.Drawing.Size(80, 20);
            this.prezimeGTb.TabIndex = 4;
            // 
            // imeGTb
            // 
            this.imeGTb.Location = new System.Drawing.Point(55, 74);
            this.imeGTb.Name = "imeGTb";
            this.imeGTb.Size = new System.Drawing.Size(80, 20);
            this.imeGTb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(232, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Novi gost";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.lbCena);
            this.panel3.Controls.Add(this.lbBrKreveta);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.cenaTrb);
            this.panel3.Controls.Add(this.krevetiTrb);
            this.panel3.Controls.Add(this.luxCb);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.cenaTxb);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.tipCb);
            this.panel3.Controls.Add(this.sobaCb);
            this.panel3.Controls.Add(this.gostCb);
            this.panel3.Controls.Add(this.datumPrijava);
            this.panel3.Controls.Add(this.datumOdjave);
            this.panel3.Controls.Add(this.cenaBtn);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(633, 155);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(635, 348);
            this.panel3.TabIndex = 35;
            // 
            // lbCena
            // 
            this.lbCena.AutoSize = true;
            this.lbCena.ForeColor = System.Drawing.Color.White;
            this.lbCena.Location = new System.Drawing.Point(628, 121);
            this.lbCena.Name = "lbCena";
            this.lbCena.Size = new System.Drawing.Size(0, 14);
            this.lbCena.TabIndex = 53;
            // 
            // lbBrKreveta
            // 
            this.lbBrKreveta.AutoSize = true;
            this.lbBrKreveta.ForeColor = System.Drawing.Color.White;
            this.lbBrKreveta.Location = new System.Drawing.Point(628, 79);
            this.lbBrKreveta.Name = "lbBrKreveta";
            this.lbBrKreveta.Size = new System.Drawing.Size(0, 14);
            this.lbBrKreveta.TabIndex = 52;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label21.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label21.Location = new System.Drawing.Point(357, 115);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(99, 15);
            this.label21.TabIndex = 51;
            this.label21.Text = "Maksimalna cena";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label20.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label20.Location = new System.Drawing.Point(357, 73);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(129, 15);
            this.label20.TabIndex = 50;
            this.label20.Text = "Minimalan broj kreveta";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label19.Location = new System.Drawing.Point(518, 47);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(80, 15);
            this.label19.TabIndex = 49;
            this.label19.Text = "Pretraga sobe";
            // 
            // cenaTrb
            // 
            this.cenaTrb.Location = new System.Drawing.Point(492, 115);
            this.cenaTrb.Name = "cenaTrb";
            this.cenaTrb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cenaTrb.Size = new System.Drawing.Size(130, 45);
            this.cenaTrb.TabIndex = 45;
            this.cenaTrb.Scroll += new System.EventHandler(this.cenaTrb_Scroll);
            // 
            // krevetiTrb
            // 
            this.krevetiTrb.Location = new System.Drawing.Point(492, 73);
            this.krevetiTrb.Name = "krevetiTrb";
            this.krevetiTrb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.krevetiTrb.Size = new System.Drawing.Size(130, 45);
            this.krevetiTrb.TabIndex = 46;
            this.krevetiTrb.Scroll += new System.EventHandler(this.krevetiTrb_Scroll);
            // 
            // luxCb
            // 
            this.luxCb.AutoSize = true;
            this.luxCb.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.luxCb.ForeColor = System.Drawing.Color.White;
            this.luxCb.Location = new System.Drawing.Point(525, 177);
            this.luxCb.Name = "luxCb";
            this.luxCb.Size = new System.Drawing.Size(81, 19);
            this.luxCb.TabIndex = 44;
            this.luxCb.Text = "LUX Soba";
            this.luxCb.UseVisualStyleBackColor = true;
            this.luxCb.CheckedChanged += new System.EventHandler(this.luxCb_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(414, 271);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 15);
            this.label15.TabIndex = 36;
            this.label15.Text = "Cena";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(13, 264);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 15);
            this.label14.TabIndex = 42;
            this.label14.Text = "Tip rezervacije";
            // 
            // cenaTxb
            // 
            this.cenaTxb.Location = new System.Drawing.Point(417, 289);
            this.cenaTxb.Name = "cenaTxb";
            this.cenaTxb.Size = new System.Drawing.Size(102, 20);
            this.cenaTxb.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(13, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 15);
            this.label7.TabIndex = 41;
            this.label7.Text = "Soba";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(13, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 15);
            this.label6.TabIndex = 40;
            this.label6.Text = "Gost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(13, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 39;
            this.label5.Text = "Datum odjave";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(13, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 35;
            this.label4.Text = "Datum prijave";
            // 
            // tipCb
            // 
            this.tipCb.FormattingEnabled = true;
            this.tipCb.Items.AddRange(new object[] {
            "Pun pansion",
            "Polu pansion",
            "Samo dorucak"});
            this.tipCb.Location = new System.Drawing.Point(16, 282);
            this.tipCb.Name = "tipCb";
            this.tipCb.Size = new System.Drawing.Size(148, 22);
            this.tipCb.TabIndex = 38;
            // 
            // sobaCb
            // 
            this.sobaCb.FormattingEnabled = true;
            this.sobaCb.Location = new System.Drawing.Point(16, 225);
            this.sobaCb.Name = "sobaCb";
            this.sobaCb.Size = new System.Drawing.Size(481, 22);
            this.sobaCb.TabIndex = 37;
            // 
            // gostCb
            // 
            this.gostCb.FormattingEnabled = true;
            this.gostCb.Location = new System.Drawing.Point(16, 177);
            this.gostCb.Name = "gostCb";
            this.gostCb.Size = new System.Drawing.Size(481, 22);
            this.gostCb.TabIndex = 36;
            // 
            // datumPrijava
            // 
            this.datumPrijava.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(216)))));
            this.datumPrijava.Location = new System.Drawing.Point(16, 73);
            this.datumPrijava.MaxDate = new System.DateTime(2022, 12, 16, 0, 0, 0, 0);
            this.datumPrijava.Name = "datumPrijava";
            this.datumPrijava.Size = new System.Drawing.Size(148, 20);
            this.datumPrijava.TabIndex = 35;
            this.datumPrijava.Value = new System.DateTime(2022, 4, 22, 0, 0, 0, 0);
            this.datumPrijava.ValueChanged += new System.EventHandler(this.datumPrijava_ValueChanged);
            // 
            // datumOdjave
            // 
            this.datumOdjave.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(216)))));
            this.datumOdjave.Location = new System.Drawing.Point(16, 124);
            this.datumOdjave.MaxDate = new System.DateTime(2022, 12, 16, 0, 0, 0, 0);
            this.datumOdjave.Name = "datumOdjave";
            this.datumOdjave.Size = new System.Drawing.Size(148, 20);
            this.datumOdjave.TabIndex = 34;
            this.datumOdjave.Value = new System.DateTime(2022, 4, 22, 0, 0, 0, 0);
            this.datumOdjave.ValueChanged += new System.EventHandler(this.datumOdjave_ValueChanged);
            // 
            // cenaBtn
            // 
            this.cenaBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.cenaBtn.FlatAppearance.BorderSize = 0;
            this.cenaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cenaBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cenaBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cenaBtn.Location = new System.Drawing.Point(525, 282);
            this.cenaBtn.Name = "cenaBtn";
            this.cenaBtn.Size = new System.Drawing.Size(80, 33);
            this.cenaBtn.TabIndex = 13;
            this.cenaBtn.Text = "Cena";
            this.cenaBtn.UseVisualStyleBackColor = false;
            this.cenaBtn.Click += new System.EventHandler(this.cenaBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(228, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nova rezervacija";
            // 
            // odjavaBtn
            // 
            this.odjavaBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.odjavaBtn.FlatAppearance.BorderSize = 0;
            this.odjavaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.odjavaBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odjavaBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.odjavaBtn.Location = new System.Drawing.Point(1054, 532);
            this.odjavaBtn.Name = "odjavaBtn";
            this.odjavaBtn.Size = new System.Drawing.Size(80, 33);
            this.odjavaBtn.TabIndex = 38;
            this.odjavaBtn.Text = "Odjava";
            this.odjavaBtn.UseVisualStyleBackColor = false;
            this.odjavaBtn.Click += new System.EventHandler(this.odjavaBtn_Click);
            // 
            // sacuvajBtn
            // 
            this.sacuvajBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.sacuvajBtn.FlatAppearance.BorderSize = 0;
            this.sacuvajBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sacuvajBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sacuvajBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sacuvajBtn.Location = new System.Drawing.Point(946, 532);
            this.sacuvajBtn.Name = "sacuvajBtn";
            this.sacuvajBtn.Size = new System.Drawing.Size(80, 33);
            this.sacuvajBtn.TabIndex = 37;
            this.sacuvajBtn.Text = "Sačuvaj";
            this.sacuvajBtn.UseVisualStyleBackColor = false;
            this.sacuvajBtn.Click += new System.EventHandler(this.sacuvajBtn_Click);
            // 
            // refresujBtn
            // 
            this.refresujBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.refresujBtn.FlatAppearance.BorderSize = 0;
            this.refresujBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresujBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.refresujBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.refresujBtn.Location = new System.Drawing.Point(836, 532);
            this.refresujBtn.Name = "refresujBtn";
            this.refresujBtn.Size = new System.Drawing.Size(80, 33);
            this.refresujBtn.TabIndex = 36;
            this.refresujBtn.Text = "Refrešuj";
            this.refresujBtn.UseVisualStyleBackColor = false;
            this.refresujBtn.Click += new System.EventHandler(this.refresujBtn_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.odjavaBtn);
            this.Controls.Add(this.sacuvajBtn);
            this.Controls.Add(this.refresujBtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cenaTrb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.krevetiTrb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exitLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker datumPr;
        private System.Windows.Forms.Button resetujGBtn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox rezervacijeLb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker datumGost;
        private System.Windows.Forms.Button dodajBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox telefonGTb;
        private System.Windows.Forms.TextBox prezimeGTb;
        private System.Windows.Forms.TextBox imeGTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TrackBar cenaTrb;
        private System.Windows.Forms.TrackBar krevetiTrb;
        private System.Windows.Forms.CheckBox luxCb;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox cenaTxb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tipCb;
        private System.Windows.Forms.ComboBox sobaCb;
        private System.Windows.Forms.ComboBox gostCb;
        private System.Windows.Forms.DateTimePicker datumPrijava;
        private System.Windows.Forms.DateTimePicker datumOdjave;
        private System.Windows.Forms.Button cenaBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button odjavaBtn;
        private System.Windows.Forms.Button sacuvajBtn;
        private System.Windows.Forms.Button refresujBtn;
        private System.Windows.Forms.Label lbCena;
        private System.Windows.Forms.Label lbBrKreveta;
    }
}