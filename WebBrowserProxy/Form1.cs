using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WebBrowserProxy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProxyDegistir_Click(object sender, EventArgs e)
        {
            Proxy.ProxyAyarla("97.77.104.22:3128");
            webBrowser1.Navigate("http://ipbul.org/");
        }

        private void btnProxySıfırla_Click(object sender, EventArgs e)
        {
            Proxy.VarsayılanProxy();
            webBrowser1.Navigate("http://ipbul.org/");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://ipbul.org/");
        }
    }
}
