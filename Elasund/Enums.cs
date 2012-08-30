namespace Elasund
{
   /// <summary>
   /// Текущий этап игры
   /// </summary>
   enum GameAction
   {
      /// <summary>
      /// Add new resourses
      /// </summary>
      Income,
      /// <summary>
      /// Building
      /// </summary>
      Building,
      /// <summary>
      /// Add claims
      /// </summary>
      Claim,
      /// <summary>
      /// Addition action
      /// </summary>
      AdditionAction,

      //TODO add comment for starting state
      Starting
   }

   /// <summary>
   /// Типы зданий в игре
   /// </summary>
   public enum Buildings
   {
      Church, DrawWell, Fair, Government, Hotel, Shop, House, SmallTotem, Totem, WorkShop
   }

   /// <summary>
   /// Цвета игроков
   /// </summary>
   public enum ColorPlayer
   {
      Red = 0, Green = 1, Blue = 2, Yellow = 3
   }

   /// <summary>
   /// Карты голоса
   /// </summary>
   enum ColorVotes
   {
      Green, Red, Blue
   }
}
