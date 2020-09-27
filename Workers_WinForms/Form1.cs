using System;
using System.Windows.Forms;
using BL;
using WorkersModel;
using System.Collections.Generic;

namespace Workers_WinForms
{
    public partial class Form1 : Form
    {
        Logic logic = new Logic();

        public Form1()
        {
            InitializeComponent();
            listBox1.DataSource = null;
            listBox1.DisplayMember = GetHashCode().ToString();
            listBox1.DataSource = logic.GetWorkers();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //кнопка добавить
            try
            {
                string inp = textBox1.Text;
                logic.AddWorker(inp);
                listBox1.DataSource = null;
                listBox1.DisplayMember = GetHashCode().ToString();
                listBox1.DataSource = logic.GetWorkers();
                label1.Text = "Add worker - ok";
            }
            catch
            {
                label1.Text = "Add Error";
            }
            
      
        }

        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string info = textBox1.Text;
                logic.RemoveWorker(info);
                listBox1.DataSource = null;
                listBox1.DisplayMember = "GetHashCode()";
                listBox1.DataSource = logic.GetWorkers();
                label1.Text = "Remove worker - ok";

            }
            catch
            {
                label1.Text = "Remove error";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            logic.SortByAge();
            listBox1.DataSource = null;
            listBox1.DisplayMember = "GetHashCode()";
            listBox1.DataSource = logic.GetWorkers();
            label1.Text = "Sort by age - ok";
        }
    }
}
