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
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }

        private void search_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=\"C:\\Program Files (x86)\\Microsoft SQL Server\\MSSQL10_50.SQLEXPRESS\\MSSQL\\DATA\\music production company.mdf\";Integrated Security=True;Connect Timeout=30;User Instance=True");
            con.Open();
            // new command
            SqlCommand cmd = new SqlCommand("song_info", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@song_name ", songname.Text));
            // new reder 
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                s_album.Text = (string)reader["name"];
                string occ = (string)reader["occupation"],
                    name = (string)reader["first_name"] + " " + (string)reader["last_name"];

                if (occ == "singer")
                {
                    s_singer.Text = name;
                }
                else if (occ == "composer")
                {
                    s_composer.Text = name;
                }
                else if (occ == "writer")
                {
                    s_writer.Text = name;
                }
            }
            reader.Close();
            con.Close();

        }
    }
}
