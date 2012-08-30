using Microsoft.Xna.Framework;

namespace Elasund {
   /// <summary>
   /// Игрок
   /// </summary>
   public class Player {

      /// <summary>
      /// Color of player
      /// </summary>
      public ColorPlayer Color
      {
         get;
         set;
      }

      /// <summary>
      /// Mills of player
      /// </summary>
      public int Mill
      {
         get;
         set;
      }

      /// <summary>
      /// Winner cubes
      /// 0 - 10 points
      /// </summary>
      public int Score
      {
         get;
         set;
      }

      /// <summary>
      /// Constructor, which set color of player
      /// </summary>
      /// <param name="parColor">Color</param>
      public Player(ColorPlayer parColor)
      {
         Color = parColor;
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
