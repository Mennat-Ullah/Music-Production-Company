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
    public partial class albums : Form
    {
        public albums()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //form 4
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=\"C:\\Program Files (x86)\\Microsoft SQL Server\\MSSQL10_50.SQLEXPRESS\\MSSQL\\DATA\\music production company.mdf\";Integrated Security=True;Connect Timeout=30;User Instance=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("album_songs", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@SongName", album_name.Text));
            SqlParameter output = new SqlParameter("@@COUNT", SqlDbType.Int);
            output.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(output);
            cmd.ExecuteScalar();
            MessageBox.Show("The number of songs is " + output.Value.ToString());
        }

        private void albums_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'music_production_companyDataSet2.Album' table. You can move, or remove it, as needed.
            this.albumTableAdapter.Fill(this.music_production_companyDataSet2.Album);

        }
    }
}
