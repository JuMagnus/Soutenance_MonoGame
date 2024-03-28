using BuccaneerBreaker.Services;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Diagnostics;

namespace BuccaneerBreaker
{
    public class SceneGame : Scene
    {

        private Sprite _sprite;
        public override void Load()
        {
            var assets = ServicesLocator.Get<IAssets>();

            _sprite = new Sprite(Vector2.Zero, assets.Get<Texture2D>("TexDawn"));
            

            base.Load();
        }
        public override void Update(GameTime gameTime)
        {
            var inputs = ServicesLocator.Get<IInputs>();
            var sceneManager = ServicesLocator.Get<ISceneManager>();


            base.Update(gameTime);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            _sprite.Draw(spriteBatch);

            DrawUtils.Rectangle(new Vector2(100, 100), 100, 200, Color.White, 1);
        }

    }
}
