namespace cellphone
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
            this.ltbPeople = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDisplayPeople = new System.Windows.Forms.Button();
            this.ltbCellPhones = new System.Windows.Forms.ListBox();
            this.cboPlans = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpdatePlan = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ltbPeople
            // 
            this.ltbPeople.FormattingEnabled = true;
            this.ltbPeople.ItemHeight = 20;
            this.ltbPeople.Location = new System.Drawing.Point(78, 53);
            this.ltbPeople.Name = "ltbPeople";
            this.ltbPeople.Size = new System.Drawing.Size(402, 304);
            this.ltbPeople.TabIndex = 0;
            this.ltbPeople.SelectedIndexChanged += new System.EventHandler(this.ltbPeople_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "LName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Payment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "FName";
            // 
            // btnDisplayPeople
            // 
            this.btnDisplayPeople.Location = new System.Drawing.Point(78, 379);
            this.btnDisplayPeople.Name = "btnDisplayPeople";
            this.btnDisplayPeople.Size = new System.Drawing.Size(402, 42);
            this.btnDisplayPeople.TabIndex = 4;
            this.btnDisplayPeople.Text = "Display People";
            this.btnDisplayPeople.UseVisualStyleBackColor = true;
            this.btnDisplayPeople.Click += new System.EventHandler(this.btnDisplayPeople_Click);
            // 
            // ltbCellPhones
            // 
            this.ltbCellPhones.FormattingEnabled = true;
            this.ltbCellPhones.ItemHeight = 20;
            this.ltbCellPhones.Location = new System.Drawing.Point(509, 53);
            this.ltbCellPhones.Name = "ltbCellPhones";
            this.ltbCellPhones.Size = new System.Drawing.Size(402, 304);
            this.ltbCellPhones.TabIndex = 5;
            // 
            // cboPlans
            // 
            this.cboPlans.FormattingEnabled = true;
            this.cboPlans.Location = new System.Drawing.Point(666, 379);
            this.cboPlans.Name = "cboPlans";
            this.cboPlans.Size = new System.Drawing.Size(245, 28);
            this.cboPlans.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(505, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Select New Plan";
            // 
            // btnUpdatePlan
            // 
            this.btnUpdatePlan.Location = new System.Drawing.Point(509, 431);
            this.btnUpdatePlan.Name = "btnUpdatePlan";
            this.btnUpdatePlan.Size = new System.Drawing.Size(402, 42);
            this.btnUpdatePlan.TabIndex = 8;
            this.btnUpdatePlan.Text = "Update Plan";
            this.btnUpdatePlan.UseVisualStyleBackColor = true;
            this.btnUpdatePlan.Click += new System.EventHandler(this.btnUpdatePlan_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(505, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Brand";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(594, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Carrier";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(680, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Plan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(798, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Price";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 485);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnUpdatePlan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboPlans);
            this.Controls.Add(this.ltbCellPhones);
            this.Controls.Add(this.btnDisplayPeople);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ltbPeople);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ltbPeople;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDisplayPeople;
        private System.Windows.Forms.ListBox ltbCellPhones;
        private System.Windows.Forms.ComboBox cboPlans;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpdatePlan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

