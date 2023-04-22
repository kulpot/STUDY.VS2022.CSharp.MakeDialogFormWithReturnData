using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeDialogFormWithReturnData
{
    public partial class Form2 : Form
    {
        public string SelectedText { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.DialogResult = System.Windows.Forms.DialogResult.OK;
            //this.CLose()lock;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            SelectedText = radioButton1.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            SelectedText = radioButton2.Text;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            SelectedText = radioButton3.Text;
        }
    }
}
