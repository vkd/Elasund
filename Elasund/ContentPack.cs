using Microsoft.Xna.Framework.Graphics;

namespace Elasund
{
    public static class ContentPack
    {
        public static SpriteFont MainFont;

        /// <summary>
        /// Array of all buildings textures
        /// [type of buildings][]
        /// </summary>
        public static Texture2D[][] BuildingsTexture;

        /// <summary>
        /// Array of all claim
        /// </summary>
        public static Texture2D[,] ClaimTexture;

        public static Texture2D CubeTexture;
        public static Texture2D PointTexture;
        public static Texture2D MapTexture;

        public static Texture2D TopCornerTexture;
        public static Texture2D BottomCornerTexture;
        
        public static Texture2D BacksideChurchTexture;
        
        public static Texture2D ShipTexture;

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
