using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Da.controller
{
    public partial class popup_phongsudung : UserControl
    {
        public popup_phongsudung()
        {
            InitializeComponent();
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            Form frm_thanhtoan = new Form();

            frm_thanhtoan.Show();
        }
    }
}
