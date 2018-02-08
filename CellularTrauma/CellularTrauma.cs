
using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Engine;

namespace CellularTrauma
{
	/// <summary>
	/// Description of CellularTrauma.
	/// </summary>
	public class CellularTrauma : Game
	{
        GraphicsDeviceManager graphics;
		States gameState;
		public MenuUI menu;
        public CellularTrauma()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferHeight = 720;
            graphics.PreferredBackBufferWidth = 1280;
            menu = new MenuUI();
            Content.RootDirectory = "resources";
        }

        protected override void Initialize()
        {
          gameState = States.MENU;
          base.Initialize();
        }

        protected override void LoadContent()
        {
        }

        protected override void UnloadContent()
        {
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == 
                ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape)){
        		Exit();
        	}
        	base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
        	if (gameState == States.MENU) {
			menu.draw(GraphicsDevice);
        	}else{
            GraphicsDevice.Clear(Color.CornflowerBlue);
            base.Draw(gameTime);
        }
        }
        public void tick() {
	
        }
    }
}