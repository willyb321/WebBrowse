using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.gmail.com");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.youtube.com/my_videos");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.reddit.com");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.reddit.com/r/elitedangerous");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.reddit.com/r/elitecg");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.snapzu.com");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://gmail.com");
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://youtube.com/my_videos");
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://reddit.com");
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://reddit.com/r/elitedangerous");
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://reddit.com/r/elitecg");
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://snapzu.com");
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }
        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://gmail.com");
        }



        private void toolStripButton10_Click_1(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://youtube.com/my_videos");
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://reddit.com");
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://reddit.com/r/elitedangerous");
        }

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://reddit.com/r/elitecg");
        }

        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://snapzu.com");
        }

        private void toolStripButton15_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void toolStripButton16_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void toolStripButton17_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void toolStripButton18_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://eddb.io");
        }

        private void toolStripButton19_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.edsm.net/logs");
        }

        private void toolStripButton20_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://192.168.1.1");
        }

        private void toolStripButton21_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://giveawayoftheday.com");
        }

        private void toolStripButton22_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://robertsspaceindustries.com");
        }
    }
}