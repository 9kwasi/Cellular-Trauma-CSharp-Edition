
using System;
using Engine;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;

namespace CellularTrauma
{
	/// <summary>
	/// Description of Button.
	/// </summary>
	public class Button
    {
        int buttonX, buttonY;
        string Name;
        Texture2D Texture;
        Engine.Button button;
       	String clicked;

        public Button(string name, Texture2D texture, int buttonX, int buttonY)
        {
            this.Name = name;
            this.Texture = texture;
            this.buttonX = buttonX;
            this.buttonY = buttonY;
            button = new Engine.Button(name,buttonX,buttonY,texture.Width,texture.Height);
        }


        public void Draw(SpriteBatch s)
        {	SpriteBatch spriteBatch = s;
            spriteBatch.Draw(Texture, new Rectangle((int)buttonX, (int)buttonY, Texture.Width, Texture.Height), Color.White);   
        } 
        public void tick(){
        	clicked = button.tick();
        	switch (clicked) {
        		case "Play":
        			//change gamestate to fight
        			break;
        		case "Credits":
        			//change gamestate to credits
        			break;
        		case "Quit":
        			CellularTrauma.shouldExit = true;
        			break;
        		default:
        			
        			break;
        	}
		}
	}
}
