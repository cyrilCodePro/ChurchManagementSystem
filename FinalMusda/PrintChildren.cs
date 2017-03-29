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
    public partial class PrintChildren : MetroFramework.Forms.MetroForm
    {
        public PrintChildren()
        {
            InitializeComponent();
        }

        private void PrintChildren_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'CMSDataSet.AddChild' table. You can move, or remove it, as needed.
            this.AddChildTableAdapter.Fill(this.CMSDataSet.AddChild);

            this.reportViewer1.RefreshReport();
        }
    }
}
