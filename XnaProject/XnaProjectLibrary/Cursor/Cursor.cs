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
    /// <summary>
    /// Cursor-Class with properties and methods.
    /// </summary>
    public class Cursor
    {
        #region Variables 

        // Position of the cursortip
        Vector2 position = new Vector2(30f, 30f);

        // Cursor-Image
        Texture2D image;

        // Cursor-Type
        CursorType type = CursorType.Arrow;

        #endregion

        #region Constructors

        /// <summary>
        /// Creates an instance of the cursor class.
        /// </summary>
        public Cursor()
        {
            
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Loads the content of the cursor.
        /// </summary>
        /// <param name="Content"></param>
        public void LoadContent(ContentManager Content)
        {
            // Set image to standard cursor.
            image = Content.Load<Texture2D>("Cursors/CursorArrow");
        }

        /// <summary>
        /// Draws the cursor onto the screen
        /// </summary>
        /// <param name="spriteBatch"></param>
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(image, position, Color.White);
            spriteBatch.End();
        }

        /// <summary>
        /// Updates the cursor and it's properties
        /// </summary>
        /// <param name="state"></param>
        public void Update(MouseState state)
        {
            position.X = state.X;
            position.Y = state.Y;
        }

        /// <summary>
        /// Sets the new cursor type.
        /// </summary>
        /// <param name="cursorType"></param>
        /// <param name="Content"></param>
        public void SetCursorType(CursorType cursorType, ContentManager Content)
        {
            type = cursorType;
            if (cursorType == CursorType.Arrow)
            {
                image = Content.Load<Texture2D>("Cursors/CursorArrow");
            }
            else if (cursorType ==CursorType.Add)
            {
                image = Content.Load<Texture2D>("Cursors/CursorAdd");
            }
            else if (cursorType == CursorType.Remove)
            {
                image = Content.Load<Texture2D>("Cursors/CursorRemove");
            }
        }

        #endregion
    }
}