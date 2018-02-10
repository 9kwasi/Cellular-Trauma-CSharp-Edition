
using System;
using Microsoft.Xna.Framework.Input;
namespace Engine
{
	/// <summary>
	/// Description of Button.
	/// </summary>
	public class Button
	{
		String Name;
		int buttonX;
		int buttonY;
		int width;
		int height;
		public Button(String name, int x, int y, int w, int h)
		{
			Name = name;
			buttonX = x;
			buttonY = y;
			width = w;
			height = h;
		}
		public String tick(){
		        if (enteredButton() && MouseInput.lastMouseState.LeftButton == ButtonState.Released && MouseInput.mouseState.LeftButton == ButtonState.Pressed)
           		{
                	switch (Name)
                	{
                    	case "Play": //the name of the button
                			Console.WriteLine("Clicked "+Name);
                			return Name;
                    	case "Credits":
                        	Console.WriteLine("Clicked "+Name);
                        	return Name;
                    	case "Quit":
                    		Console.WriteLine("Clicked "+Name);
                    		return Name;
                    	default:
                        	break;
                	}
            	}
		    	return null;
		}
        public bool enteredButton()
        {
            if (MouseInput.x < buttonX + width &&
                    MouseInput.x > buttonX &&
                    MouseInput.y < buttonY + height &&
                    MouseInput.y > buttonY)
            {
                return true;
            }
            return false;
        }

	}
}
