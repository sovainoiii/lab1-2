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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        string strConn = "Data Source=MINH\\SQLEXPRESS;Database=STUDENT_MANAGEMENT;User ID=sa;password=minh1234";
        SqlConnection conn = null;
        private void Form5_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        int result = -1;
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand("insert into Student(StudentID, Name, ClassID) values(@StudentID, @Name, @ClassID)", conn);
            SqlParameter parameter1 = new SqlParameter("@StudentID", txtStudentID.Text);
            SqlParameter parameter2 = new SqlParameter("@Name", txtName.Text);
            SqlParameter parameter3 = new SqlParameter("@ClassID", txtClassID.Text);

            command.Parameters.Add(parameter1);
            command.Parameters.Add(parameter2);
            command.Parameters.Add(parameter3);
            try
            {
                result = command.ExecuteNonQuery();
                MessageBox.Show("Insert a record success!");
                LoadData();
                ClearText();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message + "\nInsert a record faild!");
            }
            conn.Close();
        } 

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand($"update Student set Name = '{txtName.Text}', ClassID = '{txtClassID.Text}' where StudentID = '{txtStudentID.Text}'", conn);
            try
            {
                result = command.ExecuteNonQuery();
                MessageBox.Show("Update a record success!");
                LoadData();
                ClearText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nUpdate a record faild!");
            }
            conn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand($"delete from Student where StudentID = '{txtStudentID.Text}'", conn);
            try
            {
                result = command.ExecuteNonQuery();
                LoadData();
                ClearText();
                MessageBox.Show("Delete a record success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nDelete a record faild!");
            }
        }

        private void lsvStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvStudents.SelectedItems.Count > 0)
            {
                txtStudentID.Text = lsvStudents.SelectedItems[0].SubItems[0].Text;
                txtName.Text = lsvStudents.SelectedItems[0].SubItems[1].Text;
                txtClassID.Text = lsvStudents.SelectedItems[0].SubItems[2].Text;
            }
        }
        private void LoadData()
        {
            lsvStudents.Items.Clear();
            if (conn == null)
                conn = new SqlConnection(strConn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand("select * from Student", conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string studentID = reader.GetString(0);
                string name = reader.GetString(1);
                string classID = reader.GetString(2);
                ListViewItem item = lsvStudents.Items.Add(studentID);
                item.SubItems.Add(name);
                item.SubItems.Add(classID);
            }
            conn.Close();
        }
        private void ClearText()
        {
            txtStudentID.Text = "";
            txtName.Text = "";
            txtClassID.Text = "";
        }
    }
}
