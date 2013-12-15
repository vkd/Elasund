using Microsoft.Xna.Framework;

namespace Elasund.Core
{
    /// <summary>
    /// Игрок
    /// </summary>
    public class Player
    {
        public ColorPlayer Color { get; set; }

        public int Mill { get; set; }
        public int Score { get; set; }

        ///// <summary>
        ///// Top number of wall
        ///// </summary>
        //public int WallOfSity
        //{
        //    get;
        //    set;
        //}

        public Player(ColorPlayer color)
        {
            Color = color;
            Mill = 0;
            Score = 10;
        }

        //      private int _mill;
        //      /// <summary>
        //      /// Мельницы игрока
        //      /// </summary>
        //      public int Mill
        //      {
        //         get { return _mill; }
        //         set
        //         {
        //            int old = _mill;
        //            _mill += value;

        //            if (old < _mill)
        //            {
        //               for (int i = old; i <= _mill; i++)
        //               {
        //                  switch (i)
        //                  {
        //                     case 3:
        //                     case 5:
        //                     case 7:
        //                     case 9:
        //                     case 11:
        //                        _score++;
        //                        break;
        //                  }
        //               }
        //            }
        //            else if (old > _mill)
        //            {
        //               for (int i = old; i >= _mill; i--)
        //               {
        //                  switch (i)
        //                  {
        //                     case 2:
        //                     case 4:
        //                     case 6:
        //                     case 8:
        //                     case 10:
        //                        _score--;
        //                        break;
        //                  }
        //               }
        //            }
        //         }
        //      }


    }
}
