
using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Engine;

namespace CellularTrauma
{
	/// <summary>
	/// Description of MenuUI.
	/// </summary>
	public class MenuUI
	{	
		public static Texture2D texMenuBG;
		public static Texture2D texButton;
		public Button buttonPlay;
		public Button buttonCredits;
		public Button buttonQuit;
		public GraphicsDevice GraphicsDevice;
		public MenuUI(GraphicsDevice g)
		{
			GraphicsDevice = g;
			FileStream fileStream = new FileStream("../../resources/imgs/menubg.png", FileMode.Open);
			texMenuBG = Texture2D.FromStream(GraphicsDevice, fileStream);
			fileStream.Dispose();
			fileStream = new FileStream("../../resources/imgs/button.png", FileMode.Open);
			texButton = Texture2D.FromStream(GraphicsDevice, fileStream);
			fileStream.Dispose();
			buttonPlay = new Button("Play",texButton,1280/2 -100,250);
			buttonCredits = new Button("Credits",texButton,1280/2 - 100, 400);
			buttonQuit = new Button("Quit",texButton,1280/2 - 100, 550);
		}
		
		public void draw(SpriteBatch spriteBatch){
			spriteBatch.Begin();
			spriteBatch.Draw(texMenuBG, new Vector2(0,0), Color.White);
			buttonPlay.Draw(spriteBatch);
			buttonCredits.Draw(spriteBatch);
			buttonQuit.Draw(spriteBatch);
			spriteBatch.End();
			   
		}
		public void tick(){
			buttonPlay.tick();
			buttonCredits.tick();
			buttonQuit.tick();
		}
	}
	
}
