

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace BuccaneerBreaker.Services
{
    
    public interface ISceneManager
    {
        public void Load(Type sceneType);
    }

    public sealed class SceneManager : ISceneManager
    {
        private Scene _currentScene;
        private Dictionary<Type,Scene> _scenes = new Dictionary<Type,Scene>();

        public SceneManager()
        {
            ServicesLocator.Register<ISceneManager>(this);
        }

        public void Register(Scene scene)
        {
            Debug.WriteLine(scene.GetType());
            _scenes.Add(scene.GetType(), scene);
        }

        public void Load(Type sceneType)
        {
            if (_currentScene != null)
            {
                _currentScene.Unload();
                _currentScene = null;

            }
            _currentScene = _scenes[sceneType];
            _currentScene.Load();
        }

        public void Update(GameTime gameTime)
        {
            if (_currentScene != null) _currentScene.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (_currentScene != null) _currentScene.Draw(spriteBatch);
        }

    }
}
