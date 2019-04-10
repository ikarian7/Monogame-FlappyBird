using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyBird.GameObjects {
	class Pipe : GameObjectList {
		SpriteGameObject upperPipe;
		SpriteGameObject lowerPipe;
		Random random = new Random();

		public Pipe() {
			upperPipe = new SpriteGameObject("spr_pipe_upper");
			lowerPipe = new SpriteGameObject("spr_pipe_lower");

			upperPipe.position.Y = -525;
			lowerPipe.position.Y = 265;

			this.Add(upperPipe);
			this.Add(lowerPipe);

			velocity.X = -300;
			position.X = 700;
			position.Y = random.Next(0, 200);
			//position.Y = random.Next(200, 400);
		}

		public bool Overlaps(SpriteGameObject other) {
			foreach(SpriteGameObject pipe in Children) {
                if(pipe.Overlaps(other)) {
					return true;
				}
			}
			return false;
		}
	}
}