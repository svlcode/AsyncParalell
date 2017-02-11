﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAndParallel.Forms.BaseForms
{
    public partial class BaseListBoxForm : Form
    {
        public BaseListBoxForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            OnStart();
        }

        protected virtual void OnStart()
        {
        }

        protected void TimeConsumingTask()
        {
            long sum = 0;
            for (int i = 0; i < int.MaxValue / 2; i++)
            {
                sum += i;
            }
        }
    }
}