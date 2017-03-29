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

namespace FinalMusda
{
    public partial class iTechMessageBox :MetroFramework.Forms.MetroForm
    {
       
        public iTechMessageBox()
        {
            InitializeComponent();
        }
        static iTechMessageBox MsgBox;static DialogResult result=DialogResult.No;
        public static DialogResult Show (string Text,string Caption,string OK)
        {
            MsgBox = new iTechMessageBox();
            MsgBox.button2.Text = OK;
            MsgBox.label1.Text = Text;
            MsgBox.Text = Caption;
            MsgBox.ShowDialog();
            return result;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            result = DialogResult.Yes;MsgBox.Close();
        }

        private void iTechMessageBox_Load(object sender, EventArgs e)
        {
            
        }
    }

}
