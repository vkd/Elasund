﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Windows.Forms;
using System;
using System.Drawing;

namespace Elasund
{
    public class Game : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        IO io;

        public Game()
        {
            if (Constants.FORM_LOAD_ELASUND)
            {
                FormLoadGame formLoadGame = new FormLoadGame();
                formLoadGame.ShowDialog();
                if (formLoadGame.DialogResult == System.Windows.Forms.DialogResult.Cancel)
                    this.Exit();
            }
            else
            {
                Settings.SCREEN_WIDTH = 1024;
                Settings.SCREEN_HEIGHT = 768;
                Settings.FULL_SCREEN = false;
            }


            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            graphics.PreferredBackBufferWidth = Settings.SCREEN_WIDTH;
            graphics.PreferredBackBufferHeight = Settings.SCREEN_HEIGHT;

            this.Window.Title = Constants.NAME_GAME;
            if (Settings.FULL_SCREEN)
                graphics.ToggleFullScreen();
        }

        protected override void Initialize()
        {
            ContentPack.Initialize();

            ColorPlayer[] players = 
            {
                ColorPlayer.Green,
                ColorPlayer.Red,
                ColorPlayer.Blue,
                ColorPlayer.Yellow
            };

            io = new IO(this, Core.Elasund.Initialize(players));
            
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            try
            {
                ContentPack.MainFont = Content.Load<SpriteFont>("SpriteFont");

                LoadBuildings();
                LoadClaims();

                ContentPack.CubeTexture = Content.Load<Texture2D>("Textures/Cube");
                ContentPack.PointTexture = Content.Load<Texture2D>("Textures/Point");
                ContentPack.MapTexture = Content.Load<Texture2D>("Textures/Board");
                ContentPack.TopCornerTexture = Content.Load<Texture2D>("Textures/Corner1");
                ContentPack.BottomCornerTexture = Content.Load<Texture2D>("Textures/Corner2");
                ContentPack.BacksideChurchTexture = Content.Load<Texture2D>("Textures/Church0");
                ContentPack.ShipTexture = Content.Load<Texture2D>("Textures/Ship");
            }
            catch (Microsoft.Xna.Framework.Content.ContentLoadException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }

            Bitmap cur = new Bitmap("Cursor.png", true);
            Graphics g = Graphics.FromImage(cur);
            IntPtr ptr = cur.GetHicon();
            Cursor c = new Cursor(ptr);
            Form.FromHandle(this.Window.Handle).Cursor = c;
            this.IsMouseVisible = true;
        }

        private void LoadBuildings()
        {
            for (int i = 0; i < 9; ++i)
            {
                ContentPack.BuildingsTexture[(int)Buildings.Church][i] = Content.Load<Texture2D>("Textures/Buildings/Church" + (i + 1));
            }
            ContentPack.BuildingsTexture[(int)Buildings.DrawWell][0] = Content.Load<Texture2D>("Textures/Buildings/DrawWell");
            ContentPack.BuildingsTexture[(int)Buildings.Fair][0] = Content.Load<Texture2D>("Textures/Buildings/Fair");
            for (int i = 0; i < 3; ++i)
                ContentPack.BuildingsTexture[(int)Buildings.Government][i] = Content.Load<Texture2D>("Textures/Buildings/Government" + (i + 1));
            ContentPack.BuildingsTexture[(int)Buildings.Hotel][0] = Content.Load<Texture2D>("Textures/Buildings/Hotel");
            for (int i = 0; i < 4; ++i)
                ContentPack.BuildingsTexture[(int)Buildings.House][i] = Content.Load<Texture2D>("Textures/Buildings/House" + i);
            ContentPack.BuildingsTexture[(int)Buildings.Shop][0] = Content.Load<Texture2D>("Textures/Buildings/Shop");
            for (int i = 0; i < 4; ++i)
            {
                ContentPack.BuildingsTexture[(int)Buildings.SmallTotem][i] = Content.Load<Texture2D>("Textures/Buildings/SmallTotem" + i);
                ContentPack.BuildingsTexture[(int)Buildings.Totem][i] = Content.Load<Texture2D>("Textures/Buildings/Totem" + i);
                ContentPack.BuildingsTexture[(int)Buildings.WorkShop][i] = Content.Load<Texture2D>("Textures/Buildings/WorkShop" + i);
            }
        }

        private void LoadClaims()
        {
            for (int i = 0; i <= Constants.MAX_COST_CLAIM; ++i)
            {
                ContentPack.ClaimTexture[0, i] = Content.Load<Texture2D>("Textures/Claims/r" + i);
                ContentPack.ClaimTexture[1, i] = Content.Load<Texture2D>("Textures/Claims/g" + i);
                ContentPack.ClaimTexture[2, i] = Content.Load<Texture2D>("Textures/Claims/b" + i);
                ContentPack.ClaimTexture[3, i] = Content.Load<Texture2D>("Textures/Claims/y" + i);
            }
        }

        protected override void UnloadContent()
        {
        }

        protected override void Update(GameTime gameTime)
        {
            io.Update(gameTime);

            base.Update(gameTime);
        }

        //      private void GameUpdate(GameTime gameTime)
        //      {
        //         switch (gameAction)
        //         {
        //            #region GameAction.Income
        //            case GameAction.Income:
        //               sumDice.GetNextResult();
        //               if (sumDice.GetResult() == 7)
        //               {
        //                  map.ShipIsRed = true;
        //                  //TODO add buttons for change
        //                  if (map.ShipIndex >= 8)
        //                  {
        //                     if (map.ShipIndex == 9)
        //                        map.ShipIndex -= 3;
        //                     else
        //                        map.ShipIndex -= 2;
        //                  }
        //                  else
        //                  {
        //                     if (map.ShipIndex == 5)
        //                        map.ShipIndex += 3;
        //                     else
        //                        map.ShipIndex += 2;
        //                  }
        //               }
        //               else
        //               {
        //                  map.ShipIsRed = false;
        //                  if (map.ShipIndex == sumDice.GetResult())
        //                  {
        //                     //TODO change if ==
        //                     if (map.ShipIndex >= 8)
        //                     {
        //                        if (map.ShipIndex == 9)
        //                           map.ShipIndex -= 3;
        //                        else
        //                           map.ShipIndex -= 2;
        //                     }
        //                     else
        //                     {
        //                        if (map.ShipIndex == 5)
        //                           map.ShipIndex += 3;
        //                        else
        //                           map.ShipIndex += 2;
        //                     }
        //                     //map.ShipIndex += sumDice.GetResult() >= 8 ? -2 : 2;
        //                  }
        //                  else
        //                  {
        //                     map.ShipIndex = sumDice.GetResult() >= 8 ? sumDice.GetResult() - 3 : sumDice.GetResult() - 2;
        //                  }
        //               }

        //               if (map.ShipIsRed)
        //               {
        //                  //TODO pirates
        //               }
        //               else
        //                  map.Income();

        //               gameAction = GameAction.Building;
        //               CreateTableOfBuildings();
        //               _quantityBuild = 2;
        //               break;
        //            #endregion

        //            #region GameAction.Building
        //            case GameAction.Building:

        //               if (_quantityBuild == 0)
        //                  gameAction = GameAction.Claim;
        //               break;
        //            #endregion
        //            case GameAction.Claim:
        //               break;
        //            case GameAction.AdditionAction:
        //               break;
        //         }
        //      }





        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Microsoft.Xna.Framework.Color.CornflowerBlue);

            spriteBatch.Begin();

            //Рисуем карту и все объекты на ней
            //map.Draw(spriteBatch);

            //         //for (int i = 0; i < 7; i += 2)
            //         //{
            //         //    //spriteBatch.Draw(governmentTexture, new Vector2(154 + (int)(51.3f * i), 185 + 51 * 4), Color.White);
            //         //    spriteBatch.Draw(cube, new Vector2(154 + (int)(51.3f * i) + 20, 185 + 51 * 4), Color.Blue);
            //         //}
            //         //spriteBatch.Draw(governmentTexture, new Vector2(154 + (int)(51.3f*0) - 68, 187 + 51*i), Color.White); - ship
            //         //spriteBatch.Draw(governmentTexture, new Vector2(154 + (int)(51.3f * i), 185 + 51*4), Color.White); - builds


            //         //spriteBatch.DrawString(spriteFont, "Hello World", new Vector2(100, 100), Color.Yellow);


            //         switch (gameAction)
            //         {
            //            case GameAction.Income:
            //               break;
            //            case GameAction.Building:
            //               foreach (Building elBuilding in _tempBuildings)
            //               {
            //                  //elBuilding.Draw(spriteBatch);
            //                  spriteBatch.Draw(buildingsTexture[(int)elBuilding.BuildingType][0], elBuilding.Rect, Color.White);
            //               }
            //               break;
            //            case GameAction.Claim:
            //               break;
            //            case GameAction.AdditionAction:
            //               break;
            //         }

            //         //Рисуем курсор			
            //         if (_mouseGrip == 1)
            //         {
            //            #region DrawCurcorWithBuilding
            //            _mouseMapPosition.X = (int)(mouseVector.X - _mouseGripPosition.X);
            //            _mouseMapPosition.Y = (int)(mouseVector.Y - _mouseGripPosition.Y);

            //            for (int i = -1; ; i++)
            //            {
            //               if (map.GetX(i) + _mouseGripBuilding.Rect.Width > map.GetX(1 + 2 * map.QuantityPlayers))
            //                  break;
            //               if (map.GetX(i) < _mouseMapPosition.X && map.GetX(i + 1) > _mouseMapPosition.X)
            //               {
            //                  if (_mouseMapPosition.X - map.GetX(i) > map.GetX(i + 1) - _mouseMapPosition.X)
            //                     _mouseMapPosition.X = map.GetX(i + 1);
            //                  else
            //                     _mouseMapPosition.X = map.GetX(i);

            //                  for (int j = -1; j < 10; j++)
            //                  {
            //                     if (map.GetY(j) + _mouseGripBuilding.Rect.Height > map.GetY(10))
            //                        break;
            //                     if (map.GetY(j) < _mouseMapPosition.Y && map.GetY(j + 1) > _mouseMapPosition.Y)
            //                     {
            //                        if (_mouseMapPosition.Y - map.GetY(j) > map.GetY(j + 1) - _mouseMapPosition.Y)
            //                           _mouseMapPosition.Y = map.GetY(j + 1);
            //                        else
            //                           _mouseMapPosition.Y = map.GetY(j);
            //                        break;
            //                     }
            //                  }

            //                  break;
            //               }
            //            }

            //            spriteBatch.Draw(buildingsTexture[(int)_mouseGripBuilding.BuildingType][0], new Vector2(_mouseMapPosition.X, _mouseMapPosition.Y), Color.White);
            //            #endregion
            //         }
            //         //else if (_mouseGrip == 2)
            //         //    spriteBatch.Draw(claimTexture[map.GetNumber(map.CurrentPlayer.Color)][_mouseGridClaim.Number], new Vector2(mouseVector.X - _mouseGripPosition.X, mouseVector.Y - _mouseGripPosition.Y), Color.White);

            io.Draw(spriteBatch);

            spriteBatch.End();

            base.Draw(gameTime);
        }

        public void ChangeFullScreen()
        {
            graphics.ToggleFullScreen();
        }
    }
}
