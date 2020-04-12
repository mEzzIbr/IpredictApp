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
    public partial class ChatBotForm : Form
    {
        public ChatBotForm()
        {
            InitializeComponent();
        }
        // In This Form, I'm Trying To Make A Simple ChatBot Which Give The User A main GuideLines
        // And Answers The Main Potential Ques. That User May Ask About.
        private void button1_Click(object sender, EventArgs e)
        {
            //string Q1KeyWords = "Minimum minimum Withdraw withdraw";
            if (UserTextbox.Text.Contains("withdraw") || UserTextbox.Text.Contains("minimum"))
            {
                UserTextbox.Text = "";
                AppTextBox.Text = "The Minimum Points To withdraw is 5000 Points";
            }
            else if (UserTextbox.Text.Contains("equal") || UserTextbox.Text.Contains("egp"))
            {
                UserTextbox.Text = "";
                AppTextBox.Text = "it equals 1000 EGP ! ";
            }

        }
    }
}
