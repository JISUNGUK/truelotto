using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace LottoTeamQuiz
{
    public partial class FrmShopRankInfo : Form
    {
        private int index;

        public FrmShopRankInfo()
        {
            InitializeComponent();
        }

        public FrmShopRankInfo(int index)
        {
            InitializeComponent();
            this.index = index;
        }

        private void FrmShopRankInfo_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(index.ToString());
            Test();
        }

        private void Test()
        {

           /* HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://nlotto.co.kr/store.do?method=topStore&pageGubun=L645");
            WebResponse response = request.GetResponse();

            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream, Encoding.Default);

            string xmlstr = reader.ReadToEnd();
            textBox1.Text = xmlstr;*/

            XmlDocument xml = new XmlDocument();
            //XmlNodeList node = xml.SelectNodes("//head");
            HtmlAgilityPack.HtmlWeb hw = new HtmlAgilityPack.HtmlWeb();
            hw.OverrideEncoding = Encoding.UTF8;
            HtmlAgilityPack.HtmlDocument hd = hw.Load("http://nlotto.co.kr/store.do?method=topStore&pageGubun=L645");

            foreach (HtmlAgilityPack.HtmlNode item in hd.DocumentNode.SelectNodes("//head"))
            {
                MessageBox.Show(item.ChildNodes[0].InnerText);
            }
        }
    }
}
