using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace FlappyBird.GameManagement {
	

    class TextGameObject : GameObject {
		protected SpriteFont spriteFont;
		protected Color color;
		String text;
       

		TextGameObject(Vector2 position) {
			this.position = position;
		}

		public override void Draw(SpriteBatch spriteBatch) {
			base.Draw(spriteBatch);

			if(visible) {
				spriteBatch.DrawString(spriteFont, text, new Vector2(300, 50), color);
			}

		}
	}
    
}