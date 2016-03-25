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
    }
}
