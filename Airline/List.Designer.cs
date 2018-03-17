namespace Airline
{
    partial class List
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
            this.cboRows = new System.Windows.Forms.ComboBox();
            this.cboSeats = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboRows
            // 
            this.cboRows.FormattingEnabled = true;
            this.cboRows.Location = new System.Drawing.Point(40, 62);
            this.cboRows.Name = "cboRows";
            this.cboRows.Size = new System.Drawing.Size(121, 28);
            this.cboRows.TabIndex = 0;
            this.cboRows.SelectedIndexChanged += new System.EventHandler(this.cboRows_SelectedIndexChanged);
            // 
            // cboSeats
            // 
            this.cboSeats.FormattingEnabled = true;
            this.cboSeats.Location = new System.Drawing.Point(208, 61);
            this.cboSeats.Name = "cboSeats";
            this.cboSeats.Size = new System.Drawing.Size(205, 28);
            this.cboSeats.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Row";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seat";
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(40, 133);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(373, 36);
            this.btnBook.TabIndex = 4;
            this.btnBook.Text = "Complete Booking";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 210);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboSeats);
            this.Controls.Add(this.cboRows);
            this.Name = "List";
            this.Text = "List";
            this.Load += new System.EventHandler(this.List_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboRows;
        private System.Windows.Forms.ComboBox cboSeats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBook;
    }
}