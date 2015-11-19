using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WhatsAppApi;
using WhatsAppApi.Response;

namespace Whatsapp_Pinger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            string from = textBox_from.Text;
            string to = textBox_to.Text;
            string msg = textBox_msg.Text;

            WhatsApp wa = new WhatsApp(from, "ZVY6Y07Fgepusk2tGcUiCc0v39A=", ".NET Sender", false, false);

            wa.OnConnectSuccess += () =>
            {
                MessageBox.Show("Connected", "Status");
                wa.OnLoginSuccess += (phoneNumber, data) =>
                {
                    wa.SendMessage(to, msg);
                    MessageBox.Show("Message Sent", "Status");
                };
                wa.OnLoginFailed += (data) =>
                {
                    MessageBox.Show("could not login to whatsapp", data);
                };
                wa.Login();

            };
            wa.OnConnectFailed += (ex) =>
            {
                MessageBox.Show("failed to connect","Status");
            };
            wa.Connect();
        }
    }
}
