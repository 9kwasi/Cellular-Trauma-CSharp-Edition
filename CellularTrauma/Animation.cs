using System;
using System.Collections;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CellularTrauma
{
	/// <summary>
	/// Description of Animation.
	/// </summary>
	public class Animation
	{
		ArrayList imgs;
		int speed{get;set;}
		int frame{get;set;}
		int count{get;set;}
		
		public Animation(Texture2D img1,Texture2D img2,Texture2D img3,Texture2D img4,Texture2D img5,Texture2D img6,Texture2D img7,Texture2D img8,Texture2D img9,int speed)
		{
			count=0;
			imgs=new ArrayList();
			imgs.Add(img1);
			imgs.Add(img2);
			imgs.Add(img3);
			imgs.Add(img4);
			imgs.Add(img5);
			imgs.Add(img6);
			imgs.Add(img7);
			imgs.Add(img8);
			imgs.Add(img9);
			
			img1.Dispose();
			img2.Dispose();
			img3.Dispose();
			img4.Dispose();
			img5.Dispose();
			img6.Dispose();
			img7.Dispose();
			img8.Dispose();
			img9.Dispose();
			
			this.speed=speed;
			frame=0;
		}
		public Animation(Texture2D img1,Texture2D img2,Texture2D img3,Texture2D img4,Texture2D img5,Texture2D img6,Texture2D img7,Texture2D img8,int speed)
		{
			count=0;
			imgs=new ArrayList();
			imgs.Add(img1);
			imgs.Add(img2);
			imgs.Add(img3);
			imgs.Add(img4);
			imgs.Add(img5);
			imgs.Add(img6);
			imgs.Add(img7);
			imgs.Add(img8);
			
			img1.Dispose();
			img2.Dispose();
			img3.Dispose();
			img4.Dispose();
			img5.Dispose();
			img6.Dispose();
			img7.Dispose();
			img8.Dispose();
			this.speed=speed;
			frame=0;
		}
		public Animation(Texture2D img1,Texture2D img2,Texture2D img3,Texture2D img4,Texture2D img5,Texture2D img6,Texture2D img7,int speed)
		{
			
			imgs=new ArrayList();
			imgs.Add(img1);
			imgs.Add(img2);
			imgs.Add(img3);
			imgs.Add(img4);
			imgs.Add(img5);
			imgs.Add(img6);
			imgs.Add(img7);
			
			img1.Dispose();
			img2.Dispose();
			img3.Dispose();
			img4.Dispose();
			img5.Dispose();
			img6.Dispose();
			img7.Dispose();
			this.speed=speed;
			frame=0;
		}
		public Animation(Texture2D img1,Texture2D img2,Texture2D img3,Texture2D img4,Texture2D img5,Texture2D img6,int speed)
		{
			count=0;
			imgs=new ArrayList();
			imgs.Add(img1);
			imgs.Add(img2);
			imgs.Add(img3);
			imgs.Add(img4);
			imgs.Add(img5);
			imgs.Add(img6);
			
			img1.Dispose();
			img2.Dispose();
			img3.Dispose();
			img4.Dispose();
			img5.Dispose();
			img6.Dispose();
			this.speed=speed;
			frame=0;
		}
		public Animation(Texture2D img1,Texture2D img2,Texture2D img3,Texture2D img4,Texture2D img5,int speed)
		{
			count=0;
			imgs=new ArrayList();
			imgs.Add(img1);
			imgs.Add(img2);
			imgs.Add(img3);
			imgs.Add(img4);
			imgs.Add(img5);
			
			img1.Dispose();
			img2.Dispose();
			img3.Dispose();
			img4.Dispose();
			img5.Dispose();
			this.speed=speed;
			frame=0;
		}
		public Animation(Texture2D img1,Texture2D img2,Texture2D img3,Texture2D img4,int speed)
		{
			count=0;
			imgs=new ArrayList();
			imgs.Add(img1);
			imgs.Add(img2);
			imgs.Add(img3);
			imgs.Add(img4);
			
			img1.Dispose();
			img2.Dispose();
			img3.Dispose();
			img4.Dispose();
			this.speed=speed;
			frame=0;
		}
		public Animation(Texture2D img1,Texture2D img2,Texture2D img3,int speed)
		{
			count=0;
			imgs=new ArrayList();
			imgs.Add(img1);
			imgs.Add(img2);
			imgs.Add(img3);
			
			img1.Dispose();
			img2.Dispose();
			img3.Dispose();
			this.speed=speed;
			frame=0;
		}
		public Animation(Texture2D img1,Texture2D img2,int speed)
		{
			count=0;
			imgs=new ArrayList();
			imgs.Add(img1);
			imgs.Add(img2);
			
			img1.Dispose();
			img2.Dispose();
			this.speed=speed;
			frame=0;
		}
		public void Draw(SpriteBatch spriteBatch){
			//卐卐卐卐卐卐卐卐卐卐卐卐卐卐卐卐卐卐卐卐卐卐卐卐卐卐卐卐卐卐卐卐卐卐卐卐
			spriteBatch.Begin();
			spriteBatch.Draw((Texture2D)imgs[frame], pos, Color.White);
			spriteBatch.End();
			//卐卐卐卐卐卐卐卐卐卐卐卐卐卐卐卐卐卐卐卐卐卐卐卐卐卐卐卐卐卐卐卐卐卐卐卐
		}
		public void Tick(){
			if(count==speed){
				SwitchFrames();
				return;
			}
			count++;
		}
		public void SwitchFrames(){
			if(frame==imgs.Count-1){
				frame=0;
			}else{
				frame++;
			}
		}
		
	}
}
