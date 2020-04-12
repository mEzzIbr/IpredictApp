using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPredict_APP
{
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            T1Score1.Text = System.Convert.ToString(MatchHistory.T1Score1);
            T2Score1.Text = System.Convert.ToString(MatchHistory.T2Score1);
            lblSeason1.Text = (MatchHistory.Season1) + " 2019 ";

            T1Score2.Text = System.Convert.ToString(MatchHistory.T1Score2);
            T2Score2.Text = System.Convert.ToString(MatchHistory.T2Score2);
            lblSeason2.Text = (MatchHistory.Season2) + " 2018 ";
        }
    }
}
