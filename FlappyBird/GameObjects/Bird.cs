using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyBird.GameObjects {
    class Bird : SpriteGameObject {
        Vector2 startPosition;

        public Bird() : base("spr_bird") {
            startPosition = new Vector2(FlappyBird.Screen.X/2, FlappyBird.Screen.Y/2);
            Reset();
        }

        public override void Reset() {
            base.Reset();
            velocity = new Vector2(0);
			position = startPosition;
		}

        public override void Update(GameTime gameTime) {
            
            base.Update(gameTime);

            velocity += new Vector2(0, 20);

            
        }

		public override void HandleInput(InputHelper inputHelper) {
			base.HandleInput(inputHelper);


			if (inputHelper.KeyPressed(Keys.Space)) {
				velocity = new Vector2(0, -450);
			}
		}
	}
}
