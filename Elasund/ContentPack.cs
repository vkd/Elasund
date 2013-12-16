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

            BuildingsTexture[(int)BuildingType.Church] = new Texture2D[9];
            BuildingsTexture[(int)BuildingType.DrawWell] = new Texture2D[1];
            BuildingsTexture[(int)BuildingType.Fair] = new Texture2D[1];
            BuildingsTexture[(int)BuildingType.Government] = new Texture2D[3];
            BuildingsTexture[(int)BuildingType.Hotel] = new Texture2D[1];
            BuildingsTexture[(int)BuildingType.House] = new Texture2D[4];
            BuildingsTexture[(int)BuildingType.Shop] = new Texture2D[1];
            BuildingsTexture[(int)BuildingType.SmallTotem] = new Texture2D[4];
            BuildingsTexture[(int)BuildingType.Totem] = new Texture2D[4];
            BuildingsTexture[(int)BuildingType.WorkShop] = new Texture2D[4];

            ClaimTexture = new Texture2D[4, 5];
        }

        public static void LoadContent(Microsoft.Xna.Framework.Content.ContentManager Content)
        {
            ContentPack.MainFont = Content.Load<SpriteFont>("SpriteFont");

            LoadBuildings(Content);
            LoadClaims(Content);

            ContentPack.CubeTexture = Content.Load<Texture2D>("Textures/Cube");
            ContentPack.PointTexture = Content.Load<Texture2D>("Textures/Point");
            ContentPack.MapTexture = Content.Load<Texture2D>("Textures/Board");
            ContentPack.TopCornerTexture = Content.Load<Texture2D>("Textures/Corner1");
            ContentPack.BottomCornerTexture = Content.Load<Texture2D>("Textures/Corner2");
            ContentPack.BacksideChurchTexture = Content.Load<Texture2D>("Textures/Church0");
            ContentPack.ShipTexture = Content.Load<Texture2D>("Textures/Ship");
        }

        private static void LoadBuildings(Microsoft.Xna.Framework.Content.ContentManager Content)
        {
            for (int i = 0; i < 9; ++i)
            {
                ContentPack.BuildingsTexture[(int)BuildingType.Church][i] = Content.Load<Texture2D>("Textures/Buildings/Church" + (i + 1));
            }
            ContentPack.BuildingsTexture[(int)BuildingType.DrawWell][0] = Content.Load<Texture2D>("Textures/Buildings/DrawWell");
            ContentPack.BuildingsTexture[(int)BuildingType.Fair][0] = Content.Load<Texture2D>("Textures/Buildings/Fair");
            for (int i = 0; i < 3; ++i)
                ContentPack.BuildingsTexture[(int)BuildingType.Government][i] = Content.Load<Texture2D>("Textures/Buildings/Government" + (i + 1));
            ContentPack.BuildingsTexture[(int)BuildingType.Hotel][0] = Content.Load<Texture2D>("Textures/Buildings/Hotel");
            for (int i = 0; i < 4; ++i)
                ContentPack.BuildingsTexture[(int)BuildingType.House][i] = Content.Load<Texture2D>("Textures/Buildings/House" + i);
            ContentPack.BuildingsTexture[(int)BuildingType.Shop][0] = Content.Load<Texture2D>("Textures/Buildings/Shop");
            for (int i = 0; i < 4; ++i)
            {
                ContentPack.BuildingsTexture[(int)BuildingType.SmallTotem][i] = Content.Load<Texture2D>("Textures/Buildings/SmallTotem" + i);
                ContentPack.BuildingsTexture[(int)BuildingType.Totem][i] = Content.Load<Texture2D>("Textures/Buildings/Totem" + i);
                ContentPack.BuildingsTexture[(int)BuildingType.WorkShop][i] = Content.Load<Texture2D>("Textures/Buildings/WorkShop" + i);
            }
        }

        private static void LoadClaims(Microsoft.Xna.Framework.Content.ContentManager Content)
        {
            for (int i = 0; i <= Constants.MAX_COST_CLAIM; ++i)
            {
                ContentPack.ClaimTexture[0, i] = Content.Load<Texture2D>("Textures/Claims/r" + i);
                ContentPack.ClaimTexture[1, i] = Content.Load<Texture2D>("Textures/Claims/g" + i);
                ContentPack.ClaimTexture[2, i] = Content.Load<Texture2D>("Textures/Claims/b" + i);
                ContentPack.ClaimTexture[3, i] = Content.Load<Texture2D>("Textures/Claims/y" + i);
            }
        }
    }
}
