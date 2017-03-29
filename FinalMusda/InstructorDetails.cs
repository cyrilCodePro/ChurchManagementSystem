using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace FinalMusda
{
    public partial class InstructorDetails : pnlSlider
    {
        string Gender;
        SqlConnection con = new SqlConnection("Data Source=CYRIL;Initial Catalog=CMS;Integrated Security=True");
        public InstructorDetails( Form Owner):base(Owner)
        {
            InitializeComponent();
        }

        private void textName_Click(object sender, EventArgs e)
        {
            if(textName.Text=="Name")
            {
                label1.Visible = true;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                textName.Text = "";
            }
        }

        private void textName_Leave(object sender, EventArgs e)
        {
            if(textName.Text=="")
            {
                label1.Visible = false;
                textName.Text = "Name";
            }
        }

        private void textEmail_Click(object sender, EventArgs e)
        {
            if (textEmail.Text == "Email")
            {
                label2.Visible = true;
                label1.Visible = false;
               
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                textEmail.Text = "";
            }
        }

        private void textEmail_Leave(object sender, EventArgs e)
        {
            if(textEmail.Text=="")
            {
                label2.Visible = false;
                textEmail.Text = "Email";
            }
        }

        private void textPhone_Click(object sender, EventArgs e)
        {
            if(textPhone.Text=="Phone")
            {
                label3.Visible = true;
                textPhone.Text = "";
                label1.Visible = false;
                label2.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
              
            }
        }

        private void textPhone_Leave(object sender, EventArgs e)
        {
            if(textPhone.Text=="")
            {
                label3.Visible = false;
                textPhone.Text = "Phone";
            }
        }

        private void textResidence_Click(object sender, EventArgs e)
        {
            if(textResidence.Text=="Residence")
            {
                label4.Visible = true;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
               
                label5.Visible = false;
                textResidence.Text = "";
            }
        }

        private void textResidence_Leave(object sender, EventArgs e)
        {
            if(textResidence.Text=="")
            {
                label4.Visible = false;
                textResidence.Text = "Residence";
            }
        }

        private void textAcademicYear_Click(object sender, EventArgs e)
        {
            if(textAcademicYear.Text=="Academic Year")
            {
                label5.Visible = true;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
             
                textAcademicYear.Text = "";
            }
        }

        private void textAcademicYear_Leave(object sender, EventArgs e)
        {
            if(textAcademicYear.Text=="")
            {
                label5.Visible = false;
                textAcademicYear.Text = "Academic Year";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void InstructorDetails_Load(object sender, EventArgs e)
        {

            label4.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;

            label5.Visible = false;
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (emailChurch.checkForEmail(textEmail.Text.ToString()))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("insert into INSTRUCTOR (Name,Email,Residence,Year,Phone,Gender) VALUES(@Name,@Email,@Residence,@Year,@Phone,@Gender)",con);
                    cmd.Parameters.AddWithValue("@Name", textName.Text);
                    cmd.Parameters.AddWithValue("@Email", textEmail.Text);
                    cmd.Parameters.AddWithValue("@Residence", textResidence.Text);
                    cmd.Parameters.AddWithValue("@Year", textAcademicYear.Text);
                    cmd.Parameters.AddWithValue("@Phone", textPhone.Text);
                    cmd.Parameters.AddWithValue("@Gender", Gender);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Saved ");
                }
                else
                {
                    MessageBox.Show("Invalid Email");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            swipe(false);
        }

        private void male_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "M";
        }

        private void Female_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "F";
        }
    }
}
