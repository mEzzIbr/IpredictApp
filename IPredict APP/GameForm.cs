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
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var random = new Random();
            var list = new List<int> { 1, 2, 3 , 4 , 5};
            int index = random.Next(list.Count);
            label1.Text = System.Convert.ToString(list[index]);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            var random2 = new Random();
            var list = new List<int> { 7, 2, 3, 4, 5, 6, 1, 8, 9 };
            int index = random2.Next(list.Count);
            label2.Text = System.Convert.ToString(list[index]);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            var random3 = new Random();
            var list = new List<int> { 9 , 7 , 8 , 4 , 2 , 5 , 6 , 1 , 3 };
            int index = random3.Next(list.Count);
            label3.Text = System.Convert.ToString(list[index]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            button1.Enabled = false;
            timer4.Enabled = true;
        }
        int timeleft = 10;
        private void timer4_Tick(object sender, EventArgs e)
        {
            if ( timeleft > 0)
            {
                timecount.Text = timeleft + " Second ";
                timeleft = timeleft - 1;

            }
            else if ( timeleft == 0)
            {
                timecount.Text = " Pick Your Points !";
                //timer1.Enabled = false;
                //timer2.Enabled = false;
                //timer3.Enabled = false;
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                timer4.Stop();
                string TheTotalEarn = (label1.Text + label2.Text + label3.Text);
                MessageBox.Show("Congrats! You Have Earned " + TheTotalEarn + " Points ");

                TheUser.Points = TheUser.Points + int.Parse(TheTotalEarn);

                IpredictEntities2 context = new IpredictEntities2();
                appuser user2 = context.appusers.Select(u => u).Where
                    (u => u.userphone == TheUser.Phone).SingleOrDefault();
                user2.points = TheUser.Points;
                context.SaveChanges();
            }
        }
    }
}
