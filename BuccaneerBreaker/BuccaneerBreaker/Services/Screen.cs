
using Microsoft.Xna.Framework;

namespace BuccaneerBreaker
{
    public interface IScreen
    {

    }
    
    internal sealed class Screen : IScreen
    {
        private GraphicsDeviceManager _graphicsDeviceManager;

        public Screen(GraphicsDeviceManager graphicsDeviceManager)
        {
            _graphicsDeviceManager = graphicsDeviceManager;
            ServicesLocator.Register<IScreen>(this);
        }
        public float Width => _graphicsDeviceManager.PreferredBackBufferWidth;
        
        public float Height => _graphicsDeviceManager.PreferredBackBufferHeight;
        

        public Vector2 Center => new Vector2(Width * .5f, Height * .5f);
        
    }
}
