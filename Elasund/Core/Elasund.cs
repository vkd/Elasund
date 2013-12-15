using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Elasund.Core
{
    public class Elasund
    {
        public List<Player> Players { get; private set; }
        public Player CurrentPlayer { get; private set; }

        private Elasund()
        {

        }

        public static Elasund Initialize(ColorPlayer[] players)
        {
            if (players.Length < 2 || players.Length > Constants.MAX_PLAYERS)
                throw new ArgumentException("Wrong count players");

            Action<ColorPlayer> checkColor = delegate(ColorPlayer color) 
            {
                if (players.Where(p => p == color).Count() > 1)
                    throw new ArgumentException(color.ToString() + "'s players more then one");
            };

            checkColor(ColorPlayer.Blue);
            checkColor(ColorPlayer.Green);
            checkColor(ColorPlayer.Red);
            checkColor(ColorPlayer.Yellow);

            Elasund elasund = new Elasund();

            elasund.Players = new List<Player>();
            for (int i = 0; i < players.Length; ++i)
            {
                elasund.Players.Add(new Player(players[i]));
            }

            elasund.CurrentPlayer = elasund.Players[0];

            return elasund;
        }
    }
}
