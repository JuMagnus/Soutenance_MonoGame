

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace BuccaneerBreaker
{
    
    public interface IAssets
    {
        public T Get<T>(string name);
    }
    
    public class Assets : IAssets
    {
        private Dictionary<string, object> _assets = new Dictionary<string, object>();
        private ContentManager _contentManager;


        public Assets(ContentManager cm)
        {
            _contentManager = cm;
            ServicesLocator.Register<IAssets>(this);

            Texture2D texture = new Texture2D(ServicesLocator.Get<SpriteBatch>().GraphicsDevice, 1, 1, false, SurfaceFormat.Color);
            texture.SetData(new[] { Color.White } );
            _assets["OnePixel"] = texture;
        }

        public void Load<T>(string name)
        {
            T asset = _contentManager.Load<T>(name);
            _assets[name] = asset;

        }

        public T Get<T>(string name)
        {
            return (T)_assets[name];
        }
    }
}
