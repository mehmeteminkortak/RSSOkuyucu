using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RSSOkuyucu
{
    public class RSSFeed
    {
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string Link { get; set; }
        public string Fotograf { get; set; }
    }
    public static class RssTools
    {
        public static List<RSSFeed> GetRssData(string channel)
        {
            WebRequest myRequest = WebRequest.Create(channel);
            WebResponse myResponse = myRequest.GetResponse();

            Stream rssStream = myResponse.GetResponseStream();
            XmlDocument rssDoc = new XmlDocument();
            rssDoc.Load(rssStream);

            XmlNodeList rssItems = rssDoc.SelectNodes("rss/channel/item");
            List<RSSFeed> haberler = new List<RSSFeed>();
            foreach (XmlNode item in rssItems)
            {
                RSSFeed haber = new RSSFeed();
                var node= item.SelectSingleNode("title");
                if (node != null)
                    haber.Baslik = node.InnerText;
                else
                    haber.Baslik = string.Empty;
                node = item.SelectSingleNode("description");
                if (node != null)
                    haber.Aciklama = node.InnerText;
                else
                    haber.Aciklama = string.Empty;
                node = item.SelectSingleNode("link");
                if (node != null)
                    haber.Link = node.InnerText;
                else
                    haber.Link = string.Empty;
                node = item.SelectSingleNode("enclosure");
                if (node != null)
                {
                    try
                    {
                        haber.Fotograf = node.Attributes[0].InnerText;
                    }
                    catch
                    {
                        haber.Fotograf = string.Empty;
                    }
                }
                else
                    haber.Fotograf = string.Empty;

                haberler.Add(haber);
            }
            return haberler;
        }
    }
}
