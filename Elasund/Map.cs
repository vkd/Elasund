using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Elasund.Tiles;

namespace Elasund
{
   /// <summary>
   /// Игровая карта
   /// </summary>
   public class Map
   {
      List<Player> players;

      /// <summary>
      /// Quantity players
      /// </summary>
      int quantityPlayers = 0;

      /// <summary>
      /// It's needed for point of mills
      /// </summary>
      int[] positionsPlayersOnMills;

      //Построенные здания
      public List<Tile> releasedBuildings;
      //Здания в резерве
      public List<List<Building>> buildingsReserve;
      //Заявки в резерве
      public List<List<Claim>> claimssReserve;


      ///// <summary>
      ///// Кораблик пиратский
      ///// </summary>
      //public bool _shipIsRed;

      ///// <summary>
      ///// Позиция корабля
      ///// </summary>
      //int _shipIndex;
      //public int ShipIndex
      //{
      //   get { return _shipIndex >= 5 ? _shipIndex + 3 : _shipIndex + 2; }
      //   set { _shipIndex = value >= 8 ? value - 3 : value - 2; }
      //}

      /// <summary>
      /// Количество мельниц для каждого игрока
      /// </summary>
      //public int[] millOfPlayers;

      public Map(int[] gamers)
      {
         players = new List<Player>();

         positionsPlayersOnMills = new int[Constants.MAX_PLAYERS];
         for (int i = 0; i < Constants.MAX_PLAYERS; ++i)
            positionsPlayersOnMills[i] = -1;

         //===================================
         //Initialize lists
         releasedBuildings = new List<Tile>();

         buildingsReserve = new List<List<Building>>();
         for (int i = 0; i < Constants.QUANTITY_BUILDINGS; i++)
            buildingsReserve.Add(new List<Building>());

         claimssReserve = new List<List<Claim>>();
         for (int i = 0; i < 5; i++)
            claimssReserve.Add(new List<Claim>());
         //==================================

         quantityPlayers = 0;
         for (int i = 0; i < Constants.MAX_PLAYERS; ++i)
            if (gamers[i] != -1)
            {
               players.Add(new Player((ColorPlayer)gamers[i]));
               ++quantityPlayers;
               positionsPlayersOnMills[i] = gamers[i];
            }

         foreach (Player p in players)
         {
            AddStartBuildingAndClaimsOfPlayers(p.Color);
         }

         AddAllBuilding();
      }

      /// <summary>
      /// Add стартовые здания
      /// </summary>
      /// <param name="gamers"></param>
      public void AddStartBuildingAndClaimsOfPlayers(ColorPlayer parColor)
      {
         AddPlayersBuildingAndClaimInReserve(parColor);
         PlaceStartBuilding(parColor);
      }

      /// <summary>
      /// Добавить все здания в резерв, кроме построек для игроков
      /// </summary>
      public void AddAllBuilding()
      {
         for (int i = 0; i < 9; i++)
            buildingsReserve[(int)Buildings.Church].Add(
               new Building(Buildings.Church, i));

         for (int i = 0; i < 4; i++)
         {
            buildingsReserve[(int)Buildings.DrawWell].Add(new Building(Buildings.DrawWell, 0));
            buildingsReserve[(int)Buildings.Fair].Add(new Building(Buildings.Fair, 0));
            buildingsReserve[(int)Buildings.Hotel].Add(new Building(Buildings.Hotel, 0));
            buildingsReserve[(int)Buildings.Shop].Add(new Building(Buildings.Shop, 0));
         }
         buildingsReserve[(int)Buildings.Hotel].Add(new Building(Buildings.Hotel, 0));
         buildingsReserve[(int)Buildings.Shop].Add(new Building(Buildings.Shop, 0));

         for (int i = 0; i < 3; i++)
            buildingsReserve[(int)Buildings.Government].Add(new Building(Buildings.Government, i));
      }

      /// <summary>
      /// Добавить постройки игрока в резерв
      /// </summary>
      /// <param name="parColor">Цвет игрока</param>
      void AddPlayersBuildingAndClaimInReserve(ColorPlayer parColor)
      {
         for (int j = 0; j <= Constants.MAX_COST_CLAIM; j++)
         {
            claimssReserve[(int)parColor].Add(new Claim(j, parColor));
         }

         buildingsReserve[(int)Buildings.House].Add(
            new Building(Buildings.House, (int)parColor));
         buildingsReserve[(int)Buildings.WorkShop].Add(
            new Building(Buildings.WorkShop, (int)parColor));
      }

      /// <summary>
      /// Разместить на поле стартовые здания
      /// </summary>
      void PlaceStartBuilding(ColorPlayer parColor)
      {
         Building buildingTemp;

         buildingTemp = new Building(Buildings.SmallTotem, (int)parColor);

         switch (parColor)
         {
            case ColorPlayer.Red:
               releasedBuildings.Add(buildingTemp.SetPositionAndColor(GetX(3), GetY(2), parColor));
               break;
            case ColorPlayer.Green:
               releasedBuildings.Add(buildingTemp.SetPositionAndColor(GetX(3), GetY(7), parColor));
               break;
            case ColorPlayer.Blue:
               releasedBuildings.Add(buildingTemp.SetPositionAndColor(GetX(2), GetY(2), parColor));
               break;
            case ColorPlayer.Yellow:
               releasedBuildings.Add(buildingTemp.SetPositionAndColor(GetX(2), GetY(7), parColor));
               break;
         }

         buildingTemp = new Building(Buildings.Totem, (int)parColor);

         switch (parColor)
         {
            case ColorPlayer.Red:
               releasedBuildings.Add(buildingTemp.SetPositionAndColor(GetX(4), GetY(5), parColor));
               break;
            case ColorPlayer.Green:
               releasedBuildings.Add(buildingTemp.SetPositionAndColor(GetX(4), GetY(3), parColor));
               break;
            case ColorPlayer.Blue:
               releasedBuildings.Add(buildingTemp.SetPositionAndColor(GetX(1), GetY(5), parColor));
               break;
            case ColorPlayer.Yellow:
               releasedBuildings.Add(buildingTemp.SetPositionAndColor(GetX(1), GetY(3), parColor));
               break;
         }
      }

      /// <summary>
      /// Get color from array of colors of players
      /// </summary>
      /// <param name="parColor">Color of player</param>
      /// <returns>Color</returns>
      public static Color GetColor(ColorPlayer parColor)
      {
         switch (parColor)
         {
            case ColorPlayer.Blue:
               return Color.Blue;
            case ColorPlayer.Green:
               return Color.Green;
            case ColorPlayer.Red:
               return Color.Red;
            case ColorPlayer.Yellow:
               return Color.Yellow;
         }
         return Color.White;
      }

      /// <summary>
      /// Draw labels of points on map
      /// </summary>
      /// <param name="spriteBatch">SpriteBatch</param>
      private void DrawPoints(SpriteBatch spriteBatch)
      {
         for (int i = 0; i < Constants.MAX_PLAYERS; ++i)
         {
            if (positionsPlayersOnMills[i] == -1)
               break;
            foreach (Player player in players)
            {
               if (player.Color == (ColorPlayer)positionsPlayersOnMills[i])
               {
                  int dy = 0;
                  int mills = player.Mill;
                  if (mills > 3)
                     dy -= 44;
                  if (mills > 5)
                     dy -= 20;
                  if (mills > 11)
                     mills = 11;
                  spriteBatch.Draw(ContentPack.PointTexture, new Vector2(28, 743 - 52 * mills - i * 10 + dy), 
                     GetColor(player.Color));
               }
            }
         }
      }


      /// <summary>
      /// Draw all release buildings
      /// </summary>
      /// <param name="spriteBatch"></param>
      private void DrawBuildings(SpriteBatch spriteBatch)
      {
         foreach (Building b in releasedBuildings)
         {
            b.Draw(spriteBatch);
         }
      }

      /// <summary>
      /// Количество мельниц при данном здании
      /// </summary>
      /// <param name="rect">Позиция здания</param>
      /// <returns>Количество мельниц</returns>
      public int QuantityMill(Rectangle rect)
      {
         if (rect.Left == GetX(0))
            return 1;
         else if (rect.Intersects(new Rectangle(GetX(5), GetY(0), 10, 10))
               || rect.Intersects(new Rectangle(GetX(7), GetY(0), 10, 10))
               || rect.Intersects(new Rectangle(GetX(5), GetY(9), 10, 10))
               || rect.Intersects(new Rectangle(GetX(7), GetY(9), 10, 10)))
            return 2;
         return 0;
      }

      /// <summary>
      /// Get x for draw on screen
      /// </summary>
      /// <param name="i">Cell on map</param>
      /// <returns>X</returns>
      public int GetX(int i)
      {
         return 153 + (int)(51.3f * i);
      }

      /// <summary>
      /// Get y for draw on screen
      /// </summary>
      /// <param name="i">Cell on screen</param>
      /// <returns>Y</returns>
      public int GetY(int i)
      {
         return 185 + 51 * i;
      }

      /// <summary>
      /// Рисуем карту со всякими зданиями на ней
      /// </summary>
      /// <param name="spriteBatch">Системная переменная</param>
      public void Draw(SpriteBatch spriteBatch)
      {
         //поле
         spriteBatch.Draw(ContentPack.MapTexture, new Vector2(0, 0), Color.White);

         //уголки
         spriteBatch.Draw(ContentPack.TopCornerTexture, new Vector2(GetX(2 * quantityPlayers), GetY(-1)), Color.White);
         spriteBatch.Draw(ContentPack.BottomCornerTexture, new Vector2(GetX(2 * quantityPlayers), GetY(9)), Color.White);

         //очки
         DrawPoints(spriteBatch);

         ////церковь
         //for (int i = 0; i < reserves[(int)Buildings.Church].Count; i++)
         //   spriteBatch.Draw(church0Texture, new Vector2(259 + 2 * i, 23 - 2 * i), Color.White);

         ////кораблик
         //spriteBatch.Draw(shipTexture, new Vector2(GetX(-1) - 16, GetY(_shipIndex) + 3), _shipIsRed ? Color.Red : Color.White);



         //здания
         DrawBuildings(spriteBatch);

      }
   }
}
