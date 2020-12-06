using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmMessageBox : Form
    {
        public frmMessageBox()
        {
            InitializeComponent();
        }

        private void Hello_Click(object sender, EventArgs e)
        {
            /MesageBox.Show("message","title",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
        }
    }
}
