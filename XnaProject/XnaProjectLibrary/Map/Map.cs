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

        #endregion

        #region Constructors

        /// <summary>
        /// Creates an instance of a map.
        /// </summary>
        /// <param name="path">Path to map-file.</param>
        public Map(string path)
        {
            Initialize(path);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Initializes the map.
        /// </summary>
        /// <param name="path">Path to map-folder.</param>
        private void Initialize(string path)
        {
            staticMap = new StaticMap();
            dynamicMap = new DynamicMap();
            spriteMap = new SpriteMap();
        }

        #endregion
    }
}