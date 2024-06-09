using AlgorimsFindPath.SearchPath;
using AlgorimsFindPath.SearchPath.Neighbor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace AlgorimsFindPath.Froms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void startBreadthFS_Click(object sender, EventArgs e)
        {
            new FindPathForm((m, s, e) => new BreadthFirstSearch(m, s, e, GetNeighbor()), "Breadth First Search", true).Show();
        }
        private void startAStar_Click(object sender, EventArgs e)
        {
            new FindPathForm((m, s, e) => new AStar(m, s, e, GetNeighbor()), "AStar").Show();
        }

        private INeighbor GetNeighbor()
        {
            if (Neighbor4RB.Checked)
            {
                return new _4Neighbor();
            }
            else
            {
                return new _8Neighbor();
            }
        }
    }
}
