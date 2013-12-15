using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Elasund.Tiles;
using Elasund.Core;

namespace Elasund
{
    public class Map
    {
        //List<Player> players;
        //int quantityPlayers = 0;

        ///// <summary>
        ///// It's needed for point of mills
        ///// </summary>
        //int[] positionsPlayersOnMills;

        ////Построенные здания
        //public List<Tile> releasedBuildings;
        ////Здания в резерве
        //public List<List<Building>> buildingsReserve;
        ////Заявки в резерве
        //public List<List<Claim>> claimssReserve;


        ///// <summary>
        ///// Color of current player
        ///// </summary>
        //public ColorPlayer CurrentPlayer
        //{
        //    get;
        //    set;
        //}

        /////// <summary>
        /////// Кораблик пиратский
        /////// </summary>
        ////public bool _shipIsRed;

        /////// <summary>
        /////// Позиция корабля
        /////// </summary>
        ////int _shipIndex;
        ////public int ShipIndex
        ////{
        ////   get { return _shipIndex >= 5 ? _shipIndex + 3 : _shipIndex + 2; }
        ////   set { _shipIndex = value >= 8 ? value - 3 : value - 2; }
        ////}

        ///// <summary>
        ///// Количество мельниц для каждого игрока
        ///// </summary>
        ////public int[] millOfPlayers;

        public Map(int[] gamers)
        {
            //players = new List<Player>();

            //positionsPlayersOnMills = new int[Constants.MAX_PLAYERS];
            //for (int i = 0; i < Constants.MAX_PLAYERS; ++i)
            //    positionsPlayersOnMills[i] = -1;

            ////===================================
            ////Initialize lists
            //releasedBuildings = new List<Tile>();

            //buildingsReserve = new List<List<Building>>();
            //for (int i = 0; i < Constants.QUANTITY_BUILDINGS; i++)
            //    buildingsReserve.Add(new List<Building>());

            //claimssReserve = new List<List<Claim>>();
            //for (int i = 0; i < 5; i++)
            //    claimssReserve.Add(new List<Claim>());
            ////==================================

            //quantityPlayers = 0;
            //for (int i = 0; i < Constants.MAX_PLAYERS; ++i)
            //    if (gamers[i] != -1)
            //    {
            //        players.Add(new Player((ColorPlayer)gamers[i]));
            //        ++quantityPlayers;
            //        positionsPlayersOnMills[i] = gamers[i];
            //    }

            //foreach (Player p in players)
            //{
            //    AddStartBuildingAndClaimsOfPlayers(p.Color);
            //}

            //AddAllBuilding();
            //CreateTableOfBuildings();
        }

        ///// <summary>
        ///// Add стартовые здания
        ///// </summary>
        ///// <param name="gamers"></param>
        //public void AddStartBuildingAndClaimsOfPlayers(ColorPlayer parColor)
        //{
        //    AddPlayersBuildingAndClaimInReserve(parColor);
        //    PlaceStartBuilding(parColor);
        //}

        ///// <summary>
        ///// Добавить все здания в резерв, кроме построек для игроков
        ///// </summary>
        //public void AddAllBuilding()
        //{
        //    for (int i = 0; i < 9; i++)
        //        buildingsReserve[(int)Buildings.Church].Add(
        //           new Building(Buildings.Church, i));

        //    for (int i = 0; i < 4; i++)
        //    {
        //        buildingsReserve[(int)Buildings.DrawWell].Add(new Building(Buildings.DrawWell, 0));
        //        buildingsReserve[(int)Buildings.Fair].Add(new Building(Buildings.Fair, 0));
        //        buildingsReserve[(int)Buildings.Hotel].Add(new Building(Buildings.Hotel, 0));
        //        buildingsReserve[(int)Buildings.Shop].Add(new Building(Buildings.Shop, 0));
        //    }
        //    buildingsReserve[(int)Buildings.Hotel].Add(new Building(Buildings.Hotel, 0));
        //    buildingsReserve[(int)Buildings.Shop].Add(new Building(Buildings.Shop, 0));

        //    for (int i = 0; i < 3; i++)
        //        buildingsReserve[(int)Buildings.Government].Add(new Building(Buildings.Government, i));
        //}

        ///// <summary>
        ///// Добавить постройки игрока в резерв
        ///// </summary>
        ///// <param name="parColor">Цвет игрока</param>
        //void AddPlayersBuildingAndClaimInReserve(ColorPlayer parColor)
        //{
        //    for (int j = 0; j <= Constants.MAX_COST_CLAIM; j++)
        //    {
        //        claimssReserve[(int)parColor].Add(new Claim(j, parColor));
        //    }

        //    buildingsReserve[(int)Buildings.House].Add(
        //       new Building(Buildings.House, (int)parColor));
        //    buildingsReserve[(int)Buildings.WorkShop].Add(
        //       new Building(Buildings.WorkShop, (int)parColor));
        //}

        ///// <summary>
        ///// Разместить на поле стартовые здания
        ///// </summary>
        //void PlaceStartBuilding(ColorPlayer parColor)
        //{
        //    Building buildingTemp;

        //    buildingTemp = new Building(Buildings.SmallTotem, (int)parColor);
        //    buildingTemp.ColorPlayer = parColor;

        //    switch (parColor)
        //    {
        //        case ColorPlayer.Red:
        //            buildingTemp.SetPosition(GetX(3), GetY(2));
        //            break;
        //        case ColorPlayer.Green:
        //            buildingTemp.SetPosition(GetX(3), GetY(7));
        //            break;
        //        case ColorPlayer.Blue:
        //            buildingTemp.SetPosition(GetX(2), GetY(2));
        //            break;
        //        case ColorPlayer.Yellow:
        //            buildingTemp.SetPosition(GetX(2), GetY(7));
        //            break;
        //    }

        //    releasedBuildings.Add(buildingTemp);

        //    buildingTemp = new Building(Buildings.Totem, (int)parColor);
        //    buildingTemp.ColorPlayer = parColor;

        //    switch (parColor)
        //    {
        //        case ColorPlayer.Red:
        //            buildingTemp.SetPosition(GetX(4), GetY(5));
        //            break;
        //        case ColorPlayer.Green:
        //            buildingTemp.SetPosition(GetX(4), GetY(3));
        //            break;
        //        case ColorPlayer.Blue:
        //            buildingTemp.SetPosition(GetX(1), GetY(5));
        //            break;
        //        case ColorPlayer.Yellow:
        //            buildingTemp.SetPosition(GetX(1), GetY(3));
        //            break;
        //    }
        //    releasedBuildings.Add(buildingTemp);
        //}






        ///// <summary>
        ///// Draw all release buildings
        ///// </summary>
        ///// <param name="spriteBatch"></param>
        //private void DrawBuildings(SpriteBatch spriteBatch)
        //{
        //    foreach (Building b in releasedBuildings)
        //    {
        //        b.Draw(spriteBatch);
        //    }

        //    foreach (List<Building> list in buildingsReserve)
        //    {
        //        foreach (Building b in list)
        //        {
        //            b.Draw(spriteBatch);
        //        }
        //    }
        //}

        ///// <summary>
        ///// Количество мельниц при данном здании
        ///// </summary>
        ///// <param name="rect">Позиция здания</param>
        ///// <returns>Количество мельниц</returns>
        //public int QuantityMill(Rectangle rect)
        //{
        //    if (rect.Left == GetX(0))
        //        return 1;
        //    else if (rect.Intersects(new Rectangle(GetX(5), GetY(0), 10, 10))
        //          || rect.Intersects(new Rectangle(GetX(7), GetY(0), 10, 10))
        //          || rect.Intersects(new Rectangle(GetX(5), GetY(9), 10, 10))
        //          || rect.Intersects(new Rectangle(GetX(7), GetY(9), 10, 10)))
        //        return 2;
        //    return 0;
        //}



        ///// <summary>
        ///// Добавить здание в таблицу
        ///// </summary>
        ///// <param name="buildingType">Тип строения</param>
        //private void AddToTableOfBuildings(Building parBuilding, ref int x, ref int y, ref int dy)
        //{
        //    int textureWidth;
        //    int textureHeight;

        //    switch (parBuilding.BuildingType)
        //    {
        //        case Buildings.Government:
        //            textureWidth = 100;
        //            textureHeight = 150;
        //            break;
        //        case Buildings.Hotel:
        //        case Buildings.Shop:
        //            textureWidth = 100;
        //            textureHeight = 100;
        //            break;
        //        case Buildings.Fair:
        //        case Buildings.House:
        //            textureWidth = 100;
        //            textureHeight = 50;
        //            break;
        //        case Buildings.Totem:
        //        case Buildings.WorkShop:
        //            textureWidth = 50;
        //            textureHeight = 100;
        //            break;
        //        default:
        //            textureWidth = 50;
        //            textureHeight = 50;
        //            break;
        //    }

        //    if (x - textureWidth - 1 < Settings.BOARD_WIDTH)
        //    {
        //        y += dy + 15;
        //        x = Settings.SCREEN_WIDTH - 10;// graphics.PreferredBackBufferWidth - 10;
        //        dy = textureHeight;
        //    }
        //    x -= textureWidth;


        //    parBuilding.SetPosition(x, y);

        //    x -= 15;
        //    if (dy < textureHeight)
        //        dy = textureHeight;
        //}

        ///// <summary>
        ///// Создание таблицы доступных для строительства зданий
        ///// </summary>
        //private void CreateTableOfBuildings()
        //{
        //    int x = Settings.SCREEN_WIDTH - 10;// graphics.PreferredBackBufferWidth - 10;
        //    int y = 10;
        //    int dy = 0;

        //    if (buildingsReserve[(int)Buildings.Government].Count != 0)
        //        AddToTableOfBuildings(buildingsReserve[(int)Buildings.Government][0], ref x, ref y, ref dy);//, Buildings.Government);
        //    if (buildingsReserve[(int)Buildings.Hotel].Count != 0)
        //        AddToTableOfBuildings(buildingsReserve[(int)Buildings.Hotel][0], ref x, ref y, ref dy);//, Buildings.Hotel);
        //    if (buildingsReserve[(int)Buildings.Shop].Count != 0)
        //        AddToTableOfBuildings(buildingsReserve[(int)Buildings.Shop][0], ref x, ref y, ref dy);//, Buildings.Shop);
        //    if (buildingsReserve[(int)Buildings.Fair].Count != 0)
        //        AddToTableOfBuildings(buildingsReserve[(int)Buildings.Fair][0], ref x, ref y, ref dy);//, Buildings.Fair);
        //    if (buildingsReserve[(int)Buildings.DrawWell].Count != 0)
        //        AddToTableOfBuildings(buildingsReserve[(int)Buildings.DrawWell][0], ref x, ref y, ref dy);//, Buildings.DrawWell);

        //    foreach (Building building in buildingsReserve[(int)Buildings.House])// map.CurrentPlayer.building)
        //    {
        //        if (building.ColorPlayer == CurrentPlayer)
        //            AddToTableOfBuildings(building, ref x, ref y, ref dy);//, tempBuilding.BuildingType);
        //    }
        //    foreach (Building building in buildingsReserve[(int)Buildings.WorkShop])// map.CurrentPlayer.building)
        //    {
        //        if (building.ColorPlayer == CurrentPlayer)
        //            AddToTableOfBuildings(building, ref x, ref y, ref dy);//, tempBuilding.BuildingType);
        //    }
        //}

        ///// <summary>
        ///// Рисуем карту со всякими зданиями на ней
        ///// </summary>
        ///// <param name="spriteBatch">Системная переменная</param>
        //public void Draw(SpriteBatch spriteBatch)
        //{



        //    //здания
        //    DrawBuildings(spriteBatch);

        //}
    }
}
