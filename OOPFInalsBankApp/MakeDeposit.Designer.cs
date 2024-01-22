namespace OOPFInalsBankApp
{
    partial class MakeDeposit
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakeDeposit));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.depositField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dpstBTTN = new System.Windows.Forms.Button();
            this.clrfldsBTTN = new System.Windows.Forms.Button();
            this.exitBTTN = new System.Windows.Forms.Button();
            this.accField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(173, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 42);
            this.label2.TabIndex = 6;
            this.label2.Text = "Account Deposit Portal";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(132, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 58);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bank Onegaishimasu";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(220, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(183, 155);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // depositField
            // 
            this.depositField.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.depositField.Location = new System.Drawing.Point(125, 437);
            this.depositField.Multiline = true;
            this.depositField.Name = "depositField";
            this.depositField.Size = new System.Drawing.Size(358, 64);
            this.depositField.TabIndex = 8;
            this.depositField.TextChanged += new System.EventHandler(this.depositField_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(125, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Enter Deposit Value:";
            // 
            // dpstBTTN
            // 
            this.dpstBTTN.BackColor = System.Drawing.Color.Green;
            this.dpstBTTN.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dpstBTTN.ForeColor = System.Drawing.Color.White;
            this.dpstBTTN.Location = new System.Drawing.Point(121, 532);
            this.dpstBTTN.Name = "dpstBTTN";
            this.dpstBTTN.Size = new System.Drawing.Size(114, 57);
            this.dpstBTTN.TabIndex = 10;
            this.dpstBTTN.Text = "MAKE DEPOSIT";
            this.dpstBTTN.UseVisualStyleBackColor = false;
            this.dpstBTTN.Click += new System.EventHandler(this.dpstBTTN_Click);
            // 
            // clrfldsBTTN
            // 
            this.clrfldsBTTN.BackColor = System.Drawing.Color.Blue;
            this.clrfldsBTTN.ForeColor = System.Drawing.Color.White;
            this.clrfldsBTTN.Location = new System.Drawing.Point(253, 532);
            this.clrfldsBTTN.Name = "clrfldsBTTN";
            this.clrfldsBTTN.Size = new System.Drawing.Size(106, 57);
            this.clrfldsBTTN.TabIndex = 11;
            this.clrfldsBTTN.Text = "CLEAR FIELDS";
            this.clrfldsBTTN.UseVisualStyleBackColor = false;
            this.clrfldsBTTN.Click += new System.EventHandler(this.clrfldsBTTN_Click);
            // 
            // exitBTTN
            // 
            this.exitBTTN.BackColor = System.Drawing.Color.Firebrick;
            this.exitBTTN.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitBTTN.ForeColor = System.Drawing.Color.White;
            this.exitBTTN.Location = new System.Drawing.Point(383, 532);
            this.exitBTTN.Name = "exitBTTN";
            this.exitBTTN.Size = new System.Drawing.Size(96, 57);
            this.exitBTTN.TabIndex = 12;
            this.exitBTTN.Text = "CANCEL DEPOSIT";
            this.exitBTTN.UseVisualStyleBackColor = false;
            this.exitBTTN.Click += new System.EventHandler(this.exitBTTN_Click);
            // 
            // accField
            // 
            this.accField.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.accField.Location = new System.Drawing.Point(125, 318);
            this.accField.Multiline = true;
            this.accField.Name = "accField";
            this.accField.Size = new System.Drawing.Size(358, 65);
            this.accField.TabIndex = 13;
            this.accField.TextChanged += new System.EventHandler(this.accFields_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(125, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Enter Account Name:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // MakeDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(606, 639);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.accField);
            this.Controls.Add(this.exitBTTN);
            this.Controls.Add(this.clrfldsBTTN);
            this.Controls.Add(this.dpstBTTN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.depositField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "MakeDeposit";
            this.Text = "Account Deposit Portal";
            this.Load += new System.EventHandler(this.MakeDeposit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Label label1;
        private PictureBox pictureBox2;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox depositField;
        private Label label3;
        private Button dpstBTTN;
        private Button clrfldsBTTN;
        private Button exitBTTN;
        private TextBox accField;
        private Label label4;
    }
}