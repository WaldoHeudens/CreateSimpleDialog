using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Les_7_2
{
    public partial class LoopDialog : Form
    {
        public LoopDialog()
        {
            InitializeComponent();
            btDoeAlles.Focus();
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Continue;
            Close();
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btDoeAlles_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void LoopDialog_Load(object sender, EventArgs e)
        {

        }

        private void LoopDialog_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    DialogResult = DialogResult.OK;
                    break;
                case Keys.Cancel:
                    DialogResult = DialogResult.Cancel;
                    break;
                default:
                    DialogResult = DialogResult.Continue;
                    break;
            }
            Close();
        }
    }
}
