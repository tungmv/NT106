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
        public string DataProperty { get; set; } // id_user
        public string token_user { get; set; }
        public string email { get; set; }
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
                MyAccountForm myaccform = new MyAccountForm();
                myaccform.FormClosed += AccountForm_FormClosed;
                myaccform.MdiParent = this;
                myaccform.Dock = DockStyle.Fill;
                myaccform.token_user = token_user;
                myaccform.Show();
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
                TrainBookingFormStep1.id_user = DataProperty;
                //MessageBox.Show(DataProperty, TrainBookingFormStep1.PData0);
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
                TicketForm tkform = new TicketForm();
                tkform.FormClosed += TicketFormCLosed;
                tkform.MdiParent = this;
                tkform.Dock = DockStyle.Fill;
                tkform.token_user = token_user;
                tkform.email = email;
                tkform.Show();
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
                HistoryForm.token_user = token_user;
                HistoryForm.Show();
            }
            else
            {
                HistoryForm.Activate();
            }
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {

        }
    }

    public static class ngrokURL
    {
        // a global url string
        public static string Url { get; set; } = "https://96cf-2001-ee0-1b08-3691-ecf4-c619-b53-4d3f.ngrok-free.app";
    }
}
