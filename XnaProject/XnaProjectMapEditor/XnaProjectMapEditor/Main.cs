using System;
using System.Collections.Generic;
using System.Linq;
using XnaProjectLibrary;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace XnaProjectMapEditor
{
    /// <summary>
    /// This is the main class.
    /// </summary>
    public class Main : Microsoft.Xna.Framework.Game
    {
        #region Variables

        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        SpriteFont spriteFont;
        Cursor cursor;
        SampleMap map;
        Map testRealMap;

        #endregion

        #region Constructors

        /// <summary>
        /// Creates an instance of the main game. 
        /// </summary>
        public Main()
        {
            // Setting important stuff like graphics adapters.
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// This method will  be called before the game loop starts. 
        /// </summary>
        protected override void Initialize()
        {
            InitializeScreenProperties();
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            cursor = new Cursor();
            map = new SampleMap();
            //testRealMap = new Map("Maps/Map01", Content);

            spriteBatch = new SpriteBatch(GraphicsDevice);
            spriteFont = Content.Load<SpriteFont>("Fonts/Standard");
      
            cursor.LoadContent(Content);
            map.LoadContent(Content);
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {

        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            HandleMouse();
            HandleKeyboard();

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            ClearScreen();

            //testRealMap.Draw(spriteBatch);
            map.Draw(spriteBatch);

            cursor.Draw(spriteBatch);
            cursor.DrawInformations(spriteBatch, spriteFont);


            base.Draw(gameTime);
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Clears the screen to a blueish color.
        /// </summary>
        private void ClearScreen()
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
        }

        /// <summary>
        /// Initializes the screen properties.
        /// </summary>
        private void InitializeScreenProperties()
        {
            graphics.PreferredBackBufferHeight = 576;
            graphics.PreferredBackBufferWidth = 704;
            graphics.IsFullScreen = false;
            graphics.ApplyChanges();
        }

        /// <summary>
        /// Handles the mouse.
        /// </summary>
        private void HandleMouse()
        {
            cursor.Update(Mouse.GetState());
        }

        /// <summary>
        /// Handles all the keyboard inputs.
        /// </summary>
        private void HandleKeyboard()
        {
            // Exit?
            if (Keyboard.GetState().IsKeyDown(Keys.Escape)) this.Exit();

            // Cursorchanges?
            if (Keyboard.GetState().IsKeyDown(Keys.NumPad0))
            {
                cursor.SetCursorType(CursorType.Arrow, Content);
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.NumPad1))
            {
                cursor.SetCursorType(CursorType.Add, Content);
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.NumPad2))
            {
                cursor.SetCursorType(CursorType.Remove, Content);
            }
        }

        #endregion
    }
}
