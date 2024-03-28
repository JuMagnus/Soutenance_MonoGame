using Microsoft.Xna.Framework.Input;

namespace BuccaneerBreaker
{
    public interface IInputs
    {
        bool IsJustPressed(Keys key);
        bool IsKeyPressed(Keys key);

    }
    
    public sealed class Inputs : IInputs
    {
        private KeyboardState _oldKeyboardState;

        public Inputs()
        {
            ServicesLocator.Register<IInputs>(this);
        }

        public void UpdateKeyboardState()
        {
            _oldKeyboardState = Keyboard.GetState();
        }

        public bool IsJustPressed(Keys key)
        {
            return Keyboard.GetState().IsKeyDown(key) && _oldKeyboardState.IsKeyUp(key);
        }


        public bool IsKeyPressed(Keys key)
        {
            return Keyboard.GetState().IsKeyDown(key);
        }
    }
}
