using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;

namespace FinalMusda
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            line frm =new line();
            frm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Transition tran = new Transition(new TransitionType_EaseInEaseOut(2000));
            tran.add(pictureBox1, "Left", 400);
            tran.add(pictureBox1, "Top", 300);
            tran.run();

        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }
    }
}
