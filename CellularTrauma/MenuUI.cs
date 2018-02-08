
using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CellularTrauma
{
	/// <summary>
	/// Description of MenuUI.
	/// </summary>
	public class MenuUI
	{
		public Texture2D menubg;
		public Texture2D button;
		public MenuUI()
		{
		}
		
		public void draw(GraphicsDevice GraphicsDevice){
			FileStream fileStream = new FileStream("../../resources/imgs/menubg.png", FileMode.Open);
			menubg = Texture2D.FromStream(GraphicsDevice, fileStream);
			fileStream.Dispose();
			fileStream = new FileStream("../../resources/imgs/button.png", FileMode.Open);
			button = Texture2D.FromStream(GraphicsDevice, fileStream);
			fileStream.Dispose();
			
			Vector2 bgpos = new Vector2(0, 0);
			Vector2	button0 = new Vector2(1280/2 -100,250);
			Vector2 button1 = new Vector2(1280/2 - 100, 400);
			Vector2 button2 = new Vector2(1280/2 - 100,550);
			SpriteBatch spriteBatch = new SpriteBatch(GraphicsDevice);
			spriteBatch.Begin();
			spriteBatch.Draw(menubg, bgpos, Color.White);
			spriteBatch.Draw(button, button0,Color.White);
			spriteBatch.Draw(button,button1,Color.White);
			spriteBatch.Draw(button,button2,Color.White);
			spriteBatch.End();
			   
		}
	}
	
}
