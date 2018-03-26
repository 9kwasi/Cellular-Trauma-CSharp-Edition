using System;
using System.IO;
using Microsoft.Xna.Framework.Graphics;

namespace Engine
{
	/// <summary>
	/// Description of Karna.
	/// </summary>
	public class Karna : GameCharacter
	{
		Texture2D idle;
		public Karna()
		{
			FileStream fileStream = new FileStream("../../resources/imgs/run1.png", FileMode.Open);
			idle = Texture2D.FromStream(GraphicsDevice, fileStream);
			fileStream.Dispose(); 
		}
		public void Tick()
		{
			
		}
	}
}