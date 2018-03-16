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
        public static char[] letters = { 'A', 'B', 'C', 'D' };
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
            //create Map.cs form
            Map _formMap = new Map();
            //display Map.cs form
            _formMap.ShowDialog();
            _formMap.Dispose();
        }
        //*****************************METHODS***********************************
        //create buttons
        public void CreateButtons()
        {
            //origin
            int x = 60;
            int y = 70;
            //nested loop to run through button matrix
            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    //create new button
                    buttons[i, j] = new Button();
                    buttons[i, j].Size = new Size(25, 25);
                    buttons[i, j].Location = new Point(x, y);
                    buttons[i, j].BackColor = Color.LightGreen;
                    //increment for y
                    if (j == 1)
                    { y += 50; }
                    else
                    { y += 30; }
                    //add button to Form
                    this.Controls.Add(buttons[i, j]);
                }
                //increment for x
                x += 30;
                //reset y
                y = 70;
            }
        }
        //create letter labels
        public void CreateLabel()
        {
            //origin
            int x = 45;
            int y = 75;
            //loop that goes through letters array (seats in a row)
            for (int i = 0; i < letters.Length; i++)
            {
                //create new label
                Label lbl = new Label();
                lbl.Location = new Point(x, y);
                lbl.Text = letters[i].ToString();
                //increment for y
                if (i == 1)
                { y += 50; }
                else
                { y += 30; }
                //add label to Form
                this.Controls.Add(lbl);
            }
        }
        //create number labels
        public void CreateMoreLabels()
        {
            //origin
            int x = 65;
            int y = 210;
            //loop that goes through numbers array (rows in airplane)
            for (int i = 0; i < numbers.Length; i++)
            {
                //create new label
                Label lbl = new Label();
                lbl.Size = new Size(30, 20);
                lbl.Location = new Point(x, y);
                lbl.Text = numbers[i].ToString();
                //increment for x
                x += 30;
                //add label to Form
                this.Controls.Add(lbl);
            }
        }
        //button click event
        public void ClickEvent(object sender, EventArgs e)
        {
            //create button object for method
            Button b = (Button)sender;
            //create variables to hold indexes of button clicked
            int _i = 0;
            int _j = 0;
            //nested loop too go through buttons matrix
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
            //condition to change button color from green to blue
            if (b.BackColor == Color.LightGreen)
            {
                //change color to ble
                b.BackColor = Color.Blue;
                //add to the string matrix the name of the seat
                seats[_i, _j] = Convert.ToString(letters[_j].ToString() + numbers[_i].ToString());
                //assign string to label
                lblSeat.Text = seats[_i, _j];
            }
            //change button color from blue to green
            else
            {
                b.BackColor = Color.LightGreen;
                //label still displays seat name
                lblSeat.Text = seats[_i, _j];
                //empty position for this seat because it's not selected anymore
                seats[_i, _j] = null;
            }
        }
        //change row's seat boolean value and button color
        public void ConfirmEvent()
        {
            //nested loop to go through seats matrix and check which seats where
            //selected to book
            for (int i = 0; i < seats.GetLength(0); i++)
            {
                for (int j = 0; j < seats.GetLength(1); j++)
                {
                    //if the seat has a string associated, it means the button
                    //of the seat was clicked 
                    if (seats[i, j] != null)
                    {
                        //turns button color to red and disable it
                        buttons[i, j].BackColor = Color.Red;
                        buttons[i, j].Enabled = false;
                        //change row's field value to true
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
            //nested loop to go through seats matrix and check which seats where
            //selected first to reset their color to green
            for (int i = 0; i < seats.GetLength(0); i++)
            {
                for (int j = 0; j < seats.GetLength(1); j++)
                {
                    //if the seat has a string associated, it means the button
                    //of the seat was clicked 
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
            //nested loop to go through seats matrix and clear all elements
            //that are not null to reuse matrix to next booking event
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
            //create message string variable to hold seats selected
            string messageSeats = null;
            //nested loop to go through seats matrix and get position of the ones
            //that are not null to add label to message string
            for (int i = 0; i < seats.GetLength(0); i++)
            {
                for (int j = 0; j < seats.GetLength(1); j++)
                {
                    if (seats[i,j] != null)
                    {
                        //assign value to message string
                        messageSeats += Convert.ToString(letters[j].ToString() +
                                                         numbers[i].ToString()+" ");
                    }
                }
            }
            //initializes the variables to pass to the MessageBox.Show method.
            string message = "Confirm booking seats:\n" + messageSeats;
            string caption = "Booking confirmation";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result;
            //displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            //condition to determine actions for each button clicked
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                //change row's seat boolean value and button color
                ConfirmEvent();
                //reset selected seats array
                ClearArray();
                //display confirmation message
                MessageBox.Show("Your seats were booked!");
            }
            else
            {
                //change selected buttons' color to green
                CancelEvent();
                //reset selected seats array
                ClearArray();
            }
        }

    }
}
