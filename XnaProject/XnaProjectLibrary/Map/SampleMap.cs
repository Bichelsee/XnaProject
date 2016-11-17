using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace XnaProjectLibrary
{
    /// <summary>
    /// This map is usead as an example.
    /// </summary>
    public class SampleMap
    {
        #region Variables

        Vector2 position;
        Texture2D texture;

        #endregion

        #region Constructors

        public SampleMap()
        {
            position = new Vector2(0,0);
        }

        #endregion

        #region Public Methods

        public void LoadContent(ContentManager Content) {
            texture = Content.Load<Texture2D>("Samples/SampleMap4x4");
        }

        public void Update()
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(texture, position, Color.White);
            spriteBatch.End();
        }

        #endregion
    }
}
