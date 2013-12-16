using System;
using Microsoft.Xna.Framework;

namespace Elasund
{
    class Referee
    {
        ///// <summary>
        ///// Текущий этап игры
        ///// </summary>
        //GameAction gameAction;

        ///// <summary>
        ///// Сумма 2х 6ти гранных кубов
        ///// </summary>
        //SumDice sumDice;

        //Map map;

        //int currentPlayer;

        public Referee()
        {
            //   map = parMap;

            //   //Инициализация игрового режима
            //   gameAction = GameAction.Starting;

            //   sumDice = new SumDice(2, 6);
            //   sumDice.GetNextResult();
            //   while (sumDice.GetResult() == 7)
            //   {
            //      sumDice.Refresh();
            //      sumDice.GetNextResult();
            //   }

            //   map.ShipIndex = sumDice.GetResult();

            //   players = new List<BasePlayer>();
            //   for (int i = 0; i < Constants.MAX_PLAYERS; i++)
            //      if (parPlayers[i] != -1)
            //      {
            //         players.Add(new BasePlayer(map.GetColorOfPlayer(parPlayers[i]), GetRandomVote()));
            //         map.millOfPlayers[i] = 0;
            //      }

            //   currentPlayer = 0;
        }

        /// <summary>
        /// Построить здание
        /// </summary>
        /// <returns></returns>
        //void Build(Building parBuilding)
        //{
        //   map.reserves[(int)parBuilding._buildingType].Remove(parBuilding);
        //   map.buildings.Add(parBuilding);
        //}

        /// <summary>
        /// Оставить заявку
        /// </summary>
        /// <returns></returns>
        //void Claim(Claim parClaim)
        //{
        //   map.claimsReserves[(int)parClaim._color].Remove(parClaim);
        //   map.buildings.Add(parClaim);
        //}

        /// <summary>
        /// Разрушение здания
        /// </summary>
        /// <returns></returns>
        //void Debuild(Building parBuilding)
        //{
        //   map.buildings.Remove(parBuilding);
        //   map.reserves[(int)parBuilding._buildingType].Add(parBuilding);
        //}

        /// <summary>
        /// Снятие заявки
        /// </summary>
        /// <returns></returns>
        //void Declaim(Claim parClaim)
        //{
        //   map.buildings.Remove(parClaim);
        //   map.claimsReserves[(int)parClaim._color].Add(parClaim);
        //}

        /// <summary>
        /// Получить одну случайную карту голоса
        /// </summary>
        /// <returns>Номер карты голоса</returns>
        public int GetRandomVote()
        {
            Random rand = new Random();
            return rand.Next(3);
        }

        public void ImWin()
        {
            //TODO типа я говорю что выйграл, надо проверить и остановить игру
        }

        public void Update(GameTime gameTime)
        {
            //switch (gameAction)
            //{
            //   case GameAction.Income:
            //      sumDice.GetNextResult();
            //      map.ShipIndex = sumDice.GetResult();

            //      Income();

            //      gameAction = GameAction.Building;
            //      break;

            //   case GameAction.Building:
            //      break;

            //   case GameAction.Claim:
            //      break;

            //   case GameAction.AdditionAction:

            //      SetNextPlayer();
            //      gameAction = GameAction.Income;
            //      break;

            //   //case GameAction.Pause:
            //   //   break;

            //   case GameAction.Starting:
            //      

            //      Income();

            //      gameAction = GameAction.Building;
            //      break;
            //}
        }

        /// <summary>
        /// Определяет доходы всех игроков по текущему положению кораблика
        /// </summary>
        //void Income()
        //{
        //   Rectangle rect = new Rectangle(map.GetX(0), map.GetY(map.ShipIndex), 450, 50);

        //   foreach (Building building in map.buildings)
        //   {
        //      if (building._rect.Intersects(rect))
        //      {
        //         switch (building._buildingType)
        //         {
        //            case Buildings.Hotel:
        //            case Buildings.House:
        //            case Buildings.SmallTotem:
        //               foreach (BasePlayer player in players)
        //               {
        //                  if (player._color == building._color)
        //                     player._votes[GetRandomVote()]++;
        //               }
        //               break;
        //            case Buildings.Shop:
        //            case Buildings.Totem:
        //            case Buildings.WorkShop:
        //               foreach (BasePlayer player in players)
        //               {
        //                  if (player._color == building._color)
        //                     player._money++;
        //               }
        //               break;
        //         }
        //      }
        //   }
        //}


        /// <summary>
        /// передать ход следующему игроку
        /// </summary>
        //void SetNextPlayer()
        //{
        //   currentPlayer++;
        //   if (currentPlayer >= players.Count)
        //      currentPlayer = 0;
        //}
    }
}
