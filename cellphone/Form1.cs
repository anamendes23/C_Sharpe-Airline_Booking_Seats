using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cellphone
{
    public partial class Form1 : Form
    {
        List<Person> people = new List<Person>();
        //plan array
        string[] plans = { "Single Caller","The Player","Ted's Plan", "The Reporter",
                           "Maple Syrup", "Hockey", "Broken Architecture", "Love Plan",
                           "The Besties", "Secret Phone", "The Lawyer", "Family Plan" };
        //global index for person selected
        int index = 0;
        public Form1()
        {
            InitializeComponent();
        }
        //**************************FORM LOAD***********************************
        private void Form1_Load(object sender, EventArgs e)
        {
            //*******PERSON 1********
            Person p1 = new Person("Barney","Stinson");
            CellPhone cellPhone = new CellPhone("Samsung", "T-mobile", 102.99m,"Single Caller", "(432) 123-4567");
            p1.AddCellPhone(cellPhone);
            cellPhone = new CellPhone("Apple", "At&t", 163.93m, "The Player", "(432) 403-5555");
            p1.AddCellPhone(cellPhone);
            cellPhone = new CellPhone("Motorola", "Verizon", 84.32m, "Ted's Plan", "(435) 153-4247");
            p1.AddCellPhone(cellPhone);
            people.Add(p1);
            //*******PERSON 2********
            p1 = new Person("Robin", "Scherb");
            cellPhone = new CellPhone("Samsung", "T-mobile", 206.99m, "The Reporter", "(642) 412-4326");
            p1.AddCellPhone(cellPhone);
            cellPhone = new CellPhone("Apple", "At&t", 62.93m, "Maple Syrup", "(642) 562-5346");
            p1.AddCellPhone(cellPhone);
            cellPhone = new CellPhone("Motorola", "Verizon", 103.23m, "Hockey", "(642) 876-4323");
            p1.AddCellPhone(cellPhone);
            people.Add(p1);
            //*******PERSON 3********
            p1 = new Person("Ted", "Mosby");
            cellPhone = new CellPhone("Samsung", "T-mobile", 102.99m, "Single Caller", "(234) 421-4432");
            p1.AddCellPhone(cellPhone);
            cellPhone = new CellPhone("Apple", "At&t", 30.00m, "Broken Architecture", "(234) 212-5555");
            p1.AddCellPhone(cellPhone);
            cellPhone = new CellPhone("Motorola", "Verizon", 84.32m, "Ted's Plan", "(234) 342-2341");
            p1.AddCellPhone(cellPhone);
            people.Add(p1);
            //*******PERSON 4********
            p1 = new Person("Lily", "Aldrin");
            cellPhone = new CellPhone("Samsung", "T-mobile", 150.99m, "Love Plan", "(433) 324-4241");
            p1.AddCellPhone(cellPhone);
            cellPhone = new CellPhone("Apple", "At&t", 132.93m, "The Besties", "(433) 354-5325");
            p1.AddCellPhone(cellPhone);
            cellPhone = new CellPhone("Motorola", "Verizon", 203.92m, "Secret Phone", "(433) 165-4223");
            p1.AddCellPhone(cellPhone);
            people.Add(p1);
            //*******PERSON 5********
            p1 = new Person("Marshall", "Eriksen");
            cellPhone = new CellPhone("Samsung", "T-mobile", 150.99m, "Love Plan", "(433) 243-4567");
            p1.AddCellPhone(cellPhone);
            cellPhone = new CellPhone("Apple", "At&t", 234.53m, "The Lawyer", "(433) 403-3215");
            p1.AddCellPhone(cellPhone);
            cellPhone = new CellPhone("Motorola", "Verizon", 354.32m, "Family Plan", "(433) 153-4237");
            p1.AddCellPhone(cellPhone);
            people.Add(p1);

            //populate plans combobox
            foreach (string plan in plans)
            {
                cboPlans.Items.Add(plan);
            }
        }
        //**********************BUTTON DISPLAY PEOPLE***************************
        private void btnDisplayPeople_Click(object sender, EventArgs e)
        {
            DisplayPeople();
        }
        //***********************LIST SELECTED EVENT****************************
        private void ltbPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            //clear cellphone list
            ltbCellPhones.Items.Clear();
            //get index from person selected
            index = ltbPeople.SelectedIndex;
            //add cellphones to cellphone list
            CellPhone[] array = people[index].CellPhone;
            for (int i = 0; i < array.Length; i++)
            {
                //string to hold message to listbox
                string cellphone = array[i].Brand + "\t" + "  " +
                                   array[i].Carrier + "\t" + "   " +
                                   array[i].Plan + "\t" +
                                   array[i].Price.ToString("c");
                //add string to list
                ltbCellPhones.Items.Add(cellphone);
            }
        }
        //**********************BUTTON DISPLAY PEOPLE***************************
        private void btnUpdatePlan_Click(object sender, EventArgs e)
        {
            if (ltbCellPhones.SelectedIndex != -1)
            {
                //get index of selected cellphone
                int ic = ltbCellPhones.SelectedIndex;
                if(cboPlans.SelectedIndex != -1)
                {
                    //get index of selected plan
                    int ip = cboPlans.SelectedIndex;
                    people[index].CellPhone[ic].Plan = plans[ip];
                }
                else
                { MessageBox.Show("Select a plan to update."); }
            }
            else
            { MessageBox.Show("Select a cellphone to update plan."); }
            //update cellphone list for selected person
            ltbPeople_SelectedIndexChanged(this, e);
        }
        //**************************METHODS*************************************
        //method to display people in listbox
        private void DisplayPeople()
        {
            foreach (Person p in people)
            {
                string person = p.LastName + "\t\t"+
                                p.FirstName + "\t\t" +
                                p.GetTotalPayment().ToString("c");
                ltbPeople.Items.Add(person);
            }
        }
    }
}
