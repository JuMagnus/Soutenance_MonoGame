using BuccaneerBreaker.Services;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Text;

namespace BuccaneerBreaker
{
    public class Main : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private Inputs _inputs;
        private SceneManager _sceneManager;
        private Screen _screen;
        private Assets _assets;




        public Main()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            _graphics.PreferredBackBufferWidth = 1200;
            _graphics.PreferredBackBufferHeight = 1720;

        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            _inputs = new Inputs();
            _sceneManager = new SceneManager();
            _screen = new Screen(_graphics);


            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            ServicesLocator.Register<SpriteBatch>(_spriteBatch);

            _assets = new Assets(Content);

            _assets.Load<Texture2D>("TexDawn");
            _assets.Load<Texture2D>("TexKraken");
            _assets.Load<Texture2D>("TexMonsters");
            _assets.Load<Texture2D>("TexSkullIsland");
            _assets.Load<Texture2D>("TexSunset");
            _assets.Load<Texture2D>("TexTwilight");
            _assets.Load<Texture2D>("TexPaddle");

            _sceneManager.Register(new SceneMenu());
            _sceneManager.Register(new SceneGame());



            _sceneManager.Load(typeof(SceneGame));

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();


            // TODO: Add your update logic here

            _sceneManager.Update(gameTime);

            _inputs.UpdateKeyboardState();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            _spriteBatch.Begin();
            _sceneManager.Draw(_spriteBatch);
            _spriteBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
