namespace OneUtility
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_graph = new System.Windows.Forms.Button();
            this.button_shell = new System.Windows.Forms.Button();
            this.button_DataSheet = new System.Windows.Forms.Button();
            this.buton_AddUsers = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button_graph);
            this.groupBox1.Controls.Add(this.button_shell);
            this.groupBox1.Controls.Add(this.button_DataSheet);
            this.groupBox1.Controls.Add(this.buton_AddUsers);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 212);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control Panel";
            // 
            // button_graph
            // 
            this.button_graph.Image = global::OneUtility.Properties.Resources.chart;
            this.button_graph.Location = new System.Drawing.Point(284, 74);
            this.button_graph.Name = "button_graph";
            this.button_graph.Size = new System.Drawing.Size(111, 106);
            this.button_graph.TabIndex = 3;
            this.button_graph.Text = "Statitics";
            this.button_graph.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_graph.UseVisualStyleBackColor = true;
            // 
            // button_shell
            // 
            this.button_shell.Image = global::OneUtility.Properties.Resources.System_64;
            this.button_shell.Location = new System.Drawing.Point(414, 74);
            this.button_shell.Name = "button_shell";
            this.button_shell.Size = new System.Drawing.Size(111, 106);
            this.button_shell.TabIndex = 2;
            this.button_shell.Text = "Shell";
            this.button_shell.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_shell.UseVisualStyleBackColor = true;
            this.button_shell.Click += new System.EventHandler(this.button_shell_Click);
            // 
            // button_DataSheet
            // 
            this.button_DataSheet.Image = global::OneUtility.Properties.Resources.Documents;
            this.button_DataSheet.Location = new System.Drawing.Point(153, 74);
            this.button_DataSheet.Name = "button_DataSheet";
            this.button_DataSheet.Size = new System.Drawing.Size(111, 106);
            this.button_DataSheet.TabIndex = 1;
            this.button_DataSheet.Text = "Data Sheet";
            this.button_DataSheet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_DataSheet.UseVisualStyleBackColor = true;
            this.button_DataSheet.Click += new System.EventHandler(this.button_DataSheet_Click);
            // 
            // buton_AddUsers
            // 
            this.buton_AddUsers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buton_AddUsers.Image = global::OneUtility.Properties.Resources.add_Users;
            this.buton_AddUsers.Location = new System.Drawing.Point(17, 74);
            this.buton_AddUsers.Name = "buton_AddUsers";
            this.buton_AddUsers.Size = new System.Drawing.Size(111, 106);
            this.buton_AddUsers.TabIndex = 0;
            this.buton_AddUsers.Text = "Add User";
            this.buton_AddUsers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buton_AddUsers.UseVisualStyleBackColor = true;
            this.buton_AddUsers.Click += new System.EventHandler(this.buton_AddUsers_Click);
            // 
            // button1
            // 
            this.button1.Image = global::OneUtility.Properties.Resources.unlock;
            this.button1.Location = new System.Drawing.Point(478, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 40);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 244);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_graph;
        private System.Windows.Forms.Button button_shell;
        private System.Windows.Forms.Button button_DataSheet;
        private System.Windows.Forms.Button buton_AddUsers;
        private System.Windows.Forms.Button button1;
    }
}