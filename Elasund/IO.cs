using System;
using Elasund.InputManager;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Elasund
{
    /// <summary>
    /// Graphic user interface
    /// </summary>
    class IO
    {
        private Game Game { get; set; }
        private Core.Elasund Elasund { get; set; }

        private InputManager.InputManager InputManager { get; set; }

        MouseState mouseState;
        MouseState oldMouseState;

        //int _mouseGrip;

        //Building _mouseGripBuilding;
        //Vector2 _mouseMapPosition;
        //Vector2 _mouseGripPosition;
        Vector2 mouseVector;

        bool showDebugInfo = true;

        public IO(Game game, Core.Elasund elasund)
        {
            Game = game;
            Elasund = elasund;

            InputManager = new InputManager.InputManager();
            ConfigureInputManager();
        }

        private void ConfigureInputManager()
        {
            InputManager.AddAction(InputAction.Exit, Game.Exit);
            InputManager.AddAction(InputAction.ChangeFullscreen, Game.ChangeFullScreen);
            InputManager.AddAction(InputAction.DebugInfo, delegate()
            {
                showDebugInfo = !showDebugInfo;
            });

            Action<InputAction, ColorPlayer, int> ama = delegate(InputAction inputAction, ColorPlayer color, int i)
            {
                InputManager.AddAction(inputAction, delegate()
                {
                    Elasund.Players.Find(p => p.Color == color).Mill += i;
                });
            };
            ama(InputAction.IncRed, ColorPlayer.Red, +1);
            ama(InputAction.IncBlue, ColorPlayer.Blue, +1);
            ama(InputAction.IncGreen, ColorPlayer.Green, +1);
            ama(InputAction.IncYellow, ColorPlayer.Yellow, +1);
            ama(InputAction.DecRed, ColorPlayer.Red, -1);
            ama(InputAction.DecBlue, ColorPlayer.Blue, -1);
            ama(InputAction.DecGreen, ColorPlayer.Green, -1);
            ama(InputAction.DecYellow, ColorPlayer.Yellow, -1);

        }

        /// <summary>
        /// Обновление состояний устройств ввода
        /// </summary>
        /// <param name="gameTime">Системная переменная игрового времени</param>
        public void Update(GameTime gameTime)
        {
            InputManager.Update(gameTime);
            //KeyboardUpdate(gameTime);
            MouseUpdate(gameTime);
        }

        /// <summary>
        /// Реагирование на клавиатуру
        /// </summary>
        /// <param name="gameTime">Системная переменная игрового времени</param>
        private void KeyboardUpdate(GameTime gameTime)
        {

            //         //else if (keyboardState.IsKeyDown(Keys.W) && oldKeyboardState.IsKeyUp(Keys.W))
            //         //{
            //         //    int index = (map.reserves[(int)Buildings.Church].Count());
            //         //    map.buildings.Add(map.reserves[(int)Buildings.Church][index - 1].Build(map.GetX(index - 7), map.GetY(1), Color.Green));
            //         //    map.reserves[(int)Buildings.Church].RemoveAt(index - 1);
            //         //}
            //         //else if (keyboardState.IsKeyDown(Keys.S) && oldKeyboardState.IsKeyUp(Keys.S))
            //         //{
            //         //    map.Players[0].Mill = -1;
            //         //}
            //         //else if (keyboardState.IsKeyDown(Keys.E) && oldKeyboardState.IsKeyUp(Keys.E))
            //         //{
            //         //    map.Players[1].Mill = 1;
            //         //}
            //         //else if (keyboardState.IsKeyDown(Keys.D) && oldKeyboardState.IsKeyUp(Keys.D))
            //         //{
            //         //    map.Players[1].Mill = -1;
            //         //}

        }

        /// <summary>
        /// Реагирование на мышь
        /// </summary>
        /// <param name="gameTime">Системная переменная игрового времени</param>
        private void MouseUpdate(GameTime gameTime)
        {
            mouseState = Mouse.GetState();
            mouseVector.X = mouseState.X;
            mouseVector.Y = mouseState.Y;

            //         if (mouseState.LeftButton == ButtonState.Pressed)
            //         {
            //            switch (gameAction)
            //            {
            //               case GameAction.Income:
            //                  break;
            //               case GameAction.Building:
            //                  if (oldMouseState.LeftButton == ButtonState.Released)
            //                  {
            //                     if (_mouseGrip == 1)
            //                     {
            //                        if (map.GetX(0) - 1 < _mouseMapPosition.X && map.GetX(1 + 2 * map.QuantityPlayers) > _mouseMapPosition.X + buildingsTexture[(int)_mouseGripBuilding.BuildingType][0].Width &&
            //                           map.GetY(0) - 1 < _mouseMapPosition.Y && map.GetY(10) > _mouseMapPosition.Y + buildingsTexture[(int)_mouseGripBuilding.BuildingType][0].Height)
            //                        {
            //                           #region BuildBuilding
            //                              for (int k = 0; k < map.reserves[(int)_mouseGripBuilding.BuildingType].Count; k++)
            //                              {
            //                                 Building temp = map.reserves[(int)_mouseGripBuilding.BuildingType][k];
            //                                 if (_mouseGripBuilding.Equals(temp))
            //                                 {
            //                                    temp.Build((int)_mouseMapPosition.X,(int) _mouseMapPosition.Y, map.CurrentPlayer.Color);
            //                                    map.buildings.Add(temp);
            //                                    map.reserves[(int)_mouseGripBuilding.BuildingType].RemoveAt(k);

            //                                 }
            //                              }
            //                              //for (int k = 0; k < map.CurrentPlayer.building.Count; k++)
            //                              //{
            //                              //    Building temp = map.CurrentPlayer.building[k];
            //                              //    if (_mouseGripBuilding.Equals(temp))
            //                              //    {
            //                              //        temp.Build((int)_mouseMapPosition.X, (int)_mouseMapPosition.Y, map.CurrentPlayer.Color);
            //                              //        map.buildings.Add(temp);
            //                              //        map.CurrentPlayer.building.RemoveAt(k);
            //                              //    }
            //                              //}					
            //                           #endregion
            //                           CreateTableOfBuildings();
            //                        }
            //                        _mouseGrip = 0;
            //                     }
            //                     else
            //                     {
            //                        foreach (Building elBuilding in _tempBuildings)
            //                        {
            //                           if (elBuilding.Rect.Intersects(new Rectangle((int)mouseVector.X, (int)mouseVector.Y, 1, 1)))
            //                           {
            //                              _mouseGripPosition = new Vector2((int)mouseVector.X - elBuilding.Rect.Left, (int)mouseVector.Y - elBuilding.Rect.Top);
            //                              _mouseGripBuilding = elBuilding;
            //                              _mouseGrip = 1;
            //                           }
            //                        }
            //                     }
            //                  }
            //                  else
            //                  {

            //                  }
            //                  break;
            //               case GameAction.Claim:
            //                  break;
            //               case GameAction.AdditionAction:
            //                  break;
            //            }
            //         }

            oldMouseState = mouseState;
        }

        /// <summary>
        /// Draw cursor
        /// </summary>
        /// <param name="spriteBatch">SpriteBatch</param>
        public void Draw(SpriteBatch spriteBatch)
        {
            //поле
            spriteBatch.Draw(ContentPack.MapTexture, new Vector2(0, 0), Color.White);

            //уголки
            spriteBatch.Draw(ContentPack.TopCornerTexture, new Vector2(GetX(2 * Elasund.Players.Count), GetY(-1)), Color.White);
            spriteBatch.Draw(ContentPack.BottomCornerTexture, new Vector2(GetX(2 * Elasund.Players.Count), GetY(9)), Color.White);

            //очки
            DrawPoints(spriteBatch);

            //церковь
            //for (int i = 0; i < buildingsReserve[(int)Buildings.Church].Count; i++)
            //    spriteBatch.Draw(ContentPack.BacksideChurchTexture, new Vector2(259 + 2 * i, 23 - 2 * i), Color.White);

            ////кораблик
            //spriteBatch.Draw(shipTexture, new Vector2(GetX(-1) - 16, GetY(_shipIndex) + 3), _shipIsRed ? Color.Red : Color.White);


            if (showDebugInfo)
                DrawDebugInfo(spriteBatch);
        }

        public int GetX(int i)
        {
            return 153 + (int)(51.3f * i);
        }

        public int GetY(int i)
        {
            return 185 + 51 * i;
        }

        private void DrawPoints(SpriteBatch spriteBatch)
        {
            for (int i = 0; i < Elasund.Players.Count; ++i)
            {
                int mills = Elasund.Players[i].Mill;

                int dy = 0;
                if (mills > 3)
                    dy -= 44;
                if (mills > 5)
                    dy -= 20;
                if (mills > 11)
                    mills = 11;

                spriteBatch.Draw(ContentPack.PointTexture, new Vector2(28, 743 - 52 * mills - i * 10 + dy), GetColor(Elasund.Players[i].Color));
            }
        }

        public static Color GetColor(ColorPlayer parColor)
        {
            switch (parColor)
            {
                case ColorPlayer.Blue:
                    return Color.Blue;
                case ColorPlayer.Green:
                    return Color.Green;
                case ColorPlayer.Red:
                    return Color.Red;
                case ColorPlayer.Yellow:
                    return Color.Yellow;
            }
            return Color.White;
        }

        private void DrawDebugInfo(SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(ContentPack.MainFont, 
                "Debug info:", 
                new Vector2(Constants.BOARD_WIDTH + 20, 20), 
                Color.White);

            spriteBatch.DrawString(ContentPack.MainFont,
                "Current player: " + Elasund.CurrentPlayer.Color.ToString(),
                new Vector2(Constants.BOARD_WIDTH + 20, 40),
                GetColor(Elasund.CurrentPlayer.Color));

            for (int i = 0; i < 9; ++i)
            {
                spriteBatch.DrawString(ContentPack.MainFont,
                    i.ToString(),
                    new Vector2(GetX(i), GetY(0)),
                    Color.White);
            }
            spriteBatch.DrawString(ContentPack.MainFont,
                "x", 
                new Vector2(GetX(9), GetY(0)), 
                Color.WhiteSmoke);

            for (int i = 0; i < 10; ++i)
            {
                spriteBatch.DrawString(ContentPack.MainFont,
                    i.ToString(), 
                    new Vector2(GetX(0), GetY(i)), 
                    Color.White);
            }
            spriteBatch.DrawString(ContentPack.MainFont,
                "y",
                new Vector2(GetX(0), GetY(10)), 
                Color.WhiteSmoke);

        }
    }
}
