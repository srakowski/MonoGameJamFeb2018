// MIT License - Copyright (C) Shawn Rakowski
// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of this source code package.

using Coldsteel;
using Microsoft.Xna.Framework;

namespace MonoGameJamFeb2018
{
    public class UntitledGame : Game
    {
        private readonly GraphicsDeviceManager _graphics;
        private readonly Engine _engine;

        public UntitledGame()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            _engine = new Engine(this,
                new SceneCatalog()
                    .AddScene("MainMenu", Scenes.MainMenuScene.Create)
            );

            Components.Add(_engine);
        }
    }
}
