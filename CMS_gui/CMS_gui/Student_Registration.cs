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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CMS_gui
{
    public partial class Student_Registration : Form
    {
        public Student_Registration()
        {
            InitializeComponent();
        }

        private void Student_Registration_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fname = textBox1.Text.Trim();
            string lname = textBox5.Text.Trim();
            string email = textBox4.Text.Trim();
            string enrollmentYear = textBox2.Text.Trim();

            if (string.IsNullOrWhiteSpace(fname) ||
                string.IsNullOrWhiteSpace(lname) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(enrollmentYear))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            using (SqlConnection sqlConnection = new SqlConnection("Data Source=HAZEM\\SQLEXPRESS;Initial Catalog=CMS;Integrated Security=True;Encrypt=False"))
            {
                sqlConnection.Open();

                int userId;
                using (SqlCommand cmdUSER = new SqlCommand(
                    "INSERT INTO [USER] (USER_FNAME, USER_LNAME, USER_EMAIL) OUTPUT INSERTED.USER_ID VALUES (@fname, @lname, @email)", sqlConnection))
                {
                    cmdUSER.Parameters.AddWithValue("@fname", fname);
                    cmdUSER.Parameters.AddWithValue("@lname", lname);
                    cmdUSER.Parameters.AddWithValue("@email", email);

                    userId = (int)cmdUSER.ExecuteScalar();
                }

                using (SqlCommand cmdSTUDENT = new SqlCommand(
                    @"INSERT INTO [STUDENT]([USER_ID], [USER_FNAME], [USER_LNAME], [USER_EMAIL], [ENROLLMENT_YEAR])
              SELECT @UserID, [USER].[USER_FNAME], [USER].[USER_LNAME], [USER].[USER_EMAIL], @enrollmentYear
              FROM [USER] 
              WHERE @UserID = [USER].[USER_ID];", sqlConnection))
                {
                    cmdSTUDENT.Parameters.AddWithValue("@UserID", userId);
                    cmdSTUDENT.Parameters.AddWithValue("@enrollmentYear", enrollmentYear);

                    cmdSTUDENT.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Student registered successfully!");
            this.Close();
        }
    }
}
