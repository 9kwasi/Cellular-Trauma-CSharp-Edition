
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
        public static SpriteFont font;
		public static State gameState=State.MENU;
		public static MouseInput Mouse;
		public MenuUI menu;
		public static bool shouldExit;
        public CellularTrauma()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferHeight = 720;
            graphics.PreferredBackBufferWidth = 1280;
            this.IsMouseVisible = true;
            Content.RootDirectory = "resources";
        }

        protected override void Initialize()
        {
          Mouse = new MouseInput();
          menu = new MenuUI(GraphicsDevice);
          shouldExit = false;
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
        	if (shouldExit == true){
        		Exit();
        	}
        	Mouse.Update();
        	menu.tick();
        	base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
        	if (gameState == State.MENU) {
			menu.draw();
        	}else{
            GraphicsDevice.Clear(Color.CornflowerBlue);
            base.Draw(gameTime);
        }
        }
    }
}