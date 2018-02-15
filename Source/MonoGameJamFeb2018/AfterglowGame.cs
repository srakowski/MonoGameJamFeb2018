// MIT License - Copyright (C) Shawn Rakowski
// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of this source code package.

using Coldsteel;
using Microsoft.Xna.Framework;
using MonoGameJamFeb2018.Scenes;

namespace MonoGameJamFeb2018
{
    public class AfterglowGame : Game
    {
        private readonly GraphicsDeviceManager _graphics;
        private readonly Engine _engine;

        public AfterglowGame()
        {
            _graphics = new GraphicsDeviceManager(this);
            _graphics.PreferredBackBufferWidth = 1920;
            _graphics.PreferredBackBufferHeight = 1080;

            Content.RootDirectory = "Content";

            _engine = new Engine(this,
                new SceneCatalog()
                    .AddScene(nameof(TitleScene), TitleScene.Create)
                    .AddScene(nameof(SetupScene), SetupScene.Create)
                    .AddScene(nameof(MissionScene), MissionScene.Create)
            );

            Components.Add(_engine);
        }

        protected override void Initialize()
        {
            base.Initialize();
            _engine.Start(nameof(TitleScene));
            //_engine.Start(nameof(SetupScene), Gameplay.GameState.NewGame());
        }
    }
}
