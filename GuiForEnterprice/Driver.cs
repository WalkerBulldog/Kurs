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
using WayBills;

namespace GuiForEnterprice
{
    public partial class FormDriver : Form
    {
        private UserDriver user;
        public FormDriver(UserDriver user)
        {
            InitializeComponent();
            this.user = user;
            UpdateData();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            EntryForm form = new EntryForm();
            form.Show();
            Close();
        }
        private void UpdateData()
        {
            StatusLabel.Text = user.Status;
            FullInfoLabel.Text = user.ToString();
            List<string> list = user.GetWaybills();
            WBgridView.Rows.Clear();
            foreach(string str in list)
                WBgridView.Rows.Add(str);

        }
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateData();
        }
    }
}
