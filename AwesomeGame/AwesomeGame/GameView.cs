using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AwesomeGame
{
    public partial class GameView : Form
    {
        private Pion pion;
        private int levelHeight;
        private int levelWidth;
        public GameView(Pion pion)
        {
            InitializeComponent();
            this.pion = pion;
            this.levelWidth = GamePanel.Width;
            this.levelHeight = GamePanel.Height;
        }

        public int LevelWidth
        {
            get { return levelWidth; }
        }

        public int LevelHeight
        {
            get { return levelHeight; }
        }


        private void GamePanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            pion.draw(g);
        }

        public Pion Pion
        {
            get { return pion; }
            set { pion = value; }
        }

        private void GameView_Load(object sender, EventArgs e)
        {

        }

        private void buttonKeyUp_Click(object sender, EventArgs e)
        {

        }
    }
}
