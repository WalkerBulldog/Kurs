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
    public partial class EntryForm : Form
    {
        private UnsignedUser user = new UnsignedUser();
        public EntryForm()
        {
            InitializeComponent();
        }

        private void EntryButton_Click(object sender, EventArgs e)
        {
            User currentUser = user.Enter(LoginText.Text, PasswordText.Text);
            if (currentUser == null)
                ErrorMessage.Visible = true;
            else
            {
                FormDriver form = new FormDriver((UserDriver)currentUser);
                form.Show();
                this.Hide();
            }
        }
    }
}
