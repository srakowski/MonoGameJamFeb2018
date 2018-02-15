// MIT License - Copyright (C) Shawn Rakowski
// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of this source code package.

using Coldsteel;
using Coldsteel.Scripting;
using MonoGameJamFeb2018.Scenes;
using MonoGameJamFeb2018.Gameplay;
using MonoGameJamFeb2018.Scripts;

namespace MonoGameJamFeb2018.Entities
{
    class MainMenu : Entity
    {
        public MainMenu(Entity fader)
        {
            var mm = new MainMenuBehavior(fader);
            AddComponent(mm);
            AddChild(new ListView<string>(new[] { "PLAY", "OPTIONS", "CREDITS" },
                new ListViewConfig<string>
                {
                    Color = GameColors.Black,
                    SelectedColor = GameColors.DarkRed,
                    Font = "Fonts/Propaganda48",
                    OnChoose = p => mm.Play(),
                })
            );
            this.TranslateTo(1335, 400);
        }

        private class MainMenuBehavior : Behavior
        {
            private Entity _fader;

            public MainMenuBehavior(Entity fader) => _fader = fader;

            internal void Play()
            {
                _fader.AddComponent(new FadeOutSprite(() =>
                {
                    var gameState = GameState.NewGame();
                    SceneManager.Start(GamePhaseSceneLocator.Get(gameState.Phase), gameState);
                }));
            }
        }
    }
}
