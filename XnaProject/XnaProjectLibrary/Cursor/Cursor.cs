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

namespace XnaProjectLibrary
{
    public class Cursor
    {
        Vector2 position = new Vector2(30f, 30f);
        Texture2D image;

        public Cursor()
        {
            
        }

        public void LoadContent(ContentManager Content)
        {
            image = Content.Load<Texture2D>("Cursors/CursorArrow");
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(image, position, Color.White);
            spriteBatch.End();
        }

        public void Update(MouseState state)
        {
            position.X = state.X;
            position.Y = state.Y;
        }
    }
}
