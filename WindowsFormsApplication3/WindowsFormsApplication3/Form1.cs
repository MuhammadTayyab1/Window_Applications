using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Entry test");
            comboBox1.Items.Add("Semester 1");
            comboBox1.Items.Add("Semester 2");
            button3.Hide();
            label2.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button3.Show();
            listBox2.Items.Add(listBox1.SelectedItem.ToString());
            listBox1.Items.Remove(listBox1.SelectedItem.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(listBox2.SelectedItem.ToString());
            listBox2.Items.Remove(listBox2.SelectedItem.ToString());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem.ToString() =="Entry test")
            {
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                listBox1.Items.Add("Urdu");
                listBox1.Items.Add("English");
                listBox1.Items.Add("Math");
                listBox1.Items.Add("Pyhsics");
                listBox1.Items.Add("Chemistry");
            }
            else if (comboBox1.SelectedItem.ToString() == "Semester 1")
            {
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                listBox1.Items.Add("PF");
                listBox1.Items.Add("IICT");
                listBox1.Items.Add("VLM");
                listBox1.Items.Add("PIS");
                listBox1.Items.Add("E1");
            }
            else if (comboBox1.SelectedItem.ToString()=="Semester 2")
            {
                listBox1.Items.Clear();
                listBox2.Items.Clear();

                listBox1.Items.Add("OOP");
                listBox1.Items.Add("BE");
                listBox1.Items.Add("Algebra");
                listBox1.Items.Add("FA");
                listBox1.Items.Add("POM");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Show();
        }
    }
}
