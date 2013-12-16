using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Elasund.InputManager
{
    class KeyboardManager
    {
        KeyboardState keyboardState;
        KeyboardState oldKeyboardState;

        List<Tuple<Keys, InputAction>> _keyMap = new List<Tuple<Keys, InputAction>>();

        public KeyboardManager()
        {
            Initialize();
        }

        private void Initialize()
        {
            Action<Keys, InputAction> addKey = delegate(Keys key, InputAction inputAction)
            {
                _keyMap.Add(new Tuple<Keys, InputAction>(key, inputAction));
            };

            addKey(Keys.Escape, InputAction.Exit);
            addKey(Keys.F5, InputAction.ChangeFullscreen);
            addKey(Keys.F12, InputAction.DebugInfo);

            addKey(Keys.D1, InputAction.IncRed);
            addKey(Keys.D2, InputAction.IncBlue);
            addKey(Keys.D3, InputAction.IncGreen);
            addKey(Keys.D4, InputAction.IncYellow);
            addKey(Keys.Q, InputAction.DecRed);
            addKey(Keys.W, InputAction.DecBlue);
            addKey(Keys.E, InputAction.DecGreen);
            addKey(Keys.R, InputAction.DecYellow);
        }

        public List<InputAction> Update(GameTime gameTime)
        {
            List<InputAction> resultActions = new List<InputAction>();
            keyboardState = Keyboard.GetState();

            foreach (var keymap in _keyMap)
            {
                if (Release(keymap.Item1))
                    resultActions.Add(keymap.Item2);
            }

            oldKeyboardState = keyboardState;

            return resultActions;
        }

        private bool Release(Keys key)
        {
            return oldKeyboardState.IsKeyDown(key) && keyboardState.IsKeyUp(key);
        }
    }
}
