
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Engine
{
	/// <summary>
	/// Description of Entity.
	/// </summary>
	public abstract class GameCharacter
	{
		Texture2D portrait{get;set;}
		
		//Animation[] anims{get;set;}
		
		public Rectangle hitBox{get;set;}
		
		public int maxSpeed{get;set;}
		public int acceleration {get;set;}
		public int frameIndex{get;set;}
		public double health{get;set;}
		public double damage{get;set;}
		public bool jumping{get;set;}
		public bool facingLeft{get;set;}
		
		public int XPos {get;set;}
		public int YPos {get;set;}
		public int XVel {get;set;}
		public int YVel {get;set;}
		
		public GameCharacter()
		{
			
		}
		
		
	}
}
