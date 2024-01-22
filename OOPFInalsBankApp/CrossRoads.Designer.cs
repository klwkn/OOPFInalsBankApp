namespace OOPFInalsBankApp
{
    partial class CrossRoads
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrossRoads));
            this.exitBTTN = new System.Windows.Forms.Button();
            this.makeWithdrawal = new System.Windows.Forms.Button();
            this.makeDeposit = new System.Windows.Forms.Button();
            this.backToAccountPortal = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // exitBTTN
            // 
            this.exitBTTN.BackColor = System.Drawing.Color.Red;
            this.exitBTTN.Font = new System.Drawing.Font("Bahnschrift", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitBTTN.ForeColor = System.Drawing.SystemColors.Control;
            this.exitBTTN.Location = new System.Drawing.Point(153, 523);
            this.exitBTTN.Name = "exitBTTN";
            this.exitBTTN.Size = new System.Drawing.Size(330, 64);
            this.exitBTTN.TabIndex = 0;
            this.exitBTTN.Text = "Exit Crossroads";
            this.exitBTTN.UseVisualStyleBackColor = false;
            this.exitBTTN.Click += new System.EventHandler(this.exitBTTN_Click);
            // 
            // makeWithdrawal
            // 
            this.makeWithdrawal.Font = new System.Drawing.Font("Bahnschrift", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.makeWithdrawal.Location = new System.Drawing.Point(153, 249);
            this.makeWithdrawal.Name = "makeWithdrawal";
            this.makeWithdrawal.Size = new System.Drawing.Size(330, 64);
            this.makeWithdrawal.TabIndex = 1;
            this.makeWithdrawal.Text = "MAKE WITHDRAWAL";
            this.makeWithdrawal.UseVisualStyleBackColor = true;
            this.makeWithdrawal.Click += new System.EventHandler(this.makeWithdrawal_Click);
            // 
            // makeDeposit
            // 
            this.makeDeposit.Font = new System.Drawing.Font("Bahnschrift", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.makeDeposit.Location = new System.Drawing.Point(153, 340);
            this.makeDeposit.Name = "makeDeposit";
            this.makeDeposit.Size = new System.Drawing.Size(330, 64);
            this.makeDeposit.TabIndex = 2;
            this.makeDeposit.Text = "MAKE DEPOSIT";
            this.makeDeposit.UseVisualStyleBackColor = true;
            this.makeDeposit.Click += new System.EventHandler(this.makeDeposit_Click);
            // 
            // backToAccountPortal
            // 
            this.backToAccountPortal.BackColor = System.Drawing.Color.Blue;
            this.backToAccountPortal.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backToAccountPortal.ForeColor = System.Drawing.SystemColors.Control;
            this.backToAccountPortal.Location = new System.Drawing.Point(153, 444);
            this.backToAccountPortal.Name = "backToAccountPortal";
            this.backToAccountPortal.Size = new System.Drawing.Size(330, 64);
            this.backToAccountPortal.TabIndex = 3;
            this.backToAccountPortal.Text = "BACK TO ACCOUNT PORTAL";
            this.backToAccountPortal.UseVisualStyleBackColor = false;
            this.backToAccountPortal.Click += new System.EventHandler(this.backToAccountPortal_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(249, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(139, 116);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(244, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 42);
            this.label2.TabIndex = 6;
            this.label2.Text = "Crossroads";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(139, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 58);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bank Onegaishimasu";
            // 
            // CrossRoads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(606, 639);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.backToAccountPortal);
            this.Controls.Add(this.makeDeposit);
            this.Controls.Add(this.makeWithdrawal);
            this.Controls.Add(this.exitBTTN);
            this.Name = "CrossRoads";
            this.Text = "Bank Crossroads";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button exitBTTN;
        private Button makeWithdrawal;
        private Button makeDeposit;
        private Button backToAccountPortal;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label1;
    }
}