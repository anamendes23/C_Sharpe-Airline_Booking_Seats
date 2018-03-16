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
    public partial class Map : Form
    {
        public Map()
        {
            InitializeComponent();
        }
        //**************************MAP FORM LOAD*********************************
        private void Map_Load(object sender, EventArgs e)
        {
            CreateSeatMap();
        }
        //**************************METHODS*************************************
        //create labels
        public void CreateSeatMap()
        {
            //origin
            int x = 60;
            int y = 70;
            //nested loop to run through button matrix
            for (int i = 0; i < Form1.buttons.GetLength(0); i++)
            {
                for (int j = 0; j < Form1.buttons.GetLength(1); j++)
                {
                    //create new label
                    Label seat = new Label();
                    seat.Size = new Size(25, 25);
                    seat.Location = new Point(x, y);
                    PrintCondition(j, i, seat);
                    //increment for y
                    if (j == 1)
                    { y += 50; }
                    else
                    { y += 30; }
                    //add label to Form
                    this.Controls.Add(seat);
                }
                //increment for x
                x += 30;
                //reset y
                y = 70;
            }
        }
        //conditional statement to print either "_" or "X"
        public void PrintCondition(int j, int i, Label seat)
        {
            //switch to determine with case of j (seats in the row) is evaluated
            switch(j)
            {
                case 0:
                    //if statement to check if prints "_" or "X"
                    if(Form1.rows[i].RightSideWindowSeat == false)
                    { seat.Text = "_"; }
                    else
                    { seat.Text = "X"; }
                    break;
                case 1:
                    //if statement to check if prints "_" or "X"
                    if (Form1.rows[i].RightSideAisleSeat == false)
                    { seat.Text = "_"; }
                    else
                    { seat.Text = "X"; }
                    break;
                case 2:
                    //if statement to check if prints "_" or "X"
                    if (Form1.rows[i].LeftSideAisleSeat == false)
                    { seat.Text = "_"; }
                    else
                    { seat.Text = "X"; }
                    break;
                case 3:
                    //if statement to check if prints "_" or "X"
                    if (Form1.rows[i].LeftSideWindowSeat == false)
                    { seat.Text = "_"; }
                    else
                    { seat.Text = "X"; }
                    break;
                default:
                    break;
            }
        }
    }
}
