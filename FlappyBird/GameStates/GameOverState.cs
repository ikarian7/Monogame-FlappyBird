using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlappyBird.GameObjects;
using Microsoft.Xna.Framework;

namespace FlappyBird.GameStates {
    class GameOverState : GameObjectList {
        public GameOverState() {
            SpriteGameObject background = new SpriteGameObject("spr_gameover");

            this.Add(background);
        }

		public override void HandleInput(InputHelper inputHelper) {
			base.HandleInput(inputHelper);

			if(inputHelper.AnyKeyPressed) {
				FlappyBird.SwitchTo(0);
			}
		}
	}
}