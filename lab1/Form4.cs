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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        string strConn = "Data Source=MINH\\SQLEXPRESS;Database=STUDENT_MANAGEMENT;User ID=sa;password=minh1234";
        SqlConnection conn = null;
        private void Form4_Load(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand("select * from Class", conn);

            lsbClasses.ClearSelected();
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                string classID = reader.GetString(0);
                string className = reader.GetString(1);
                int year = reader.GetInt32(2);
                string line = $"{classID}-{className}-{year}";
                lsbClasses.Items.Add(line);
            }
            conn.Close();
        }

        private void lsbClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsvStudents.Items.Clear();
            if (lsbClasses.SelectedIndex == -1) return;
            string line = lsbClasses.SelectedItem.ToString();
            string[] arr = line.Split('-');
            string classID = arr[0];

            if (conn == null)
                conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand($"select * from STUDENT where ClassID = '{classID}'", conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string studentID = reader.GetString(0);
                string name = reader.GetString(1);
                string classIDRow = reader.GetString(2);
                ListViewItem item = lsvStudents.Items.Add(studentID);
                item.SubItems.Add(name);
                item.SubItems.Add(classIDRow);
            }
            conn.Close();
        }
    }
}
