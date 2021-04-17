using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Users;

namespace GuiForEnterprice
{
    public partial class AddWaybillForm : Form
    {
        public AddWaybillForm(User user)
        {
            InitializeComponent();
            StatusLabel.Text = user.ToString();
        }

        private void TrackDistance_Scroll(object sender, EventArgs e)
        {
            DistanceLabel.Text = TrackDistance.Value.ToString() + " км";
        }
    }
}
