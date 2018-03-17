using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline
{
    public partial class List : Form
    {
        //global index for row
        private static int indexR = 0;
        public List()
        {
            InitializeComponent();
        }
        //**************************LIST LOAD***********************************
        private void List_Load(object sender, EventArgs e)
        {
            //populate combobox with Rows
            for (int i = 0; i < Form1.rows.Length; i++)
            {
                cboRows.Items.Add(i+1);
            }
        }
        //**************************CBO ROWS************************************
        private void cboRows_SelectedIndexChanged(object sender, EventArgs e)
        {
            //clear cboSeats
            cboSeats.Items.Clear();
            //clear last selected item in cboSeats
            cboSeats.Text = String.Empty;
            //get index from cboRows
            indexR = cboRows.SelectedIndex;
            //enable cboSeats
            if (Form1.rows[indexR].RightSideWindowSeat == false)
            { cboSeats.Items.Add('A'); }
            if (Form1.rows[indexR].RightSideAisleSeat == false)
            { cboSeats.Items.Add('B'); }
            if (Form1.rows[indexR].LeftSideAisleSeat == false)
            { cboSeats.Items.Add('C'); }
            if (Form1.rows[indexR].LeftSideWindowSeat == false)
            { cboSeats.Items.Add('D'); }
            if (cboSeats.Items.Count == 0)
            { cboSeats.Text = "No seats available."; }
        }
        //**************************BTN BOOKING*********************************
        private void btnBook_Click(object sender, EventArgs e)
        {
            //check if something was selected from cboSeats
            if(cboSeats.SelectedIndex != -1)
            {
                //get selected index
                int indexS = 0;
                //condition to update seat availability
                if (cboSeats.SelectedItem.ToString() == "A")
                {
                    Form1.rows[indexR].RightSideWindowSeat = true;
                }
                else if (cboSeats.SelectedItem.ToString() == "B")
                {
                    Form1.rows[indexR].RightSideAisleSeat = true;
                    indexS = 1;
                }
                else if (cboSeats.SelectedItem.ToString() == "C")
                {
                    Form1.rows[indexR].LeftSideAisleSeat = true;
                    indexS = 2;
                }
                else
                {
                    Form1.rows[indexR].LeftSideWindowSeat = true;
                    indexS = 3;
                }
                //update button from Form1
                Form1.buttons[indexR, indexS].BackColor = Color.Red;
                Form1.buttons[indexR, indexS].Enabled = false;
                //clear text from cboSeats to force update
                cboSeats.Text = String.Empty;
                //clear text from combobox to force user to select another
                //row number and initialize the click event
                cboRows.Text = String.Empty;
                //display confirmation message
                MessageBox.Show("Your seat was booked!");
            }
            else
            { MessageBox.Show("Select a seat to book."); }
        }
    }
}
