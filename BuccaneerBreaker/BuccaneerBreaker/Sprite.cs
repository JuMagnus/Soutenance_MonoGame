

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace BuccaneerBreaker
{
    public class Sprite
    {
        public Vector2 position;
        private Texture2D _texture;

        public Sprite(Vector2 position, Texture2D texture)
        {
            this.position = position;
            this._texture = texture;
        }

        public void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(_texture, position, Color.White);
        }

        public Rectangle Bounds => new Rectangle((int)position.X, (int)position.Y, _texture.Width, _texture.Height);

    }
}
