using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace Elasund.InputManager
{
    public class InputManager
    {
        KeyboardManager _keyboard = new KeyboardManager();

        private Dictionary<InputAction, Action> _actions = new Dictionary<InputAction, Action>();

        public InputManager()
        {

        }

        public void AddAction(InputAction inputAction, Action action)
        {
            _actions.Add(inputAction, action);
        }

        public void Update(GameTime gameTime)
        {
            List<InputAction> keyboardInputActions = _keyboard.Update(gameTime);

            foreach (var inputAction in keyboardInputActions)
            {
                Action action = null;
                if (_actions.TryGetValue(inputAction, out action))
                    action();
            }
        }
    }
}
