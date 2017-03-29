using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace FinalMusda
{
    public partial class MainInterface :pnlSlider
    {
        Boolean flag;
        public MainInterface(Form Owner):base(Owner)
        {
            InitializeComponent();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            DirectorCorner frm = new DirectorCorner();
            frm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            swipe(false);

        }

        private void MainInterface_Load(object sender, EventArgs e)
        {

        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            ChildrenCorner frm = new ChildrenCorner();
            frm.Show();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            AddIntructor frm = new AddIntructor();
            frm.Show();
        }
    }
}
