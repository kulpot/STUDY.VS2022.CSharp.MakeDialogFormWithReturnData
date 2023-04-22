﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            using(Form2 form2 = new Form2())
            {
                if(form2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.Text = form2.SelectedText;
                }
            }
        }
    }
}
