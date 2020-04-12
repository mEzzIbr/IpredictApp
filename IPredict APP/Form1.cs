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
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void Team1label_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IpredictEntities1 context = new IpredictEntities1();
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            IpredictEntities1 context = new IpredictEntities1();
            Match_level History1 = context.Match_level.Select(h => h)
                .Where(h => h.HomeTeamID == Team1label.Text && h.AwayTeamID == Team2label.Text)
                .OrderBy(h => h.Date).FirstOrDefault();
            MatchHistory.T1Score1 = System.Convert.ToInt32(History1.HomeScore);
            MatchHistory.T2Score1 = System.Convert.ToInt32(History1.AwayScore);
            MatchHistory.Season1 = (History1.leagueid);

            Match_level History2 = context.Match_level.Select(h => h)
                .Where(h => h.HomeTeamID == Team1label.Text && h.AwayTeamID == Team2label.Text)
                .OrderBy(h => h.Date).Skip(1).FirstOrDefault();
                
            MatchHistory.T1Score2 = System.Convert.ToInt32(History2.HomeScore);
            MatchHistory.T2Score2 = System.Convert.ToInt32(History2.AwayScore);
            MatchHistory.Season2 = (History2.leagueid);

            HistoryForm ShowHistoryForm = new HistoryForm();
            ShowHistoryForm.Show();
        }

        public int timeleft = 90;
        public int timeleft2 = 950;
        public int timeleft3 = 720;
        
        public void timer1_Tick(object sender, EventArgs e)
        {
            if ( timeleft > 0 )
            {
                timeleft = timeleft - 1;
                TimeCount.Text = timeleft + " Sec ";
                TheOdds.W1 = 1.5;
                TheOdds.W2 = 3.5;
                PutW1.Text = System.Convert.ToString(TheOdds.W1);
                PutW2.Text = System.Convert.ToString(TheOdds.W2);

                if (timeleft < 85 && timeleft > 81)
                {
                    TheOdds.W1 = TheOdds.W1 - 0.1;
                    TheOdds.W1 = TheOdds.W1 + 2.1;
                    PutW1.Text = System.Convert.ToString(TheOdds.W1);
                    PutW2.Text = System.Convert.ToString(TheOdds.W2);
                }
                if (timeleft < 80 && timeleft > 50)
                {
                    TheOdds.W1 = TheOdds.W1 - 0.1;
                    TheOdds.W1 = TheOdds.W1 + 1.2;
                    PutW1.Text = System.Convert.ToString(TheOdds.W1 - 0.1);
                    PutW2.Text = System.Convert.ToString(TheOdds.W2 + 2.5);
                    lblT1Score.Text = "1";
                }

            }

            else if ( timeleft == 0)
            {
                timer1.Stop();
                PutW1.Enabled = false;
                PutW2.Enabled = false;
                PutDraw.Enabled = false;
                TimeCount.Text = "Ended";
                PicNotify.Visible = true;
                int Team1Score = int.Parse(lblT1Score.Text);
                int Team2Score = int.Parse(lblT2Score.Text);
                if (Team1Score > Team2Score && TheUser.HisPredict == "W1") 
                {
                    TheUser.Points = TheUser.Points + MatchPrediction.Potentialpoints;
                    MatchPrediction.Predictionstatus = "You Won! Congrats";
                    IpredictEntities2 context = new IpredictEntities2();
                    appuser user2 = context.appusers.Select(u => u).Where
                        (u => u.userphone == TheUser.Phone).SingleOrDefault();
                    user2.points = TheUser.Points;
                    context.SaveChanges();
                    //PutW1.Enabled = false;
                    //PutW2.Enabled = false;
                    //PutDraw.Enabled = false;
                }
                else if (Team1Score > Team2Score && TheUser.HisPredict == "W2")
                {
                    //TheUser.Points = TheUser.Points + MatchPrediction.Potentialpoints;
                    MatchPrediction.Predictionstatus = "Oops! You Lost! ";
                    //IpredictEntities2 context = new IpredictEntities2();
                    //appuser user2 = context.appusers.Select(u => u).Where
                    //    (u => u.userphone == TheUser.Phone).SingleOrDefault();
                    //user2.points = TheUser.Points;
                    //context.SaveChanges();
                    //PutW1.Enabled = false;
                    //PutW2.Enabled = false;
                    //PutDraw.Enabled = false;
                }
            }
            //if (timeleft2 > 0)
            //{
            //    timeleft2 = timeleft2 - 1;
            //    TimeCount2.Text = timeleft3 + " Sec ";
            //}
            //if (timeleft3 > 0)
            //{
            //    timeleft3 = timeleft3 - 1;
            //    TimeCount3.Text = timeleft3 + " Sec ";
            //}
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PointsForm pform = new PointsForm();
            pform.Show();
            pform.userpointsform.Text = System.Convert.ToString(TheUser.Points);
        }
        // Put W1 Button 
        private void PutW1_Click(object sender, EventArgs e)
        {
            TheUser.HisPredict = "W1";
            DepositForm dform = new DepositForm();
            dform.Show();
        }
        private void PutW2_Click(object sender, EventArgs e)
        {
            TheUser.HisPredict = "W2";
            DepositForm dform = new DepositForm();
            dform.Show();
        }

        // Open Prediction History Form

        private void button5_Click(object sender, EventArgs e)
        {
            PredictionHistory predictionHistoryform = new PredictionHistory();
            predictionHistoryform.Show();
            MatchPrediction.T1Name = Team1label.Text;
            MatchPrediction.T2Name = Team2label.Text;
            PicNotify.Visible = false;
        }
        // Back To Login Form Function
        private void button26_Click(object sender, EventArgs e)
        {
            LoginForm logout = new LoginForm();
            this.Hide();
            logout.ShowDialog();
        }
        // Open Chat Form Function

        private void button2_Click(object sender, EventArgs e)
        {
            ChatBotForm Chatform = new ChatBotForm();
            Chatform.Show();
        }

        private void btnhistory2_Click(object sender, EventArgs e)
        {
            IpredictEntities1 context = new IpredictEntities1();
            Match_level History1 = context.Match_level.Select(h => h)
                .Where(h => h.HomeTeamID == Team1label2.Text && h.AwayTeamID == Team2label2.Text)
                .OrderBy(h => h.Date).FirstOrDefault();
            MatchHistory.T1Score1 = System.Convert.ToInt32(History1.HomeScore);
            MatchHistory.T2Score1 = System.Convert.ToInt32(History1.AwayScore);
            MatchHistory.Season1 = (History1.leagueid);

            Match_level History2 = context.Match_level.Select(h => h)
                .Where(h => h.HomeTeamID == Team1label2.Text && h.AwayTeamID == Team2label2.Text)
                .OrderBy(h => h.Date).Skip(1).FirstOrDefault();

            MatchHistory.T1Score2 = System.Convert.ToInt32(History2.HomeScore);
            MatchHistory.T2Score2 = System.Convert.ToInt32(History2.AwayScore);
            MatchHistory.Season2 = (History2.leagueid);

            HistoryForm ShowHistoryForm = new HistoryForm();
            ShowHistoryForm.Show();
        }

        private void btnhistory3_Click(object sender, EventArgs e)
        {
            IpredictEntities1 context = new IpredictEntities1();
            Match_level History1 = context.Match_level.Select(h => h)
                .Where(h => h.HomeTeamID == Team1label3.Text && h.AwayTeamID == Team2label3.Text)
                .OrderBy(h => h.Date).FirstOrDefault();
            MatchHistory.T1Score1 = System.Convert.ToInt32(History1.HomeScore);
            MatchHistory.T2Score1 = System.Convert.ToInt32(History1.AwayScore);
            MatchHistory.Season1 = (History1.leagueid);

            Match_level History2 = context.Match_level.Select(h => h)
                .Where(h => h.HomeTeamID == Team1label3.Text && h.AwayTeamID == Team2label3.Text)
                .OrderBy(h => h.Date).Skip(1).FirstOrDefault();

            MatchHistory.T1Score2 = System.Convert.ToInt32(History2.HomeScore);
            MatchHistory.T2Score2 = System.Convert.ToInt32(History2.AwayScore);
            MatchHistory.Season2 = (History2.leagueid);

            HistoryForm ShowHistoryForm = new HistoryForm();
            ShowHistoryForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WithDrawForm withDraw = new WithDrawForm();
            withDraw.Show();
        }

        private void BtnGame_Click(object sender, EventArgs e)
        {
            GameForm play = new GameForm();
            play.Show();
        }

        private void BtnTransfer_Click(object sender, EventArgs e)
        {
            TransferForm Transfer = new TransferForm();
            Transfer.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (timeleft2 > 0)
            {
                timeleft2 = timeleft2 - 1;
                TimeCount2.Text = timeleft3 + " Sec ";
            }
            if (timeleft3 > 0)
            {
                timeleft3 = timeleft3 - 1;
                TimeCount3.Text = timeleft3 + " Sec ";
            }
        }
    }
}
