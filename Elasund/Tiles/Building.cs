using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Elasund.Tiles
{
   /// <summary>
   /// Здания
   /// </summary>
   public class Building : Tile
   {
      /// <summary>
      /// Type of building
      /// </summary>
      public Buildings BuildingType
      {
         get;
         private set;
      }

      /// <summary>
      /// Determines the texture of building
      /// </summary>
      private int _index = 0;

      /// <summary>
      /// конструктор устанавливающий тип здания
      /// </summary>
      /// <param name="partype">тип здания</param>
      /// <param name="partexture">текстура здания</param>
      /// <param name="parcube">текстура кубика очков</param>
      public Building(Buildings partype, int parIndex)
      {
         BuildingType = partype;
         _index = parIndex;
      }

      /// <summary>
      /// Задать координаты для постройки
      /// </summary>
      /// <param name="x">Х координата</param>
      /// <param name="y">У координата</param>
      public void SetPosition(int x, int y)
      {
         switch (BuildingType)
         {
            case Buildings.Government:
               Rectangle = new Rectangle(x, y, 100, 150);
               break;
            case Buildings.Hotel:
            case Buildings.Shop:
               Rectangle = new Rectangle(x, y, 100, 100);
               break;
            case Buildings.Fair:
            case Buildings.House:
               Rectangle = new Rectangle(x, y, 100, 50);
               break;
            case Buildings.Totem:
            case Buildings.WorkShop:
               Rectangle = new Rectangle(x, y, 50, 100);
               break;
            default:
               Rectangle = new Rectangle(x, y, 50, 50);
               break;
         }
      }


      /// <summary>
      /// Set type of texture for building
      /// </summary>
      /// <param name="parTypeBuilding">Type of building</param>
      /// <param name="parIndex">Index of texture</param>
      public void SetBuildingTypeAndIndex(Buildings parTypeBuilding, int parIndex)
      {
         BuildingType = parTypeBuilding;
         _index = parIndex;
      }

      /// <summary>
      /// Нарисовать
      /// </summary>
      /// <param name="sprateBatch">Системная переменная</param>
      public override void Draw(SpriteBatch sprateBatch)
      {
         sprateBatch.Draw(ContentPack.BuildingsTexture[(int)BuildingType][_index], Rectangle, Color.White);

         //рисуем кубики
         switch (BuildingType)
         {
            case Buildings.Government:
               sprateBatch.Draw(ContentPack.CubeTexture, new Vector2(Rectangle.X + 5, Rectangle.Y + 5), Map.GetColor(ColorPlayer));
               sprateBatch.Draw(ContentPack.CubeTexture, new Vector2(Rectangle.X + 5, Rectangle.Y + 55), Map.GetColor(ColorPlayer));
               break;
            case Buildings.Hotel:
            case Buildings.Shop:
               sprateBatch.Draw(ContentPack.CubeTexture, new Vector2(Rectangle.X + 20, Rectangle.Y + 5), Map.GetColor(ColorPlayer));
               break;
            case Buildings.SmallTotem:
            case Buildings.Totem:
            case Buildings.House:
            case Buildings.WorkShop:
               break;
            default:
               sprateBatch.Draw(ContentPack.CubeTexture, new Vector2(Rectangle.X + 5, Rectangle.Y + 5), Map.GetColor(ColorPlayer));
               break;
         }
      }
   }
}
