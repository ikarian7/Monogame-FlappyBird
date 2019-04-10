using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlappyBird.GameObjects;
using Microsoft.Xna.Framework;

namespace FlappyBird.GameStates {
    class PlayingState : GameObjectList {
		int frameCounter;
		GameObjectList pipes;
        object flappy;

        public PlayingState() {
            SpriteGameObject background = new SpriteGameObject("spr_background");
            Bird flappy = new Bird();
			pipes = new GameObjectList();

			frameCounter = 0;

            this.Add(background);
            this.Add(flappy);
			this.Add(pipes);
        }

		public override void Update(GameTime gameTime) {
			base.Update(gameTime);

			frameCounter++;

			if(frameCounter > 100) {
				pipes.Add(new Pipe());
				frameCounter = 0;
			}
		}

		public void SetGameOver() {
			flappy.Reset();

		}
    }
}