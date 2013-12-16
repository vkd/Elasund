using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Elasund.Core.Tiles
{
    public class Claim
    {
        public int Value { get; private set; }
        public ColorPlayer ColorPlayer { get; private set; }

        public Claim(int value, ColorPlayer color)
        {
            Value = value;
            ColorPlayer = color;
        }
    }
}
