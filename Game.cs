using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        //Run the game
        public void Run()
        {
            //Perform initialization tasks
            Start();
            //Loop update routine until the game is over
            while (!_gameOver)
            {
                Update();
            }
            //Perform cleanup tasks
            End();
        }

        //Initialization method
        public void Start()
        {

        }

        //Method repeated each refresh
        public void Update()
        {

        }

        //Cleanup method
        public void End()
        {

        }

        public void ToggleGameOver() { _gameOver = !_gameOver; }
        private bool _gameOver = false;
    }
}
