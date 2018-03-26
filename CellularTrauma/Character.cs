
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace CellularTrauma
{
	/// <summary>
	/// Description of Character.
	/// </summary>
	public class Character
	{
		public Character(GraphicsDevice g)
		{
			
		}
		public void Draw()
		{
			spriteBatch.Begin();
			spriteBatch.Draw(texMenuBG, new Vector2(0,0), Color.White);
			buttonPlay.Draw(spriteBatch);
			buttonCredits.Draw(spriteBatch);
			buttonQuit.Draw(spriteBatch);
			spriteBatch.End();	
		}
	}
}
