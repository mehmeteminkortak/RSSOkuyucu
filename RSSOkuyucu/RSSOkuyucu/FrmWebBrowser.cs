using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSSOkuyucu
{
    public partial class FrmWebBrowser : Form
    {
        public FrmWebBrowser(Uri url, string title)
        {
            InitializeComponent();
            this.Link = url;
            this.Title = title;
        }
        public Uri Link { get; private set; }
        public string Title { get; private set; }
        private void FrmWebBrowser_Load(object sender, EventArgs e)
        {
            webBrowser1.Url = this.Link;
            this.Text = this.Title;
        }
    }
}
