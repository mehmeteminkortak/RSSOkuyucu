using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSSOkuyucu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<RSSFeed> Haberler { get; set; }
        private void btnYenile_Click(object sender, EventArgs e)
        {
            Haberler = RssTools.GetRssData(txtKanal.Text);
            cmbBaslik.DisplayMember = "Baslik";
            cmbBaslik.DataSource = Haberler;
        }
        public RSSFeed SeciliHaber { get; set; }
        private void cmbBaslik_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBaslik.SelectedItem == null) return;
            SeciliHaber = cmbBaslik.SelectedItem as RSSFeed;
            if (!string.IsNullOrEmpty(SeciliHaber.Aciklama))
                txtAciklama.Text = SeciliHaber.Aciklama;
            if (!string.IsNullOrEmpty(SeciliHaber.Link))
                llHaber.Text = $"Link: {SeciliHaber.Link}";
            else
                llHaber.Text = "Link yok!";
            if (!string.IsNullOrEmpty(SeciliHaber.Fotograf))
                pbHaberFoto.ImageLocation = SeciliHaber.Fotograf;
            else
                pbHaberFoto.ImageLocation = string.Empty;
        }

        private void llHaber_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (SeciliHaber == null || llHaber.Text == "Link yok!") return;

            // Process.Start(SeciliHaber.Link);
            FrmWebBrowser browser = new FrmWebBrowser(new Uri(SeciliHaber.Link), SeciliHaber.Baslik);
            browser.ShowDialog();
        }
    }
}
