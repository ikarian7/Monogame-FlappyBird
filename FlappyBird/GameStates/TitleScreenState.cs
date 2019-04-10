using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlappyBird.GameObjects;
using Microsoft.Xna.Framework;

namespace FlappyBird.GameStates {
    class GameOverState : GameObjectList {
        int frameCounter;
        GameObjectList pipes;
        Bird flappy;

        public GameOverState() {
            SpriteGameObject background = new SpriteGameObject("spr_gameover");

            this.Add(background);
        }

        public override void Update(GameTime gameTime) {
            base.Update(gameTime);
        }
    }
}