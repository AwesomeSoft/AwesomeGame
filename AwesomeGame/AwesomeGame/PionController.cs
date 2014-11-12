using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeGame
{
    class PionController
    {
        private GameView view;
        public PionController(GameView view)
        {
            this.view = view;
        }


        public void update()
        {
            view.Pion.move(view.LevelWidth,view.LevelHeight);
        }

        public void render()
        {
            view.Invalidate();
        }
    }
}
