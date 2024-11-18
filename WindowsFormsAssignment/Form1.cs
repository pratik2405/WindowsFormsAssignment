using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAssignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           String city=txtbox1.Text;
            if (city == null || city == " ")
            {
                MessageBox.Show("Cannot be empty");
            }
            else if (listbox1.Items.Contains(city.ToLower())|| listbox1.Items.Contains(city.ToUpper()))
            {
                MessageBox.Show("Already exit !");
                txtbox1.Clear();
            }
            else
            {
                listbox1.Items.Add(city);
                txtbox1.Clear();
                txtbox1.Focus();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listbox1.SelectedItem == null)
            {
                MessageBox.Show("No city selected !");
                return;
            }
            else
            {
                listbox1.Items.Remove(listbox1.SelectedItem);
            }
            
        }
    }
}
