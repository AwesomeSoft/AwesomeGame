using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AwesomeGame
{
    class GameEngine
    {
        private int FPS = 10;

        private PionController pionController;
        public GameEngine()
        {
            Pion pion = new Pion(0,0,40,40,3,0);
            GameView view = new GameView(pion);
            pionController = new PionController(view);
      

            var task = new Task(Run);
            task.Start();
            Application.Run(view);
        }

        protected void Run()
        {
            while (true)
            {
                pionController.update();
                pionController.render();

                Thread.Sleep(1000/FPS);            
            }
        }
    }
}
