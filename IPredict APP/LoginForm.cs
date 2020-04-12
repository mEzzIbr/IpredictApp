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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        // 1- I Detect if The User Input Matches with The DB Records
        // 2- If It Matches, I Store His Records And Pass It To The Props of A Static Class
        // 3- I Make A PopUp Dynamic Message Box Which Detect This Object Username And points
        // 3- I Make Him Able To Enter The App Main UI 
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            IpredictEntities2 context = new IpredictEntities2();
            var user1 = context.appusers.FirstOrDefault
                (u => u.userphone == txtPhone.Text && u.userpass == TxtPass.Text );
           
            if (user1 != null)
            {
                TheUser.Points = System.Convert.ToInt32(user1.points);
                TheUser.Phone = user1.userphone;
                TheUser.Name = user1.username;
                TheUser.ID = user1.userid;
                MessageBox.Show("Welcome " + user1.username + " ! " + " Your Points is " + user1.points + " Points ");
                MainUI Openform = new MainUI();
                this.Hide();
                Openform.ShowDialog();
            }
      
            else
            {
                MessageBox.Show("You Have To Enter A Valid Data ! ");
            }
            
        }
    }
}
