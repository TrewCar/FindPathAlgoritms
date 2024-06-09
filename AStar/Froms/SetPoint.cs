using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgorimsFindPath.Froms
{
    public partial class SetPoint : Form
    {
        public SetPoint(int x, int y)
        {
            InitializeComponent();
            trackX.Maximum = x;
            trackY.Maximum = y;
        }

        public Point Result = new Point(-1, -1);

        private void trackX_Scroll(object sender, EventArgs e)
        {
            labelX.Text = "X: " + trackX.Value;
        }

        private void trackY_Scroll(object sender, EventArgs e)
        {
            labelY.Text = "Y: " + trackY.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Result = new Point(trackX.Value, trackY.Value);
            this.Close();
        }
    }
}
