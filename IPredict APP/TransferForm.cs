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
    public partial class TransferForm : Form
    {
        public TransferForm()
        {
            InitializeComponent();
        }

        private void BtnTransfer_Click(object sender, EventArgs e)
        {
            int TransferdPoints = int.Parse(TxtPointAmount.Text);
            int memberID = int.Parse(txtMemberID.Text);

            IpredictEntities2 context = new IpredictEntities2();
            appuser user = context.appusers.Select(u => u).Where
                (u => u.userid == memberID).SingleOrDefault();
            user.points = user.points + TransferdPoints;
            context.SaveChanges();

            TheUser.Points = TheUser.Points - TransferdPoints;
            IpredictEntities2 context2 = new IpredictEntities2();
            appuser user1 = context.appusers.Select(u => u).Where
                (u => u.userphone == TheUser.Phone).SingleOrDefault();
            user1.points = TheUser.Points;
            context.SaveChanges();

            MessageBox.Show("Points Deliverd Successfuly. it's Great to Support Your Friends ! ");
        }
    }
}
