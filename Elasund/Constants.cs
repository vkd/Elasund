namespace Elasund
{
    public static class Constants
    {
        public static string NAME_GAME
        {
            get { return "Elasund"; }
        }

        public const bool FORM_LOAD_ELASUND = false;

        public const int QUANTITY_BUILDINGS = 10;
        public const int MAX_PLAYERS = 4;

        /// <summary>
        /// Cost claims -> 0, 1, 2, ..., max
        /// </summary>
        public const int MAX_COST_CLAIM = 4;

        public const int BOARD_WIDTH = 673;
    }
}
