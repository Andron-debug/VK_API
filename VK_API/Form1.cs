﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VK_API
{
    public partial class Start_form : Form
    {
        public Start_form()
        {
            InitializeComponent();
            radioButton_group.Checked = true;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void Type_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_group.Checked)
            {
                label3.Visible = true;
                group_ID.Visible = true;
                button1.Enabled = true;
                button2.Enabled = false;
                button3.Enabled = false;
            }
            else
            {
                label3.Visible = false;
                group_ID.Visible = false;
                button1.Enabled = false;
                button2.Enabled = true;
                button3.Enabled = true;
            }
        }
    }
}