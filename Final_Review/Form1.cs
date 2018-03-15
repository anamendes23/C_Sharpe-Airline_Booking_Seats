using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Review
{
    public partial class Form1 : Form
    {
        //1. create array
        int[] array = { 3, -7, 23, 12, -4, -18, 28, -15, 21 };
        //2. Method
        public int LargestIndex(int[] array)
        {
            int index = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[index])
                { index = i; }
            }
            return index;
        }
        //3. Crazy method
        public void Lala(out int value, out int index, int[] array)
        {
            index = LargestIndex(array);
            value = array[index];            
        }
        //4. method random array
        public int[] RandomArray(int size)
        {
            Random rand = new Random();
            int[] randoms = new int[size];
            for (int i = 0; i < size; i++)
            {
                randoms[i] = rand.Next(1, 50);
            }
            return randoms;
        }
        //5. method print richtextbox
        public void Display(int[] array)
        {
            richTextBox1.Clear();
            foreach (int item in array)
            {
                richTextBox1.Text += item + " ";
            }
        }
        //6. A default constructor is a constructor that takes no parameters.
        //Classes without constructors are given a public default constructor 
        //by the C# compiler in order to enable class instantiation
        //7. One
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int index;
            int value;
            Lala(out value, out index, array);
            textBox1.Text = value +" " + index;
            Display(array);
        }
    }
}
