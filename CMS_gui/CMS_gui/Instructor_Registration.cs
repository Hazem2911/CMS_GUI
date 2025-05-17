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

namespace CMS_gui
{
    public partial class Instructor_Registration : Form
    {
        public Instructor_Registration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Instructor_Registration_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fname = textBox1.Text.Trim();
            string lname = textBox5.Text.Trim();
            string email = textBox4.Text.Trim();
            string officeHours = textBox3.Text.Trim();
            string areaName = textBox2.Text.Trim(); 

            if (string.IsNullOrWhiteSpace(fname) ||
                string.IsNullOrWhiteSpace(lname) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(officeHours) ||
                string.IsNullOrWhiteSpace(areaName))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            using (SqlConnection sqlConnection = new SqlConnection("Data Source=HAZEM\\SQLEXPRESS;Initial Catalog=CMS;Integrated Security=True;Encrypt=False"))
            {
                sqlConnection.Open();

                int areaId;
                using (SqlCommand cmdArea = new SqlCommand(
                    "SELECT AREA_ID FROM EXPERTISE_AREA WHERE AREA_NAME = @area_name", sqlConnection))
                {
                    cmdArea.Parameters.AddWithValue("@area_name", areaName);
                    object result = cmdArea.ExecuteScalar();
                    if (result == null)
                    {
                        MessageBox.Show("Expertise area not found.");
                        return;
                    }
                    areaId = (int)result;
                }

                int userId;
                using (SqlCommand cmdUSER = new SqlCommand(
                    "INSERT INTO [USER] (USER_FNAME, USER_LNAME, USER_EMAIL) OUTPUT INSERTED.USER_ID VALUES (@fname, @lname, @email)", sqlConnection))
                {
                    cmdUSER.Parameters.AddWithValue("@fname", fname);
                    cmdUSER.Parameters.AddWithValue("@lname", lname);
                    cmdUSER.Parameters.AddWithValue("@email", email);

                    userId = (int)cmdUSER.ExecuteScalar();
                }

                using (SqlCommand cmdINSTRUCTOR = new SqlCommand(
                    "INSERT INTO INSTRUCTOR (USER_ID, USER_FNAME, USER_LNAME, USER_EMAIL, OFFICE_HOURS) VALUES (@id, @fname, @lname, @email, @office_hours)", sqlConnection))
                {
                    cmdINSTRUCTOR.Parameters.AddWithValue("@id", userId);
                    cmdINSTRUCTOR.Parameters.AddWithValue("@fname", fname);
                    cmdINSTRUCTOR.Parameters.AddWithValue("@lname", lname);
                    cmdINSTRUCTOR.Parameters.AddWithValue("@email", email);
                    cmdINSTRUCTOR.Parameters.AddWithValue("@office_hours", officeHours);

                    cmdINSTRUCTOR.ExecuteNonQuery();
                }

                using (SqlCommand cmdIS_EXPERT_IN = new SqlCommand(
                    "INSERT INTO IS_EXPERT_IN (USER_ID, AREA_ID) VALUES (@user_id, @area_id)", sqlConnection))
                {
                    cmdIS_EXPERT_IN.Parameters.AddWithValue("@user_id", userId);
                    cmdIS_EXPERT_IN.Parameters.AddWithValue("@area_id", areaId);

                    cmdIS_EXPERT_IN.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Instructor registered successfully!");
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
