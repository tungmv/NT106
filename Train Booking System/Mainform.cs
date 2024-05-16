using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Train_Booking_System
{
    public partial class Mainform : Form
    {
        MyAccountForm AccountForm;
        public Mainform()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TimerSidebar_Tick(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private async void PictureBoxMenu_Click(object sender, EventArgs e)
        {
            // slide in and slide out animation asynchrnously so the rest can be rendered correctly
            if(FlowLayoutSidebar.Width == FlowLayoutSidebar.MaximumSize.Width)
                while (FlowLayoutSidebar.Width != FlowLayoutSidebar.MinimumSize.Width) 
                {
                    FlowLayoutSidebar.Width = FlowLayoutSidebar.Width - 10;
                    await Task.Delay(10);
                }
            else
                while (FlowLayoutSidebar.Width != FlowLayoutSidebar.MaximumSize.Width)
                {
                    FlowLayoutSidebar.Width = FlowLayoutSidebar.Width + 10;
                    await Task.Delay(10);
                }
        }

        private void ButtonMyAccount_Click(object sender, EventArgs e)
        {
            // Choose MyAccount option
            if(AccountForm == null || AccountForm.IsDisposed)
            {
                AccountForm = new MyAccountForm();
                AccountForm.FormClosed += AccountForm_FormClosed;
                AccountForm.MdiParent = this;
                AccountForm.Dock = DockStyle.Fill;
                AccountForm.Show();
            }
            else
            {
                AccountForm.Activate();
            }
        }

        //handle form closed event
        private void AccountForm_FormClosed(object sender,FormClosedEventArgs e)
        {
            AccountForm = null;
        }
    }
}
