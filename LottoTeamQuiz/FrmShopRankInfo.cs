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

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://nlotto.co.kr/store.do?method=topStore&pageGubun=L645");
            WebResponse response = request.GetResponse();

            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream, Encoding.Default);

            string xmlstr = reader.ReadToEnd();
            textBox1.Text = xmlstr;

            XmlDocument xml = new XmlDocument();

            //XmlNodeList node = xml.SelectNodes("//head");

            xml.LoadXml(xmlstr);
            //xml.Load("http://nlotto.co.kr/store.do?method=topStore&pageGubun=L645");

            //MessageBox.Show(xml.InnerXml);
            //foreach (XmlNodeList item in list)
            //{
            //    MessageBox.Show(item[0].InnerXml);
            //}
        }
    }
}
