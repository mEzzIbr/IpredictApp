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
    public partial class PointsForm : Form
    {
        public PointsForm()
        {
            InitializeComponent();
        }
        private void PointsForm_Load(object sender, EventArgs e)
        {
            userpointsform.Text = System.Convert.ToString(TheUser.Points);
        }
    }
}
