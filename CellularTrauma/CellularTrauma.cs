
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
		public Level level;
		public MenuUI menu;
		public static bool shouldExit;
		public SpriteBatch spriteBatch;
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
          level = new Level(GraphicsDevice);
          shouldExit = false;
          spriteBatch = new SpriteBatch(GraphicsDevice);
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
        	if (gameState == State.MENU)
        	{	
        		menu.tick();
        		
        	}else if(gameState == State.FIGHT)
        	{
        		level.tick();
        	}else if(gameState == State.CREDITS)
        	{
        		
        	}else
        	{
        	
        	}
        	base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
        	if (gameState == State.MENU)
        	{
				menu.draw(spriteBatch);
        	}else if(gameState == State.FIGHT)
        	{
        		level.render(spriteBatch);
        		Console.WriteLine("Tried to draw");
        	}else if(gameState == State.CREDITS)
        	{
        		
        	}else
        	{
            GraphicsDevice.Clear(Color.CornflowerBlue);
            base.Draw(gameTime);
        	}
        }
    }
}