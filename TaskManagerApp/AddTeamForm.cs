﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManagerApp
{
    public partial class AddTeamForm : Form
    {
        public AddTeamForm()
        {
            InitializeComponent();
        }

        private void TaskName_MouseDown(object sender, MouseEventArgs e)
        {
            TaskName.Clear();
        }

        private void Description_MouseDown(object sender, MouseEventArgs e)
        {
            Description.Clear();
        }
    }
}
