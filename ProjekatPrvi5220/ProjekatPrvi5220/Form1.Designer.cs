
namespace ProjekatPrvi5220
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.korisnickoImeTxb = new System.Windows.Forms.TextBox();
            this.lozinkaTxb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.prijaviBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exitLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(530, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "DOBRO DOŠLI";
            // 
            // korisnickoImeTxb
            // 
            this.korisnickoImeTxb.Location = new System.Drawing.Point(47, 78);
            this.korisnickoImeTxb.Margin = new System.Windows.Forms.Padding(4);
            this.korisnickoImeTxb.Multiline = true;
            this.korisnickoImeTxb.Name = "korisnickoImeTxb";
            this.korisnickoImeTxb.Size = new System.Drawing.Size(360, 30);
            this.korisnickoImeTxb.TabIndex = 1;
            // 
            // lozinkaTxb
            // 
            this.lozinkaTxb.Location = new System.Drawing.Point(47, 210);
            this.lozinkaTxb.Margin = new System.Windows.Forms.Padding(4);
            this.lozinkaTxb.Multiline = true;
            this.lozinkaTxb.Name = "lozinkaTxb";
            this.lozinkaTxb.PasswordChar = '*';
            this.lozinkaTxb.Size = new System.Drawing.Size(360, 30);
            this.lozinkaTxb.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(41, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Korisničko ime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(43, 183);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lozinka:";
            // 
            // prijaviBtn
            // 
            this.prijaviBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.prijaviBtn.FlatAppearance.BorderSize = 0;
            this.prijaviBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prijaviBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.prijaviBtn.Location = new System.Drawing.Point(566, 611);
            this.prijaviBtn.Margin = new System.Windows.Forms.Padding(4);
            this.prijaviBtn.Name = "prijaviBtn";
            this.prijaviBtn.Size = new System.Drawing.Size(195, 54);
            this.prijaviBtn.TabIndex = 5;
            this.prijaviBtn.Text = "Prijavi se";
            this.prijaviBtn.UseVisualStyleBackColor = false;
            this.prijaviBtn.Click += new System.EventHandler(this.prijaviBtn_Click);
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
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OrangeRed;
            this.panel2.Controls.Add(this.lozinkaTxb);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.korisnickoImeTxb);
            this.panel2.Controls.Add(this.label2);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(434, 223);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 352);
            this.panel2.TabIndex = 7;
            // 
            // exitLbl
            // 
            this.exitLbl.AutoSize = true;
            this.exitLbl.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exitLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitLbl.Location = new System.Drawing.Point(1240, 9);
            this.exitLbl.Name = "exitLbl";
            this.exitLbl.Size = new System.Drawing.Size(28, 25);
            this.exitLbl.TabIndex = 8;
            this.exitLbl.Text = "X";
            this.exitLbl.Click += new System.EventHandler(this.exitLbl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.prijaviBtn);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox korisnickoImeTxb;
        private System.Windows.Forms.TextBox lozinkaTxb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button prijaviBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label exitLbl;
    }
}

