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
        //create row to get values from Form1
        Row row = new Row();
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
            //when item in combobox is select, populate seat combobox
            //with available seats

            //clear cboSeats
            cboSeats.Items.Clear();
            cboSeats.Text = String.Empty;
            //get index from cboRows
            indexR = cboRows.SelectedIndex;
            //reference new Row object from Form1
            row = Form1.rows[indexR];
            //if structure to populate cboSeats
            if (row.RightSideWindowSeat == false)
            { cboSeats.Items.Add('A'); }
            if (row.RightSideAisleSeat == false)
            { cboSeats.Items.Add('B'); }
            if (row.LeftSideAisleSeat == false)
            { cboSeats.Items.Add('C'); }
            if (row.LeftSideWindowSeat == false)
            { cboSeats.Items.Add('D'); }
            if (cboSeats.Items.Count == 0)
            { MessageBox.Show("This row doesn't have any more seats available."); }
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
                { row.RightSideWindowSeat = true; }
                else if (indexS == 1)
                { row.RightSideAisleSeat = true; }
                else if (indexS == 2)
                { row.LeftSideAisleSeat = true; }
                else
                { row.LeftSideWindowSeat = true; }
                //update button from Form1
                Form1.buttons[indexR, indexS].BackColor = Color.Red;
                Form1.buttons[indexR, indexS].Enabled = false;
                //clear text from cboSeats to force update
                cboSeats.Items.Clear();
                cboSeats.Text = String.Empty;
                //clear text from combobox to force user to select another
                //row number and initialize the click event
                cboRows.Text = String.Empty;
                //display confirmation message
                MessageBox.Show("Your seats were booked!");
            }
            else
            { MessageBox.Show("Select a seat to book."); }
        }
    }
}
