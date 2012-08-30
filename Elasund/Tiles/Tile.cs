using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Elasund.Tiles
{
   /// <summary>
   /// Объекты помещаемые на карту
   /// </summary>
   public abstract class Tile
   {
      /// <summary>
      /// Rectangle
      /// </summary>
      public Rectangle Rectangle
      {
         get;
         set;
      }

      /// <summary>
      /// Color
      /// </summary>
      //public ColorPlayer Color
      //{
      //   get;
      //   set;
      //}

		/// <summary>
		/// Установить позицию
		/// </summary>
		/// <param name="x">X координата</param>
		/// <param name="y">Y координата</param>
		public virtual void SetRectangle(int x, int y)
		{
			Rectangle = new Rectangle(x, y, 50, 50);
		}

		/// <summary>
		/// Нарисовать
		/// </summary>
		/// <param name="spriteBatch">Системная переменная</param>
      public abstract void Draw(SpriteBatch spriteBatch);
	}
}
