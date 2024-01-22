namespace OOPFInalsBankApp
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rgstrBTTN = new System.Windows.Forms.Button();
            this.exitBTTN = new System.Windows.Forms.Button();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.accbalField = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(133, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(335, 265);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(121, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 58);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bank Onegaishimasu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(183, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 42);
            this.label2.TabIndex = 4;
            this.label2.Text = "Registration Portal";
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(166, 446);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(265, 23);
            this.inputName.TabIndex = 13;
            this.inputName.TextChanged += new System.EventHandler(this.inputName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(166, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Your Name:";
            // 
            // rgstrBTTN
            // 
            this.rgstrBTTN.BackColor = System.Drawing.Color.MediumTurquoise;
            this.rgstrBTTN.Location = new System.Drawing.Point(166, 578);
            this.rgstrBTTN.Name = "rgstrBTTN";
            this.rgstrBTTN.Size = new System.Drawing.Size(122, 23);
            this.rgstrBTTN.TabIndex = 16;
            this.rgstrBTTN.Text = "REGISTER";
            this.rgstrBTTN.UseVisualStyleBackColor = false;
            this.rgstrBTTN.Click += new System.EventHandler(this.rgstrBTTN_Click);
            // 
            // exitBTTN
            // 
            this.exitBTTN.BackColor = System.Drawing.Color.Firebrick;
            this.exitBTTN.Location = new System.Drawing.Point(311, 578);
            this.exitBTTN.Name = "exitBTTN";
            this.exitBTTN.Size = new System.Drawing.Size(120, 23);
            this.exitBTTN.TabIndex = 19;
            this.exitBTTN.Text = "EXIT";
            this.exitBTTN.UseVisualStyleBackColor = false;
            this.exitBTTN.Click += new System.EventHandler(this.exitBTTN_Click);
            // 
            // passwordField
            // 
            this.passwordField.Location = new System.Drawing.Point(166, 496);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(265, 23);
            this.passwordField.TabIndex = 20;
            this.passwordField.TextChanged += new System.EventHandler(this.passwordField_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(166, 476);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Your Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(166, 529);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Initial Account Balance:";
            // 
            // accbalField
            // 
            this.accbalField.Location = new System.Drawing.Point(166, 549);
            this.accbalField.Name = "accbalField";
            this.accbalField.Size = new System.Drawing.Size(265, 23);
            this.accbalField.TabIndex = 22;
            this.accbalField.TextChanged += new System.EventHandler(this.accbalField_TextChanged);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(606, 639);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.accbalField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.exitBTTN);
            this.Controls.Add(this.rgstrBTTN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Registration";
            this.Text = "Registration Portal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private TextBox inputName;
        private Label label3;
        private Button rgstrBTTN;
        private Button exitBTTN;
        private TextBox passwordField;
        private Label label4;
        private Label label5;
        private TextBox accbalField;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}