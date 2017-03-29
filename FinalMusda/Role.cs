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
    public partial class Role : Form
    {
        public Role()
        {
            InitializeComponent();
        }

        private void Role_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cMSDataSet.INSTRUCTOR' table. You can move, or remove it, as needed.
            this.iNSTRUCTORTableAdapter.Fill(this.cMSDataSet.INSTRUCTOR);

        }
    }
}
