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
    public partial class frm_phongsudung : UserControl
    {
        public frm_phongsudung()
        {
            InitializeComponent();
        }
        Panel this_panel;
        public frm_phongsudung(string sophong, Panel panel)
        {
            InitializeComponent();
            lb_sophong.Text = sophong;
            this_panel = panel;
        }

        private void lb_sophong_Click(object sender, EventArgs e)
        {

        }
        popup_phongsudung userctrl;
        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            userctrl = new popup_phongsudung();
            userctrl.Location = new Point(this.Location.X+10, this.Location.Y+1);
            this_panel.Controls.Add(userctrl);
            userctrl.BringToFront();
        }

        private void pictureEdit1_MouseLeave(object sender, EventArgs e)
        {

            //this_panel.Controls.Remove(userctrl);
        }
    }
}
