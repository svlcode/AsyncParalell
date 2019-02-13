using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AsyncAndParallel.Forms.BaseForms;

namespace AsyncAndParallel
{
    public partial class BaseListBoxProgressForm : BaseListBoxForm
    {
        public BaseListBoxProgressForm()
        {
            InitializeComponent();
        }

        public int Number
        {
            get
            {
                int number;
                int.TryParse(txtNumber.Text, out number);
                return number;
            }
        }

        protected void StartProgressBar()
        {
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 30;
        }

        protected void StopProgressBar()
        {
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.MarqueeAnimationSpeed = 0;
        }
    }
}
