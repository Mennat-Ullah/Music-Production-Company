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
    public partial class form_insert : Form
    {
        public form_insert()
        {
            InitializeComponent();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=\"C:\\Program Files (x86)\\Microsoft SQL Server\\MSSQL10_50.SQLEXPRESS\\MSSQL\\DATA\\music production company.mdf\";Integrated Security=True;Connect Timeout=30;User Instance=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("insert_album_info", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@Album_name", album_name.Text));
            cmd.Parameters.Add(new SqlParameter("@Album_Release_Date", dateTimePicker1.Value));
            cmd.Parameters.Add(new SqlParameter("@Num_of_Editions", Num_of_editions.Text));
            cmd.Parameters.Add(new SqlParameter("@Quantity", quantity.Text));

            cmd.ExecuteNonQuery();
            MessageBox.Show("The insertion is done");
            con.Close();
        }
    }
}
