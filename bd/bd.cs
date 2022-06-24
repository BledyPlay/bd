using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace bd
{
    public partial class bd : Form
    {
        SqlConnection ee = new SqlConnection(@"");
        public bd()
        {
            InitializeComponent();
        }

        private void btback_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 main = new Form1();
            main.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Text = "dsfs";
            if (ee.State == System.Data.ConnectionState.Closed)
            {
                ee.Open();
            }
            string s = $"SELECT * from {comboBox1.Text} ";
            SqlCommand cmd = new SqlCommand(s, ee);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            ee.Close();
        }
    }
}
