using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Elasund
{
   /// <summary>
   /// Graphic user interface
   /// </summary>
	class IO
	{
		Game game;

		KeyboardState keyboardState;
		KeyboardState oldKeyboardState;

		MouseState mouseState;
		MouseState oldMouseState;

		////??--
		//int _mouseGrip;

		//Building _mouseGripBuilding;
		//Vector2 _mouseMapPosition;
		//Vector2 _mouseGripPosition;
		Vector2 mouseVector;

      bool showDebugInfo = false;

		public IO(Game parGame)
		{
			game = parGame;
		}

		/// <summary>
		/// Обновление состояний устройств ввода
		/// </summary>
		/// <param name="gameTime">Системная переменная игрового времени</param>
		public void Update(GameTime gameTime)
		{
			KeyboardUpdate(gameTime);
			MouseUpdate(gameTime);
		}

		/// <summary>
		/// Реагирование на клавиатуру
		/// </summary>
		/// <param name="gameTime">Системная переменная игрового времени</param>
		private void KeyboardUpdate(GameTime gameTime)
		{
			keyboardState = Keyboard.GetState();

         if (keyboardState.IsKeyDown(Keys.Escape))
            game.Exit();
         else if (keyboardState.IsKeyDown(Keys.F5) && oldKeyboardState.IsKeyUp(Keys.F5))
            game.ChangeFullScreen();
         else if (keyboardState.IsKeyDown(Keys.F12) && oldKeyboardState.IsKeyUp(Keys.F12))
            showDebugInfo = !showDebugInfo;
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

			oldKeyboardState = keyboardState;
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

         

         //Draw mouse cursor
         spriteBatch.Draw(ContentPack.CursorTexture, mouseVector, Color.White);

         //Draw debug info
         if (showDebugInfo)
            DrawDebugInfo(spriteBatch);
		}

      /// <summary>
      /// Draw debug info
      /// </summary>
      /// <param name="spriteBatch">SpriteBatch</param>
      private void DrawDebugInfo(SpriteBatch spriteBatch)
      {
         spriteBatch.DrawString(ContentPack.MainFont, "Debug info:", new Vector2(20, 20), Color.White);
      }
	}
}
