using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace XnaProjectLibrary.Map.Chunks.Tiles
{
    public class Tile
    {
        int backgroundID;
        int spriteID;

        public int BackgroundID
        {
            get
            {
                return backgroundID;
            }

            set
            {
                backgroundID = value;
            }
        }

        public int SpriteID
        {
            get
            {
                return spriteID;
            }

            set
            {
                spriteID = value;
            }
        }

        public Tile(int background, int sprite)
        {
            backgroundID = background;
            spriteID = sprite;
        }

    }
}
