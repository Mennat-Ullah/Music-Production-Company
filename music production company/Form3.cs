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
    public partial class count : Form
    {
        public count()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sCount_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=\"C:\\Program Files (x86)\\Microsoft SQL Server\\MSSQL10_50.SQLEXPRESS\\MSSQL\\DATA\\music production company.mdf\";Integrated Security=True;Connect Timeout=30;User Instance=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("songs_cust_count", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@firstName", first_name.Text));
            cmd.Parameters.Add(new SqlParameter("@lastName", last_name.Text));
            cmd.Parameters.Add(new SqlParameter("@occupation", comboBox_occupation.Text));
            SqlParameter output = new SqlParameter("@@COUNT", SqlDbType.Int);
            output.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(output);
            cmd.ExecuteScalar();
            MessageBox.Show( "The number of songs is " + output.Value.ToString());
        }
    }
}
