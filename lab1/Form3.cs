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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        string strConn = "Data Source=MINH\\SQLEXPRESS;Database=STUDENT_MANAGEMENT;User ID=sa;password=minh1234";
        SqlConnection conn = null;

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            txtClassID.Text = "";
            txtClassName.Text = "";
            txtYear.Text = "";
            if(conn == null) 
                conn = new SqlConnection(strConn);
            if(conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = $"select * from Class where ClassID = '{txtEnterClassID.Text}'";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            if(reader.Read())
            {
                txtClassID.Text = reader.GetString(0);
                txtClassName.Text = reader.GetString(1);
                txtYear.Text = reader.GetInt32(2).ToString();
            }
            conn.Close();
        }

        private void btnViewStudent_Click(object sender, EventArgs e)
        {
            lsvStudents.Items.Clear();
            if (conn == null)
                conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand($"select * from STUDENT where ClassID = '{txtEnterClassID.Text}'", conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string studentID = reader.GetString(0);
                string name = reader.GetString(1);
                string classID = reader.GetString(2);
                ListViewItem item = new ListViewItem(studentID);

                item.SubItems.Add(name);
                item.SubItems.Add(classID);
                lsvStudents.Items.Add(item);
            }
            conn.Close();
        }
    }
}
