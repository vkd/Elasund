//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using Microsoft.Xna.Framework.Graphics;
//using Microsoft.Xna.Framework;

//namespace Elasund
//{
//   /// <summary>
//   /// Здания
//   /// </summary>
//   public class Building : Tile
//   {
//      public Buildings _buildingType;


//      /// <summary>
//      /// конструктор устанавливающий тип здания
//      /// </summary>
//      /// <param name="partype">тип здания</param>
//      /// <param name="partexture">текстура здания</param>
//      /// <param name="parcube">текстура кубика очков</param>
//      public Building(Buildings partype, Texture2D partexture, Texture2D parcube)
//         : base(partexture)
//      {
//         _buildingType = partype;
//         cubeTexture = parcube;		
//      }

//      /// <summary>
//      /// Задать координаты для постройки
//      /// </summary>
//      /// <param name="x">Х координата</param>
//      /// <param name="y">У координата</param>
//      /// <param name="color">Цвет игрока</param>
//      /// <returns>Само построенное здание</returns>
//      public Building SetPositionAndColor(int x, int y, ColorPlayer parColor)
//      {
//         switch (_buildingType)
//         {
//            case Buildings.Government:
//               Rectangle = new Rectangle(x, y, 100, 150);
//               break;
//            case Buildings.Hotel:
//            case Buildings.Shop:
//               Rectangle = new Rectangle(x, y, 100, 100);
//               break;
//            case Buildings.Fair:
//            case Buildings.House:
//               Rectangle = new Rectangle(x, y, 100, 50);
//               break;
//            case Buildings.Totem:
//            case Buildings.WorkShop:
//               Rectangle = new Rectangle(x, y, 50, 100);
//               break;
//            default:
//               Rectangle = new Rectangle(x, y, 50, 50);
//               break;
//         }
//         Color = parColor;
//         return this;
//      }

//      //получить цвет из массива цветов игроков
//      private Color GetColor(ColorPlayer parColor)
//      {
//         switch (parColor)
//         {
//            case ColorPlayer.Blue:
//               return Color.Blue;
//            case ColorPlayer.Green:
//               return Color.Green;
//            case ColorPlayer.Red:
//               return Color.Red;
//            case ColorPlayer.Yellow:
//               return Color.Yellow;
//         }
//         return Color.White;
//      }

//      /// <summary>
//      /// Нарисовать
//      /// </summary>
//      /// <param name="sprateBatch">Системная переменная</param>
//      public override void Draw(SpriteBatch sprateBatch)
//      {
//         base.Draw(sprateBatch);

//         //рисуем кубики
//         switch (_buildingType)
//         {
//            case Buildings.Government:
//               sprateBatch.Draw(cubeTexture, new Vector2(Rectangle.X + 5, Rectangle.Y + 5), GetColor(Color));
//               sprateBatch.Draw(cubeTexture, new Vector2(Rectangle.X + 5, Rectangle.Y + 55), GetColor(Color));
//               break;
//            case Buildings.Hotel:
//            case Buildings.Shop:
//               sprateBatch.Draw(cubeTexture, new Vector2(Rectangle.X + 20, Rectangle.Y + 5), GetColor(Color));
//               break;
//            case Buildings.SmallTotem:
//            case Buildings.Totem:
//            case Buildings.House:
//            case Buildings.WorkShop:
//               break;
//            default:
//               sprateBatch.Draw(cubeTexture, new Vector2(Rectangle.X + 5, Rectangle.Y + 5), GetColor(Color));
//               break;
//         }
//      }
//   }
//}
