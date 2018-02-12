
using System;
using System.IO;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Engine
{
	/// <summary>
	/// Description of Level.
	/// </summary>
	public class Level
	{
		int xPos = 0;
		Texture2D texBG;
		Texture2D texFG;
		GraphicsDevice GraphicsDevice;
		public Level(GraphicsDevice g)
		{
			GraphicsDevice = g;
			FileStream fileStream = new FileStream("../../../CellularTrauma/resources/imgs/levels/treetop/back.png", FileMode.Open);
			texBG = Texture2D.FromStream(GraphicsDevice, fileStream);
			fileStream.Dispose(); 
			fileStream = new FileStream("../../../CellularTrauma/resources/imgs/levels/treetop/front.png",FileMode.Open);
			texFG = Texture2D.FromStream(GraphicsDevice, fileStream);
			fileStream.Dispose();
		}
		public void tick(){
			xPos++;
		}
		public void render(SpriteBatch spriteBatch) {
			// Render the background
			if (true) {
				spriteBatch.Begin();
				spriteBatch.Draw(texBG, new Vector2(-xPos,-1494+720), Color.White);
			}

			// Render player and enemy here

			// Render the front
			if (true) {
				spriteBatch.Draw(texFG, new Vector2(-xPos*2,-1775+720+500), Color.White);
				spriteBatch.End();
			}
		
		}
	}
}