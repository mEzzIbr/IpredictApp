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
    public partial class PredictionHistory : Form
    {
        public PredictionHistory()
        {
            InitializeComponent();
        }

        private void PredictionHistory_Load(object sender, EventArgs e)
        {
            Team1.Text = MatchPrediction.T1Name;
            Team2.Text = MatchPrediction.T2Name;
            lblPtnPoints.Text = System.Convert.ToString(MatchPrediction.Potentialpoints);
            lblStatus.Text = MatchPrediction.Predictionstatus;


            //IpredictEntities3 context = new IpredictEntities3();
            //UPredict userpredict = context.UPredicts.Select(u => u).Where
            //        (u => u.userphone == TheUser.Phone).OrderBy(u => u.submitedPoints).SingleOrDefault();

            //lblPtnPoints.Text = (userpredict.submitedPoints)
        }
    }
}
