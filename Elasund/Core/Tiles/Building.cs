using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Elasund.Core.Tiles
{
    public class Building
    {
        public BuildingType BuildingType { get; private set; }

        /// <summary>
        /// Determines the texture of building
        /// </summary>
        private int _index = 0;

        public Building(BuildingType type, int index)
        {
            BuildingType = type;
            _index = index;
        }

        //public void SetPosition(int x, int y)
        //{
        //    switch (BuildingType)
        //    {
        //        case BuildingType.Government:
        //            Rectangle = new Rectangle(x, y, 100, 150);
        //            break;
        //        case BuildingType.Hotel:
        //        case BuildingType.Shop:
        //            Rectangle = new Rectangle(x, y, 100, 100);
        //            break;
        //        case BuildingType.Fair:
        //        case BuildingType.House:
        //            Rectangle = new Rectangle(x, y, 100, 50);
        //            break;
        //        case BuildingType.Totem:
        //        case BuildingType.WorkShop:
        //            Rectangle = new Rectangle(x, y, 50, 100);
        //            break;
        //        default:
        //            Rectangle = new Rectangle(x, y, 50, 50);
        //            break;
        //    }
        //}


        /// <summary>
        /// Set type of texture for building
        /// </summary>
        /// <param name="parTypeBuilding">Type of building</param>
        /// <param name="parIndex">Index of texture</param>
        public void SetBuildingTypeAndIndex(BuildingType parTypeBuilding, int parIndex)
        {
            BuildingType = parTypeBuilding;
            _index = parIndex;
        }

        /// <summary>
        /// Нарисовать
        /// </summary>
        /// <param name="sprateBatch">Системная переменная</param>
        public void Draw(SpriteBatch sprateBatch)
        {
            //sprateBatch.Draw(ContentPack.BuildingsTexture[(int)BuildingType][_index], Rectangle, Color.White);

            ////рисуем кубики
            //switch (BuildingType)
            //{
            //   case Buildings.Government:
            //      sprateBatch.Draw(ContentPack.CubeTexture, new Vector2(Rectangle.X + 5, Rectangle.Y + 5), Map.GetColor(ColorPlayer));
            //      sprateBatch.Draw(ContentPack.CubeTexture, new Vector2(Rectangle.X + 5, Rectangle.Y + 55), Map.GetColor(ColorPlayer));
            //      break;
            //   case Buildings.Hotel:
            //   case Buildings.Shop:
            //      sprateBatch.Draw(ContentPack.CubeTexture, new Vector2(Rectangle.X + 20, Rectangle.Y + 5), Map.GetColor(ColorPlayer));
            //      break;
            //   case Buildings.SmallTotem:
            //   case Buildings.Totem:
            //   case Buildings.House:
            //   case Buildings.WorkShop:
            //      break;
            //   default:
            //      sprateBatch.Draw(ContentPack.CubeTexture, new Vector2(Rectangle.X + 5, Rectangle.Y + 5), Map.GetColor(ColorPlayer));
            //      break;
            //}
        }
    }
}
