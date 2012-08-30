using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Elasund.Tiles
{
   /// <summary>
   /// Заявки на строительство
   /// </summary>
   public class Claim : Tiles.Tile
   {
		public int _number;

		/// <summary>
		/// Конструктор устанавливающий цену заявки
		/// </summary>
		/// <param name="parNumber"></param>
		/// <param name="parTexture"></param>
		/// <param name="parColor"></param>
      //public Claim(int parNumber, Texture2D parTexture, ColorPlayer parColor)
      //   : base(parTexture)
      //{
      //   _number = parNumber;
      //   Color = parColor;
      //}
	}
}
