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
      /// <summary>
      /// Value of claim
      /// </summary>
      public int Value
      {
         get;
         set;
      }

		/// <summary>
		/// Конструктор устанавливающий цену заявки
		/// </summary>
		/// <param name="parNumber"></param>
		/// <param name="parTexture"></param>
		/// <param name="parColor"></param>
      public Claim(int parNumber, ColorPlayer parColor)
      {
         Value = parNumber;
         ColorPlayer = parColor;
      }

      /// <summary>
      /// Draw claim
      /// </summary>
      /// <param name="spriteBatch">SpriteBatch</param>
      public override void Draw(SpriteBatch spriteBatch)
      {
         spriteBatch.Draw(ContentPack.ClaimTexture[(int)ColorPlayer, Value], Rectangle, Color.White);
      }
	}
}
