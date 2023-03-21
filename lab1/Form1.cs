using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        string strConn = "Data Source=MINH\\SQLEXPRESS;Initial Catalog=STUDENT_MANAGEMENT;Integrated Security=True";
        SqlConnection conn = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(strConn);
                conn.Open();
                MessageBox.Show("Thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"That bai: {ex.Message}");
                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(conn != null && conn.State == ConnectionState.Open) 
            {
                conn.Close();
                MessageBox.Show($"Ngat ket noi thanh cong");
            }
        }
    }
}
