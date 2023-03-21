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
    public partial class Form2 : Form
    {
        string strConn = "Data Source=MINH\\SQLEXPRESS;Initial Catalog=STUDENT_MANAGEMENT;Integrated Security=True";
        SqlConnection conn = null;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (conn == null) conn = new SqlConnection(strConn);
            if(conn.State == ConnectionState.Closed) conn.Open();

            SqlCommand command = new SqlCommand($"select count(*) from STUDENT where ClassID = '{txtClassID.Text}'", conn);

            int result = (int) command.ExecuteScalar();
            MessageBox.Show($"Lớp {txtClassID.Text} có {result.ToString()} sinh viên");
            txtNumbers.Text = result.ToString();
            conn.Close();
        }
    }
}
