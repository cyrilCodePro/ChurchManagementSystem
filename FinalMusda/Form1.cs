using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Transitions;
using System.Data.Sql;
using System.Data.SqlClient;

namespace FinalMusda
{
    public partial class line :Form
    {
        SqlConnection con = new SqlConnection("Data Source=CYRIL;Initial Catalog=CMS;Integrated Security=True");
        
        public line()
        {
            InitializeComponent();
        }

        private void line_Load(object sender, EventArgs e)
        {
            timer1.Start();
            this.Opacity = 0.1;
            this.ActiveControl=label1;
        }

        private void textUser_TextChanged(object sender, EventArgs e)
        {
            
          
          
        }

        private void textUser_Click(object sender, EventArgs e)
        {
            if (textUser.Text=="Name")
            {
                label5.Visible = false;
                label6.Visible = false;
                label2.Visible = true;
                textUser.Text = "";

            }
           
        }

        private void textPassword_Click(object sender, EventArgs e)
        {
            if(textPassword.Text=="Password")
            {
                label5.Visible = false;
                label6.Visible = false;
                label3.Visible = true;
                textPassword.Text = "";
            }
            
        }

        private void textUser_Leave(object sender, EventArgs e)
        {
            if (textUser.Text=="")
            {
                label2.Visible = false;
                textUser.Text = "Name";
            }
           
        }

        private void textPassword_Leave(object sender, EventArgs e)
        {
            if (textPassword.Text == "")
            {
                label3.Visible = false;
                textPassword.Text = "Password";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("Select UserName,Password from LOGIN where Username='"+textUser.Text+"' and Password='"+textPassword.Text+"'",con);
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                label5.Visible = false;
                label6.Visible = false;
               
          
                MainInterface panel = new MainInterface(this);
                panel.swipe(true);
            }
            else
            {
                label5.Visible = true;
                label6.Visible = true;
                label5.Text = "*Wrong User*";
                label6.Text = "*Wrong Password*";
            }
            con.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to exit","Message",MessageBoxButtons.YesNo)==DialogResult.Yes)
            { 
                Application.Exit();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(this.Opacity <=1.0)
            {
                this.Opacity += 0.025;
            }
            else
            {
                timer1.Stop();
            }
        }
    }
}
