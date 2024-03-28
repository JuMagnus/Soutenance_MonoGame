using Microsoft.Xna.Framework;
using System.Diagnostics;
using Microsoft.Xna.Framework.Input;
using BuccaneerBreaker.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;
using Microsoft.Xna.Framework.Graphics;

namespace BuccaneerBreaker
{
    public class SceneMenu : Scene
    {
        private Sprite _sprite;
        public override void Load()
        {
            Debug.WriteLine("bonjour SceneMenu");

            var assets = ServicesLocator.Get<IAssets>();
            _sprite = new Sprite(Vector2.Zero, assets.Get<Texture2D>("TexKraken"));

            base.Load();
        }
        public override void Update(GameTime gameTime)
        {
            
            base.Update(gameTime);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            _sprite.Draw(spriteBatch);
        }
    }
}
