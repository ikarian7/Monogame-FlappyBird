using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyBird.GameObjects {
    class Bird : RotatingSpriteGameObject {
        Vector2 startPosition;

        public Bird() : base("spr_bird") {
            startPosition = new Vector2(FlappyBird.Screen.X/2, FlappyBird.Screen.Y/2);
            Origin = texture.Bounds.Size.ToVector2() / 2;
            Reset();
        }

        public override void Reset() {
            base.Reset();
            velocity = new Vector2(0);
			position = startPosition;
		}

        public override void Update(GameTime gameTime) {
            base.Update(gameTime);
            AngularDirection = new Vector2(100, velocity.Y);
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
