
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

        public Button(string name, Texture2D texture, int buttonX, int buttonY)
        {
            this.Name = name;
            this.Texture = texture;
            this.buttonX = buttonX;
            this.buttonY = buttonY;
        }


        public void Draw(SpriteBatch s)
        {	SpriteBatch spriteBatch = s;
            spriteBatch.Draw(Texture, new Rectangle((int)buttonX, (int)buttonY, Texture.Width, Texture.Height), Color.White);   
        } 
        public void tick(){
		        if (enteredButton() && MouseInput.lastMouseState.LeftButton == ButtonState.Released && MouseInput.mouseState.LeftButton == ButtonState.Pressed)
           		{
                	switch (Name)
                	{
                    	case "Play": 
                			Console.WriteLine("Clicked "+Name);
                			CellularTrauma.doneLoading = false;
                			CellularTrauma.gameState = State.FIGHT;
                			MenuUI.texButton.Dispose();
                			MenuUI.texMenuBG.Dispose();
             				break;
                    	case "Credits":
                        	Console.WriteLine("Clicked "+Name);
                        	break;
                    	case "Quit":
                    		Console.WriteLine("Clicked "+Name);
                    		CellularTrauma.shouldExit = true;
                    		break;
                    	default:
                        	break;
                	}
            	}
		}
        public bool enteredButton()
        {
            if (MouseInput.x < buttonX + Texture.Width &&
                    MouseInput.x > buttonX &&
                    MouseInput.y < buttonY + Texture.Height &&
                    MouseInput.y > buttonY)
            {
                return true;
            }
            return false;
        }
	}
}
