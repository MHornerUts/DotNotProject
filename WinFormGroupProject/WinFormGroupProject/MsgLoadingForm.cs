using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormGroupProject
{
    public partial class MsgLoadingForm : Form
    {
        String msg;
        String email;
        String subject;
        public MsgLoadingForm(String msg, String email, String writing)
        {
            InitializeComponent();
            this.msg = msg;
            this.email = email;
            label1.Text = writing;
        }

        private void MsgLoadingForm_Load(object sender, EventArgs e)
        {
            MailSender mailSender = new MailSender();
            mailSender.send(msg, "From the supply Manager", email, this);
            

        }

        public void failed() {
            label1.Text = "An error occured with the message";
        }
    }
}
