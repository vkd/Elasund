using Microsoft.Xna.Framework.Graphics;

namespace Elasund
{
   /// <summary>
   /// Pack of all content of game
   /// </summary>
   public static class ContentPack
   {
      /// <summary>
      /// Main font
      /// </summary>
      public static SpriteFont MainFont;

      /// <summary>
      /// Texture of mouse cursor
      /// </summary>
      public static Texture2D CursorTexture;

      /// <summary>
      /// Array of all buildings textures
      /// [type of buildings][]
      /// </summary>
      public static Texture2D[][] BuildingsTexture;

      /// <summary>
      /// Array of all claim
      /// </summary>
      public static Texture2D[,] ClaimTexture;

      /// <summary>
      /// Texture of cube point
      /// </summary>
      public static Texture2D CubeTexture;

      /// <summary>
      /// Texture of label point
      /// </summary>
      public static Texture2D PointTexture;

      /// <summary>
      /// Texture of map
      /// </summary>
      public static Texture2D MapTexture;

      /// <summary>
      /// Texture of top corner
      /// </summary>
      public static Texture2D TopCornerTexture;

      /// <summary>
      /// Texture of bottom corner
      /// </summary>
      public static Texture2D BottomCornerTexture;

      /// <summary>
      /// Texture of backside church
      /// </summary>
      public static Texture2D BacksideChurchTexture;

      /// <summary>
      /// Texture of ship
      /// </summary>
      public static Texture2D ShipTexture;

      /// <summary>
      /// Initialize array of textures
      /// </summary>
      public static void Initialize()
      {
         //Инициализация массива текстур
			BuildingsTexture = new Texture2D[Constants.QUANTITY_BUILDINGS][];

         BuildingsTexture[(int)Buildings.Church] = new Texture2D[9];
         BuildingsTexture[(int)Buildings.DrawWell] = new Texture2D[1];
         BuildingsTexture[(int)Buildings.Fair] = new Texture2D[1];
         BuildingsTexture[(int)Buildings.Government] = new Texture2D[3];
         BuildingsTexture[(int)Buildings.Hotel] = new Texture2D[1];
         BuildingsTexture[(int)Buildings.House] = new Texture2D[4];
         BuildingsTexture[(int)Buildings.Shop] = new Texture2D[1];
         BuildingsTexture[(int)Buildings.SmallTotem] = new Texture2D[4];
         BuildingsTexture[(int)Buildings.Totem] = new Texture2D[4];
         BuildingsTexture[(int)Buildings.WorkShop] = new Texture2D[4];

			ClaimTexture = new Texture2D[4, 5];
      }
   }
}
