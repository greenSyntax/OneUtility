namespace OneUtility
{
    partial class CardSystem
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButton_internet = new System.Windows.Forms.RadioButton();
            this.radioButton_creidt = new System.Windows.Forms.RadioButton();
            this.radioButton_debit = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.radioButton_internet);
            this.groupBox1.Controls.Add(this.radioButton_creidt);
            this.groupBox1.Controls.Add(this.radioButton_debit);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Your Payment Way";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OneUtility.Properties.Resources.money;
            this.pictureBox1.Location = new System.Drawing.Point(113, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 37);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // radioButton_internet
            // 
            this.radioButton_internet.AutoSize = true;
            this.radioButton_internet.Location = new System.Drawing.Point(6, 85);
            this.radioButton_internet.Name = "radioButton_internet";
            this.radioButton_internet.Size = new System.Drawing.Size(103, 17);
            this.radioButton_internet.TabIndex = 2;
            this.radioButton_internet.TabStop = true;
            this.radioButton_internet.Text = "Internet Banking";
            this.radioButton_internet.UseVisualStyleBackColor = true;
            this.radioButton_internet.CheckedChanged += new System.EventHandler(this.radioButton_internet_CheckedChanged);
            // 
            // radioButton_creidt
            // 
            this.radioButton_creidt.AutoSize = true;
            this.radioButton_creidt.Location = new System.Drawing.Point(6, 62);
            this.radioButton_creidt.Name = "radioButton_creidt";
            this.radioButton_creidt.Size = new System.Drawing.Size(77, 17);
            this.radioButton_creidt.TabIndex = 1;
            this.radioButton_creidt.TabStop = true;
            this.radioButton_creidt.Text = "Credit Card";
            this.radioButton_creidt.UseVisualStyleBackColor = true;
            this.radioButton_creidt.CheckedChanged += new System.EventHandler(this.radioButton_creidt_CheckedChanged);
            // 
            // radioButton_debit
            // 
            this.radioButton_debit.AutoSize = true;
            this.radioButton_debit.Location = new System.Drawing.Point(6, 39);
            this.radioButton_debit.Name = "radioButton_debit";
            this.radioButton_debit.Size = new System.Drawing.Size(75, 17);
            this.radioButton_debit.TabIndex = 0;
            this.radioButton_debit.TabStop = true;
            this.radioButton_debit.Text = "Debit Card";
            this.radioButton_debit.UseVisualStyleBackColor = true;
            this.radioButton_debit.CheckedChanged += new System.EventHandler(this.radioButton_debit_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Image = global::OneUtility.Properties.Resources.pay;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(17, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Pay Your Amount";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CardSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 203);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "CardSystem";
            this.Text = "CardSystem";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButton_internet;
        private System.Windows.Forms.RadioButton radioButton_creidt;
        private System.Windows.Forms.RadioButton radioButton_debit;
        private System.Windows.Forms.Button button1;
    }
}