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
using MetroFramework;
using Transitions;
using System.IO;

namespace FinalMusda
{
    public partial class AddNew : pnlSlider
    {
        SqlConnection con = new SqlConnection("Data Source=CYRIL;Initial Catalog=CMS;Integrated Security=True");
        string gender;
        public AddNew(Form Owner): base(Owner)
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            swipe(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                try
                {

                    MemoryStream stream = new MemoryStream();
                    pictureBox2.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                    byte[] pic = stream.ToArray();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into AddChild (Name,Parent,Phone,Residence,gender,DOB,Image ) values(@Name,@Parent,@Phone,@Residence,@gender,@DOB,@Image )", con);

                    cmd.Parameters.AddWithValue("@Name", textName.Text);
                    cmd.Parameters.AddWithValue("@Parent", textParent.Text);
                    cmd.Parameters.AddWithValue("@Phone", textContact.Text);

                    cmd.Parameters.AddWithValue("@Residence", textResidence.Text);

                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@DOB", SqlDbType.Date).Value = DOB.Value.Date;
                    cmd.Parameters.AddWithValue("@Image", pic);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show( "Saved succesfully", "Message");

                    con.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else {
                enabling();
            }
        }
        void enabling()
        {
            textResidence.Enabled = true;
            textParent.Enabled = true;
            textName.Enabled = true;
            textContact.Enabled = true;

        }
       
        private void AddNew_Load(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "M";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "F";

        }

        private void textName_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(textName.Text))
            {
                e.Cancel = true;
                
                errorProvider1.SetError(textName, "Please enter Name");
            }
            else
            {
                enabling();
                errorProvider1.SetError(textName, null);
            }
        }

        private void textResidence_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textResidence.Text))
            {
                e.Cancel = true;



                errorProvider1.SetError(textResidence, "Please enter Residence");
            }
            else
            {
                enabling();
                errorProvider1.SetError(textResidence, null);
            }

        }

        private void textParent_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textParent.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textParent, "Please enter Parent Name");
            }
            else
            {
                enabling();
                errorProvider1.SetError(textParent, null);
            }
        }

        private void textContact_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textContact_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textContact.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textContact, "Please enter Name");
            }
            else
            {
                enabling();
                errorProvider1.SetError(textContact, null);
            }
        }

        private void radioButton1_Validating(object sender, CancelEventArgs e)
        {
        }

        private void textName_Click(object sender, EventArgs e)
        {
            textName.Focus();
        }

        private void textResidence_Click(object sender, EventArgs e)
        {
            textResidence.Focus();
        }

        private void textParent_Click(object sender, EventArgs e)
        {
            textParent.Focus();
        }

        private void textContact_Click(object sender, EventArgs e)
        {
            textContact.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg|*.jpg|PNG Files(*.png|*.png))";
            dlg.Title = "Select students Photo";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                String picpath = dlg.FileName.ToString();
               
                pictureBox2.ImageLocation = picpath;
            }
        }
    }
}
