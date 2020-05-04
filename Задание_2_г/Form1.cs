using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Задание_2_г
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void NumMeS_ValueChanged(object sender, EventArgs e)
        {
            if (NumMeS.Value == (decimal)((int)NumMeS.Value))
                Ot.Text = (12 - NumMeS.Value).ToString();
            else
                NumMeS.Value = (int)NumMeS.Value;
        }
    }
}
