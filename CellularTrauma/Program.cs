
using System;
using Microsoft.Xna.Framework;

namespace CellularTrauma
{
	/// <summary>
	/// Description of Program.
	/// </summary>
	public class Program
	{
	private static CellularTrauma game;
	/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			game = new CellularTrauma();
			game.Run();
		}
	}
}
