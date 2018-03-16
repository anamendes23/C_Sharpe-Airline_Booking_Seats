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
            //populate combobox with Seats
            foreach (char seat in Form1.letters)
            {
                cboSeats.Items.Add(seat);
            }
            //disable cboSeats
            cboSeats.Enabled = false;
        }
        //**************************CBO ROWS************************************
        private void cboRows_SelectedIndexChanged(object sender, EventArgs e)
        {
            //when row is select, enable seat combobox
            //clear last selected item in cboSeats
            cboSeats.Text = String.Empty;
            //get index from cboRows
            indexR = cboRows.SelectedIndex;
            //enable cboSeats
            cboSeats.Enabled = true;
        }
        //**************************BTN BOOKING*********************************
        private void btnBook_Click(object sender, EventArgs e)
        {
            //check if something was selected from cboSeats
            if(cboSeats.SelectedIndex != -1)
            {
                //get selected index
                int indexS = cboSeats.SelectedIndex;
                //condition to update seat availability
                if (indexS == 0)
                { Form1.rows[indexR].RightSideWindowSeat = true; }
                else if (indexS == 1)
                { Form1.rows[indexR].RightSideAisleSeat = true; }
                else if (indexS == 2)
                { Form1.rows[indexR].LeftSideAisleSeat = true; }
                else
                { Form1.rows[indexR].LeftSideWindowSeat = true; }
                //update button from Form1
                Form1.buttons[indexR, indexS].BackColor = Color.Red;
                Form1.buttons[indexR, indexS].Enabled = false;
                //clear text from cboSeats to force update
                cboSeats.Text = String.Empty;
                cboSeats.Enabled = false;
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
