using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
namespace TCP_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void connect_Click(object sender, EventArgs e)
        {
            string host = adress.Text;
            int port = Convert.ToInt32(myPort.Value);

            try
            {
                TcpClient client = new TcpClient(host, port);
                info_about_connections.Items.Add("You are connected with" + host + "On port" + port);
                client.Close();
            }
            catch(Exception ex)
            {
                info_about_connections.Items.Add("Error: Didn't manage to connect");
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
