using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string manipulation = comboBox_manipulation.Text;
            if (manipulation == "Insert")
                new form_insert().Show();
            else if (manipulation == "Delete")
                new delete().Show();
            else if (manipulation == "Update")
                new update().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            new search().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            new count().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new albums().Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
