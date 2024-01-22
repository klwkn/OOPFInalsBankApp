namespace OOPFInalsBankApp
{
    partial class MakeWithdrawal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakeWithdrawal));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.accField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.wthdrwlField = new System.Windows.Forms.TextBox();
            this.wthdrwlBTTN = new System.Windows.Forms.Button();
            this.exitBTTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(137, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 42);
            this.label2.TabIndex = 9;
            this.label2.Text = "Account Withdrawal Portal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(119, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 58);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bank Onegaishimasu";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(207, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(183, 155);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(123, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Enter Account Name:";
            // 
            // accField
            // 
            this.accField.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.accField.Location = new System.Drawing.Point(123, 328);
            this.accField.Multiline = true;
            this.accField.Name = "accField";
            this.accField.Size = new System.Drawing.Size(358, 66);
            this.accField.TabIndex = 17;
            this.accField.TextChanged += new System.EventHandler(this.accField_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(123, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Enter Withdrawal Value:";
            // 
            // wthdrwlField
            // 
            this.wthdrwlField.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wthdrwlField.Location = new System.Drawing.Point(123, 444);
            this.wthdrwlField.Multiline = true;
            this.wthdrwlField.Name = "wthdrwlField";
            this.wthdrwlField.Size = new System.Drawing.Size(358, 61);
            this.wthdrwlField.TabIndex = 15;
            this.wthdrwlField.TextChanged += new System.EventHandler(this.wthdrwlField_TextChanged);
            // 
            // wthdrwlBTTN
            // 
            this.wthdrwlBTTN.BackColor = System.Drawing.Color.Green;
            this.wthdrwlBTTN.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wthdrwlBTTN.ForeColor = System.Drawing.Color.White;
            this.wthdrwlBTTN.Location = new System.Drawing.Point(123, 538);
            this.wthdrwlBTTN.Name = "wthdrwlBTTN";
            this.wthdrwlBTTN.Size = new System.Drawing.Size(180, 57);
            this.wthdrwlBTTN.TabIndex = 19;
            this.wthdrwlBTTN.Text = "MAKE WITHDRAWAL";
            this.wthdrwlBTTN.UseVisualStyleBackColor = false;
            this.wthdrwlBTTN.Click += new System.EventHandler(this.wthdrwlBTTN_Click);
            // 
            // exitBTTN
            // 
            this.exitBTTN.BackColor = System.Drawing.Color.Firebrick;
            this.exitBTTN.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitBTTN.ForeColor = System.Drawing.Color.White;
            this.exitBTTN.Location = new System.Drawing.Point(309, 538);
            this.exitBTTN.Name = "exitBTTN";
            this.exitBTTN.Size = new System.Drawing.Size(172, 57);
            this.exitBTTN.TabIndex = 20;
            this.exitBTTN.Text = "CANCEL WITHDRAWAL";
            this.exitBTTN.UseVisualStyleBackColor = false;
            this.exitBTTN.Click += new System.EventHandler(this.exitBTTN_Click);
            // 
            // MakeWithdrawal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(606, 639);
            this.Controls.Add(this.exitBTTN);
            this.Controls.Add(this.wthdrwlBTTN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.accField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.wthdrwlField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "MakeWithdrawal";
            this.Text = "Account Withdrawal Portal";
            this.Load += new System.EventHandler(this.MakeWithdrawal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label4;
        private TextBox accField;
        private Label label3;
        private TextBox wthdrwlField;
        private Button wthdrwlBTTN;
        private Button exitBTTN;
    }
}