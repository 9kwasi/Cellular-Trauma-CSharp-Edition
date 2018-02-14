
using System;
using Microsoft.Xna.Framework.Graphics;

namespace Engine
{
	/// <summary>
	/// Description of Fight.
	/// </summary>
	public class Fight
	{
		Level level{get;set;}
		GraphicsDevice graphicsDevice{get;set;}
		
		public Fight(GraphicsDevice g)
		{
			graphicsDevice=g;
			Random rnd = new Random();
			level=new Level(rnd.Next(1,8),g);
		}
		public void Tick()
		{
			level.Tick();
		}
		public void Draw(SpriteBatch spriteBatch)
		{
			level.Draw(spriteBatch);
		}
	}
}
