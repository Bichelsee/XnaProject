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
    /// Represents a playable map.
    /// </summary>
    public class Map
    {
        #region Variables

        private StaticMap staticMap;
        private DynamicMap dynamicMap;
        private SpriteMap spriteMap;

        private int id;
        private string path;
        private string name;
        private Vector2 size;
        private Texture2D actualImage;
        private Vector2 position;
        private Vector2 positionInFields;

        private ContentManager Content;

        #endregion

        #region Properties

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public Vector2 Size
        {
            get
            {
                return size;
            }

            set
            {
                size = value;
            }
        }
        public string Path
        {
            get
            {
                return path;
            }

            set
            {
                path = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public Vector2 Position
        {
            get
            {
                return position;
            }

            set
            {
                position = value;
                positionInFields.X = value.X / 64;
                positionInFields.Y = value.Y / 64;
            }
        }

        public Vector2 PositionInFields
        {
            get
            {
                return positionInFields;
            }

            set
            {
                positionInFields = value;
                position.X = value.X * 64;
                position.Y = value.Y * 64;
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Creates an instance of a map.
        /// </summary>
        /// <param name="path">Path to map-file.</param>
        public Map(string path, ContentManager content)
        {
            Initialize(path, content);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Initializes the map. 
        /// </summary>
        /// <param name="path">Path to map-folder.</param>
        private void Initialize(string path, ContentManager content)
        {
            Content = content;
            position = new Vector2(0, 0);
            positionInFields = new Vector2(0, 0);
            actualImage = Content.Load<Texture2D>(path + "/Chunks/Chunk01/Chunk01_image");

            staticMap = new StaticMap();
            dynamicMap = new DynamicMap();
            spriteMap = new SpriteMap();
        }

        /// <summary>
        /// Draws the map onto the screen.
        /// </summary>
        /// <param name="spriteBatch"></param>
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();

            spriteBatch.Draw(actualImage, position, Color.White);

            spriteBatch.End();
        }

        #endregion
    }
}