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

    public partial class Form1 : Form
    {
        //************************GLOBAL VARIABLES*******************************
        //array of Rows
        public static Row[] rows = new Row[20];
        //array of letters (seats in the Row)
        char[] letters = { 'A', 'B', 'C', 'D' };
        //array of numbers (rows)
        int[] numbers = new int[20];
        //button matrix
        public static Button[,] buttons = new Button[20, 4];
        //matrix that holds seats' "names" (used on lblSeat)
        string[,] seats = new string[20, 4];
        //*****************************FORM1()***********************************
        public Form1()
        {
            InitializeComponent();
            //populate numbers array with 20 numbers
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }
            //load GUI
            CreateButtons();
            CreateLabel();
            CreateMoreLabels();
        }
        //**************************FORM LOAD***********************************
        private void Form1_Load(object sender, EventArgs e)
        {
            //populate rows array with 20 objects
            for (int i = 0; i < rows.Length; i++)
            {
                //all objects' fields will be false
                //see constructor in Row class
                rows[i] = new Row();
            }
            //add click event to all buttons
            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    buttons[i, j].Click += ClickEvent;
                }
            }
            //empty lblSeat
            lblSeat.Text = String.Empty;
        }
        //*****************************BUTTONS***********************************
        //button to complete booking
        private void btnComplete_Click(object sender, EventArgs e)
        {
            ConfirmSeats();
        }
        //button to open List.cs Form
        private void btnList_Click(object sender, EventArgs e)
        {
            //create List.cs form
            List _formList = new List();
            //display List.cs form
            _formList.ShowDialog();
            _formList.Dispose();
        }
        //button to open Seat Map
        private void btnMap_Click(object sender, EventArgs e)
        {

        }
        //*****************************METHODS***********************************
        //create buttons
        public void CreateButtons()
        {
            int x = 60;
            int y = 70;

            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Size = new Size(25, 25);
                    buttons[i, j].Location = new Point(x, y);
                    buttons[i, j].BackColor = Color.LightGreen;
                    if (j == 1)
                    { y += 50; }
                    else
                    { y += 30; }
                    this.Controls.Add(buttons[i, j]);
                }
                x += 30;
                y = 70;
            }
        }
        //create letter labels
        public void CreateLabel()
        {
            int x = 45;
            int y = 75;

            for (int i = 0; i < letters.Length; i++)
            {
                Label lbl = new Label();
                lbl.Location = new Point(x, y);
                lbl.Text = letters[i].ToString();
                if (i == 1)
                { y += 50; }
                else
                { y += 30; }
                this.Controls.Add(lbl);
            }
        }
        //create number labels
        public void CreateMoreLabels()
        {
            int x = 65;
            int y = 210;

            for (int i = 0; i < numbers.Length; i++)
            {
                Label lbl = new Label();
                lbl.Size = new Size(30, 20);
                lbl.Location = new Point(x, y);
                lbl.Text = numbers[i].ToString();
                x += 30;
                this.Controls.Add(lbl);
            }
        }
        //button click event
        public void ClickEvent(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int _i = 0;
            int _j = 0;
            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    //getting indexes if button is clicked
                    if (b == buttons[i, j])
                    {
                        _i = i;
                        _j = j;
                    }
                }
            }
            if (b.BackColor == Color.LightGreen)
            {
                b.BackColor = Color.Blue;
                seats[_i, _j] = Convert.ToString(letters[_j].ToString() + numbers[_i].ToString());
                lblSeat.Text = seats[_i, _j];
            }
            else
            {
                b.BackColor = Color.LightGreen;
                lblSeat.Text = seats[_i, _j];
                seats[_i, _j] = null;
            }
        }
        //change row's seat boolean value and button color
        public void ConfirmEvent()
        {
            for (int i = 0; i < seats.GetLength(0); i++)
            {
                for (int j = 0; j < seats.GetLength(1); j++)
                {
                    if (seats[i, j] != null)
                    {
                        buttons[i, j].BackColor = Color.Red;
                        buttons[i, j].Enabled = false;
                        if (j == 0)
                        { rows[i].RightSideWindowSeat = true; }
                        else if (j == 1)
                        { rows[i].RightSideAisleSeat = true; }
                        else if (j == 2)
                        { rows[i].LeftSideAisleSeat = true; }
                        else
                        { rows[i].LeftSideWindowSeat = true; }
                    }
                }
            }
        }
        //change selected buttons' color to green
        public void CancelEvent()
        {
            for (int i = 0; i < seats.GetLength(0); i++)
            {
                for (int j = 0; j < seats.GetLength(1); j++)
                {
                    if (seats[i, j] != null)
                    {
                        buttons[i, j].BackColor = Color.LightGreen;
                    }
                }
            }
        }
        //reset selected seats array
        public void ClearArray()
        {
            for (int i = 0; i < seats.GetLength(0); i++)
            {
                for (int j = 0; j < seats.GetLength(1); j++)
                {
                    if (seats[i, j] != null)
                    { seats[i, j] = null; }
                }
            }
        }
        //confirmation Dialog box
        private void ConfirmSeats()
        {
            string messageSeats = null;
            //create message string
            for (int i = 0; i < seats.GetLength(0); i++)
            {
                for (int j = 0; j < seats.GetLength(1); j++)
                {
                    if (seats[i,j] != null)
                    {
                        messageSeats += Convert.ToString(letters[j].ToString() +
                                                         numbers[i].ToString()+" ");
                    }
                }
            }
            // Initializes the variables to pass to the MessageBox.Show method.
            string message = "Confirm booking seats:\n" + messageSeats;
            string caption = "Booking confirmation";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                ConfirmEvent();
                ClearArray();
                MessageBox.Show("Your seats were booked!");
            }
            else
            {
                CancelEvent();
                ClearArray();
            }
        }

    }
}
