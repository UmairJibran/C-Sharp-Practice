using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Threading;

namespace Question_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        WebClient client;
        private void Form1_Load(object sender, EventArgs e)
        {
            client = new WebClient();
            client.DownloadProgressChanged += Client_DownloadProgressChanged;
            client.DownloadFileCompleted += Client_DownloadFileCompleted;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string url = textBox1.Text;
            if (!string.IsNullOrEmpty(url))
            {
                Thread thread = new Thread(() =>
                {
                    Uri uri = new Uri(url);
                    string fileName = System.IO.Path.GetFileName(uri.AbsolutePath);
                    client.DownloadFileAsync(uri, Application.StartupPath + "/" + fileName);
                });
                thread.Start();
            }
        }
        private void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download complete !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            //Update progress bar & label
            Invoke(new MethodInvoker(delegate ()
            {
                progressBar1.Minimum = 0;
                double receive = double.Parse(e.BytesReceived.ToString());
                double total = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = receive / total * 100;
                progressBar1.Value = int.Parse(Math.Truncate(percentage).ToString());
            }));
        }
    }
}
