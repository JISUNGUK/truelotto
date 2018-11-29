using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LottoTeamQuiz
{
    public partial class FormDetail : Form
    {
        private List<DetailLotto> listDetailLotto;
        private int index;

        public FormDetail()
        {
            InitializeComponent();
        }

        public FormDetail(List<DetailLotto> listDetailLotto, int index)
        {
            InitializeComponent();

            this.listDetailLotto = listDetailLotto;
            this.index = index;

            foreach (var item in listDetailLotto)
            {
                if (item.LottoNum == this.index)
                {
                    LblCount.Text = item.LottoNum + "회 당첨결과";

                    LblRank1.Text = item.Rank[0].ToString() + "등";
                    LblRank2.Text = item.Rank[1].ToString() + "등";
                    LblRank3.Text = item.Rank[2].ToString() + "등";
                    LblRank4.Text = item.Rank[3].ToString() + "등";
                    LblRank5.Text = item.Rank[4].ToString() + "등";

                    LblPrice1.Text = item.Price[0].ToString() + "원";
                    LblPrice2.Text = item.Price[1].ToString() + "원";
                    LblPrice3.Text = item.Price[2].ToString() + "원";
                    LblPrice4.Text = item.Price[3].ToString() + "원";
                    LblPrice5.Text = item.Price[4].ToString() + "원";

                    LblPerson1.Text = string.Format("{0:n0}", item.Person[0]);
                    LblPerson2.Text = string.Format("{0:n0}", item.Person[1]);
                    LblPerson3.Text = string.Format("{0:n0}", item.Person[2]);
                    LblPerson4.Text = string.Format("{0:n0}", item.Person[3]);
                    LblPerson5.Text = string.Format("{0:n0}", item.Person[4]);

                    LblPerPrice1.Text = item.PersonPrice[0];
                    LblPerPrice2.Text = item.PersonPrice[1];
                    LblPerPrice3.Text = item.PersonPrice[2];
                    LblPerPrice4.Text = item.PersonPrice[3];
                    LblPerPrice5.Text = item.PersonPrice[4];
                }
            }
        }
    }
}
