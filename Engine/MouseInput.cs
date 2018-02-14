
using System;
using Microsoft.Xna.Framework.Input;

namespace Engine
{
	/// <summary>
	/// Description of MouseInput.
	/// </summary>
	public class MouseInput
	{
		public static MouseState mouseState;
		public static MouseState lastMouseState;
		public static int x;
		public static int y;
		public MouseInput()
		{
			MouseState mouseState = Mouse.GetState();
			x = mouseState.X;
			y = mouseState.Y;
		}
		public void Update()
		{
			lastMouseState = mouseState;
			mouseState = Mouse.GetState();
			x = mouseState.X;
			y = mouseState.Y;
		}
	}
}
