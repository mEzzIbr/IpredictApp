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
    public partial class WithDrawForm : Form
    {
        public WithDrawForm()
        {
            InitializeComponent();
        }

        

        private void btnconverter_Click(object sender, EventArgs e)
        {
            label1.Text = " EGP ";
            int InputPointsConv = System.Convert.ToInt32(boxwithdraw.Text);
            if ( InputPointsConv < TheUser.Points )
            {
                boxwithdraw.Text = "";
                boxwithdraw.Text = System.Convert.ToString(InputPointsConv / 5);
            }
        }
        private void btnwithdraw_Click(object sender, EventArgs e)
        {

            float usermoney = float.Parse(boxwithdraw.Text);
            if (usermoney >= 1000)
            {
                IpredictEntities5 Context = new IpredictEntities5();
                UMoney user1Deserve = new UMoney
                {
                    userid = TheUser.ID,
                    username = TheUser.Name,
                    PhoneNumber = TheUser.Phone,
                    DeservedMoney = usermoney,
                };
                Context.UMoneys.Add(user1Deserve);
                Context.SaveChanges();

                int newpoints = System.Convert.ToInt32(usermoney * 5);
                TheUser.Points = TheUser.Points - newpoints;
                IpredictEntities2 context = new IpredictEntities2();
                appuser user2 = context.appusers.Select(u => u).Where
                    (u => u.userphone == TheUser.Phone).SingleOrDefault();
                user2.points = TheUser.Points;
                context.SaveChanges();

                MessageBox.Show("Success!");
            }
            else if ( usermoney < 1000)
            {
                MessageBox.Show("The Minimum Amount to Withdraw is 5000 pts, Which Equv. to 1000 EGP ");
            }
        }
    }
}
