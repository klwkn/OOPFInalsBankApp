namespace OOPFInalsBankApp
{
    partial class AccountPortal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountPortal));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.usernameField = new System.Windows.Forms.TextBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.lgnBTTN = new System.Windows.Forms.Button();
            this.exitBTTN = new System.Windows.Forms.Button();
            this.clrfldsBTTN = new System.Windows.Forms.Button();
            this.SignUpLink = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(138, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(335, 265);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(126, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 58);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bank Onegaishimasu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(213, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 42);
            this.label2.TabIndex = 3;
            this.label2.Text = "Account Portal";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(173, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Username";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(173, 467);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // usernameField
            // 
            this.usernameField.Location = new System.Drawing.Point(173, 426);
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(265, 23);
            this.usernameField.TabIndex = 12;
            this.usernameField.TextChanged += new System.EventHandler(this.usernameField_TextChanged);
            // 
            // passwordField
            // 
            this.passwordField.Location = new System.Drawing.Point(173, 487);
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '●';
            this.passwordField.Size = new System.Drawing.Size(265, 23);
            this.passwordField.TabIndex = 14;
            this.passwordField.TextChanged += new System.EventHandler(this.passwordField_TextChanged_1);
            // 
            // lgnBTTN
            // 
            this.lgnBTTN.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lgnBTTN.Location = new System.Drawing.Point(170, 529);
            this.lgnBTTN.Name = "lgnBTTN";
            this.lgnBTTN.Size = new System.Drawing.Size(75, 23);
            this.lgnBTTN.TabIndex = 15;
            this.lgnBTTN.Text = "LOGIN";
            this.lgnBTTN.UseVisualStyleBackColor = false;
            this.lgnBTTN.Click += new System.EventHandler(this.lgnBTTN_Click);
            // 
            // exitBTTN
            // 
            this.exitBTTN.BackColor = System.Drawing.Color.Firebrick;
            this.exitBTTN.Location = new System.Drawing.Point(360, 529);
            this.exitBTTN.Name = "exitBTTN";
            this.exitBTTN.Size = new System.Drawing.Size(75, 23);
            this.exitBTTN.TabIndex = 16;
            this.exitBTTN.Text = "EXIT";
            this.exitBTTN.UseVisualStyleBackColor = false;
            this.exitBTTN.Click += new System.EventHandler(this.exitBTTN_Click);
            // 
            // clrfldsBTTN
            // 
            this.clrfldsBTTN.BackColor = System.Drawing.Color.BlueViolet;
            this.clrfldsBTTN.ForeColor = System.Drawing.Color.White;
            this.clrfldsBTTN.Location = new System.Drawing.Point(252, 529);
            this.clrfldsBTTN.Name = "clrfldsBTTN";
            this.clrfldsBTTN.Size = new System.Drawing.Size(102, 23);
            this.clrfldsBTTN.TabIndex = 17;
            this.clrfldsBTTN.Text = "CLEAR FIELDS";
            this.clrfldsBTTN.UseVisualStyleBackColor = false;
            this.clrfldsBTTN.Click += new System.EventHandler(this.clrfldsBTTN_Click);
            // 
            // SignUpLink
            // 
            this.SignUpLink.AutoSize = true;
            this.SignUpLink.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SignUpLink.LinkColor = System.Drawing.Color.Blue;
            this.SignUpLink.Location = new System.Drawing.Point(281, 596);
            this.SignUpLink.Name = "SignUpLink";
            this.SignUpLink.Size = new System.Drawing.Size(55, 16);
            this.SignUpLink.TabIndex = 18;
            this.SignUpLink.TabStop = true;
            this.SignUpLink.Text = "Sign Up!";
            this.SignUpLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignUpLink_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(211, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 42);
            this.label5.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(192, 579);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Not yet a Bank Onegaishimasu account holder?";
            // 
            // AccountPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(606, 639);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SignUpLink);
            this.Controls.Add(this.clrfldsBTTN);
            this.Controls.Add(this.exitBTTN);
            this.Controls.Add(this.lgnBTTN);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.usernameField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "AccountPortal";
            this.Text = "Bank Onegaishimasu | Account Portal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox usernameField;
        private TextBox passwordField;
        private Button lgnBTTN;
        private Button exitBTTN;
        private Button clrfldsBTTN;
        private LinkLabel SignUpLink;
        private Label label5;
        private Label label6;
    }
}