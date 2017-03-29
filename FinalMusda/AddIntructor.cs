using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalMusda
{
    public partial class AddIntructor : Form
    {
        Boolean flag;
        public AddIntructor()
        {
            InitializeComponent();
        }

        private void AddIntructor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cMSDataSet.INSTRUCTOR' table. You can move, or remove it, as needed.
            this.iNSTRUCTORTableAdapter.Fill(this.cMSDataSet.INSTRUCTOR);
            flag = true;
            this.Opacity = 0.1;
            timer1.Start();
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer();
            

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            flag = false;
            timer1.Start();
         
        }
        void timer()
        {
            if (flag)
            {
                if (this.Opacity <= 1.0)
                {
                    this.Opacity += 0.025;
                }
                else
                {
                    timer1.Stop();
                }
            }
            else
            {
                if (this.Opacity >= 0.0)
                {
                    this.Opacity -= 0.025;
                }
                else
                {
                    timer1.Stop();
                    this.Close();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            InstructorDetails panel = new InstructorDetails(this);
            panel.swipe(true);
        }
    }
}
