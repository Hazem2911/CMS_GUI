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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cMSDataSet.EXPERTISE_AREA' table. You can move, or remove it, as needed.
            this.eXPERTISE_AREATableAdapter.Fill(this.cMSDataSet.EXPERTISE_AREA);
            SqlConnection sqlConnection = new SqlConnection("Data Source=HAZEM\\SQLEXPRESS;Initial Catalog=CMS;Integrated Security=True;Encrypt=True");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var instructorForm = new Instructor_Registration())
            {
                instructorForm.ShowDialog(this);
            }
        }

        private void Student_button_Click(object sender, EventArgs e)
        {
            using (var instructorForm = new Student_Registration())
            {
                instructorForm.ShowDialog(this);
            }
        }
    }
}
