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
        private void button1_Click(object sender, EventArgs e){
            WebClient myWebClient = new WebClient();
            string remoteUri = textBox1.Text.ToLower();
            string fileName; 
            string[] domainBreakdown= remoteUri.Split('/');
            fileName = domainBreakdown[domainBreakdown.Length-1];
            MessageBox.Show(fileName);
            myWebClient.DownloadFile(remoteUri, fileName);
            MessageBox.Show("Successfully Downloaded File " + fileName + " from " + remoteUri);
        }
    }
}
