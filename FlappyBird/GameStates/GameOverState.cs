using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlappyBird.GameObjects;
using Microsoft.Xna.Framework;

namespace FlappyBird.GameStates
{
    class PlayingState : GameObjectList
    {
        int frameCounter;
        GameObjectList pipes;
        Bird flappy;

        public PlayingState()
        {
            SpriteGameObject background = new SpriteGameObject("spr_background");
            flappy = new Bird();
            pipes = new GameObjectList();

            frameCounter = 0;

            this.Add(background);
            this.Add(flappy);
            this.Add(pipes);
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            bool isGameOver = false;
            frameCounter++;

            if (frameCounter > 100)
            {
                pipes.Add(new Pipe());
                frameCounter = 0;
            }

            foreach (Pipe checkPipe in pipes.Children)
            {
                if (checkPipe.Overlaps(flappy))
                {
                    isGameOver = true;
                }
            }

            if (flappy.position.X > GameEnvironment.Screen.X ||
                flappy.position.X < 0 - flappy.texture.Width ||
                flappy.position.Y < 0 - flappy.texture.Height ||
                flappy.position.Y > GameEnvironment.Screen.Y)
            {
                isGameOver = true;
            }

            if (isGameOver)
            {
                SetGameOver();
            }
        }

        public void SetGameOver()
        {
            flappy.Reset();
            pipes.Children.Clear();
            frameCounter = 0;
        }
    }
}