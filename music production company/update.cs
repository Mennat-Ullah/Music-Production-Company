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
    public partial class update : Form
    {
        public update()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //update code
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=\"C:\\Program Files (x86)\\Microsoft SQL Server\\MSSQL10_50.SQLEXPRESS\\MSSQL\\DATA\\music production company.mdf\";Integrated Security=True;Connect Timeout=30;User Instance=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("update_album_editions", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@Album_name", album_name.Text));
            cmd.Parameters.Add(new SqlParameter("@editions", edition.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("The row is updated");
            con.Close();
        }

        private void update_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'music_production_companyDataSet.Album' table. You can move, or remove it, as needed.
            this.albumTableAdapter.Fill(this.music_production_companyDataSet.Album);

        }
    }
}
