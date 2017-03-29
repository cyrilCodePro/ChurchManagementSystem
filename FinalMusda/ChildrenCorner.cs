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

namespace FinalMusda
{
    public partial class ChildrenCorner : Form
    {
        Boolean flag;
        public ChildrenCorner()
        {
            InitializeComponent();
        }

        private void ChildrenCorner_Load(object sender, EventArgs e)
        {
            
            flag = true;
            this.Opacity = 0.1;
            timer1.Start();
            // TODO: This line of code loads data into the 'cMSDataSet.AddChild' table. You can move, or remove it, as needed.
            this.addChildTableAdapter.Fill(this.cMSDataSet.AddChild);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AddNew panel = new AddNew(this);
            panel.swipe(true);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            flag = false;
            timer1.Start();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
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
                    timer1.Start();
                    this.Close();
                }
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PrintChildren frm = new PrintChildren();
            frm.Show();
        }

        private void addChildBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
