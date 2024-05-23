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
        MyAccountForm MyAccountForm;
        TrainBookingFormStep1 TrainBookingFormStep1;
        TicketForm TicketForm;
        HistoryForm HistoryForm;

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
            if(MyAccountForm == null || MyAccountForm.IsDisposed)
            {
                MyAccountForm = new MyAccountForm();
                MyAccountForm.FormClosed += AccountForm_FormClosed;
                MyAccountForm.MdiParent = this;
                MyAccountForm.Dock = DockStyle.Fill;
                MyAccountForm.Show();
            }
            else
            {
                MyAccountForm.Activate();
            }
            
        }

        //handle form closed event
        private void AccountForm_FormClosed(object sender,FormClosedEventArgs e)
        {
            TrainBookingFormStep1 = null;
        }

        private void ButtonBooking_Click(object sender, EventArgs e)
        {
            // Choose MyAccount option
            if (TrainBookingFormStep1 == null || TrainBookingFormStep1.IsDisposed)
            {
                TrainBookingFormStep1 = new TrainBookingFormStep1(this);
                TrainBookingFormStep1.FormClosed += AccountForm_FormClosed;
                TrainBookingFormStep1.MdiParent = this;
                TrainBookingFormStep1.Dock = DockStyle.Fill;
                TrainBookingFormStep1.Show();
            }
            else
            {
                TrainBookingFormStep1.Activate();
            }
        }

        private void TicketFormCLosed(object sender, FormClosedEventArgs e)
        { 
            TicketForm = null;
        }

        private void ButtonTicketClick(object sender, EventArgs e)
        {
            if(TicketForm == null || TicketForm.IsDisposed)
            {
                TicketForm = new TicketForm();
                TicketForm.FormClosed += TicketFormCLosed;
                TicketForm.MdiParent = this;
                TicketForm.Dock = DockStyle.Fill;
                TicketForm.Show();
            }
            else
            {
                TicketForm.Activate();
            }
        }

        private void HistoryFormClosed(object sender, FormClosedEventArgs e)
        {
            HistoryForm = null;
        }

        private void ButtonHistory_Click(object sender, EventArgs e)
        {
            if(HistoryForm == null || HistoryForm.IsDisposed)
            {
                HistoryForm = new HistoryForm();
                HistoryForm.FormClosed += HistoryFormClosed;
                HistoryForm.MdiParent = this;
                HistoryForm.Dock = DockStyle.Fill;
                HistoryForm.Show();
            }
            else
            {
                HistoryForm.Activate();
            }
        }
    }
}
