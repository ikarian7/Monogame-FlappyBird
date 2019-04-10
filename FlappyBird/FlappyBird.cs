using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlappyBird.GameStates;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace FlappyBird
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    class FlappyBird : GameEnvironment
    {      
        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            base.LoadContent();
            screen.X = 640;
            screen.Y = 480;
            ApplyResolutionSettings();


			// TODO: Add gamestates here
			gameStateList.Add(new TitleScreenState()); //0
            gameStateList.Add(new PlayingState()); //1
			gameStateList.Add(new GameOverState()); //2
            SwitchTo(0);
        }
      
    }
}
