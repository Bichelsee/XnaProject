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
    /// This is the main type for your game
    /// </summary>
    public class Main : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        SpriteFont spriteFont;
        Cursor cursor;

        public Main()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
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
            spriteBatch = new SpriteBatch(GraphicsDevice);
            spriteFont = Content.Load<SpriteFont>("Fonts/Standard");
      
            cursor.LoadContent(Content);     
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
            cursor.Draw(spriteBatch);
            cursor.DrawInformations(spriteBatch, spriteFont);


            base.Draw(gameTime);
        }

        private void ClearScreen()
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
        }

        private void InitializeScreenProperties()
        {
            graphics.PreferredBackBufferHeight = 600;
            graphics.PreferredBackBufferWidth = 800;
            graphics.IsFullScreen = false;
            graphics.ApplyChanges();
        }

        private void HandleMouse()
        {
            cursor.Update(Mouse.GetState());
        }

        private void HandleKeyboard()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Escape)) this.Exit();

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
    }
}
