using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Задание_1_г
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            X.Maximum = int.MaxValue;
            X.Minimum = int.MinValue;
            Y.Maximum = int.MaxValue;
            Y.Minimum = int.MinValue;
        }

        private void XandY_ValueChanged(object sender, EventArgs e)
        {
            if (X.Value * X.Value + Y.Value * Y.Value < 81 && X.Value > 0)
                Ot.Text = "внутри области";
            else if (X.Value * X.Value + Y.Value * Y.Value > 81 || X.Value < 0)
                Ot.Text = "вне области";
            else Ot.Text = "на границе";
        }
    }
}
