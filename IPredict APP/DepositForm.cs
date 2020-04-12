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
    public partial class DepositForm : Form
    {
        public DepositForm()
        {
            InitializeComponent();
        }

        private void DepositForm_Load(object sender, EventArgs e)
        {
            //TheShownOdds.Text = System.Convert.ToString(TheOdds.W1);
        }
        // When User Put His Points To Trad 
        // I Check His Points Credit And Validate That He Own More Than His Input Value
        // If Okay, I Convert His Points To The Potential Points By Multiply With The ODDS Factor
        // Then I Create A new Object And Add It To The Table OF My DB
        // This tables Stores The UserUniqe Key (PhoneNumber) With The MatchID and Submitted Points
        // I Reduce The User Points With The Deposit Value
        // Then I Return To Save It To AppUser Entity In My DB
        private void button1_Click(object sender, EventArgs e)
        {
            int userdeposit = System.Convert.ToInt32(DepositBox.Text);
            if (userdeposit > TheUser.Points)
            {
                MessageBox.Show("Your Points Not Enough, Please Reduce Trading Points");
            }
            else if (userdeposit < TheUser.Points && TheUser.HisPredict == "W1")
            {
                TheShownOdds.Text = System.Convert.ToString(TheOdds.W1);
                int TheFactor = System.Convert.ToInt32(TheOdds.W1);
                PotentialBox.Text = System.Convert.ToString(userdeposit * TheFactor);
                IpredictEntities3 context3 = new IpredictEntities3();
                UPredict prediction1 = new UPredict()
                {
                    predict = "W1",
                    predictStatus = "not yet",
                    userphone = TheUser.Phone,
                    username = TheUser.Name,
                    submitedPoints = userdeposit,
                    matchid = 7587,
                };
                context3.UPredicts.Add(prediction1);
                context3.SaveChanges();

                TheUser.Points = TheUser.Points - userdeposit;
                IpredictEntities2 context = new IpredictEntities2();
                appuser user2 = context.appusers.Select(u => u).Where
                    (u => u.userphone == TheUser.Phone).SingleOrDefault();
                user2.points = TheUser.Points;
                context.SaveChanges();
                MatchPrediction.userprediction = "W1";
                MatchPrediction.Potentialpoints= System.Convert.ToInt32(PotentialBox.Text);
                MessageBox.Show("Success!");
             }

            else if (userdeposit < TheUser.Points && TheUser.HisPredict == "W2")
            {
                TheShownOdds.Text = System.Convert.ToString(TheOdds.W2);
                int TheFactor = System.Convert.ToInt32(TheOdds.W2);
                PotentialBox.Text = System.Convert.ToString(userdeposit * TheFactor);
                IpredictEntities3 context3 = new IpredictEntities3();
                UPredict prediction1 = new UPredict()
                {
                    predict = "W2",
                    predictStatus = "not yet",
                    userphone = TheUser.Phone,
                    username = TheUser.Name,
                    submitedPoints = userdeposit,
                    matchid = 7587,
                };
                context3.UPredicts.Add(prediction1);
                context3.SaveChanges();
                TheUser.Points = TheUser.Points - userdeposit;
                IpredictEntities2 context = new IpredictEntities2();
                appuser user2 = context.appusers.Select(u => u).Where
                    (u => u.userphone == TheUser.Phone).SingleOrDefault();
                user2.points = TheUser.Points;
                context.SaveChanges();
                MatchPrediction.userprediction = "W2";
                MatchPrediction.Potentialpoints = System.Convert.ToInt32(PotentialBox.Text);
                MessageBox.Show("Success!");
                
            }
        }
    }
}
