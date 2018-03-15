namespace Airline
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
            this.label25 = new System.Windows.Forms.Label();
            this.lblSeat = new System.Windows.Forms.Label();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnMap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(413, 19);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(264, 29);
            this.label25.TabIndex = 108;
            this.label25.Text = "Select a Seat to Book";
            // 
            // lblSeat
            // 
            this.lblSeat.AutoSize = true;
            this.lblSeat.Location = new System.Drawing.Point(521, 376);
            this.lblSeat.Name = "lblSeat";
            this.lblSeat.Size = new System.Drawing.Size(51, 20);
            this.lblSeat.TabIndex = 109;
            this.lblSeat.Text = "label1";
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(284, 407);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(175, 42);
            this.btnComplete.TabIndex = 110;
            this.btnComplete.Text = "Complete Booking";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(465, 407);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(175, 42);
            this.btnList.TabIndex = 111;
            this.btnList.Text = "List of Available Seats";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnMap
            // 
            this.btnMap.Location = new System.Drawing.Point(646, 407);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(175, 42);
            this.btnMap.TabIndex = 112;
            this.btnMap.Text = "Seats Map";
            this.btnMap.UseVisualStyleBackColor = true;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 478);
            this.Controls.Add(this.btnMap);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.lblSeat);
            this.Controls.Add(this.label25);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lblSeat;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnMap;
    }
}

