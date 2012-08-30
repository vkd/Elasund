namespace Elasund
{
   /// <summary>
   /// Game constants
   /// </summary>
   public static class Constants
   {
      /// <summary>
      /// Get name of game
      /// </summary>
      public static string NAME_GAME
      {
         get { return "Elasund"; }
      }

      /// <summary>
      /// Enable show form start settings
      /// </summary>
      public const bool FORM_LOAD_ELASUND = false;

      /// <summary>
      /// Quantity type of buildings on game
      /// </summary>
      public const int QUANTITY_BUILDINGS = 10;

      /// <summary>
      /// Max players on game
      /// </summary>
      public const int MAX_PLAYERS = 4;

      /// <summary>
      /// Cost claims -> 0, 1, 2, ..., max
      /// </summary>
      public const int MAX_COST_CLAIM = 4;

      //TODO wtf?!
      //const int __BOARD_WIDTH = 673;
   }
}
