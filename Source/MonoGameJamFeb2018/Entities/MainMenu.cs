// MIT License - Copyright (C) Shawn Rakowski
// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of this source code package.

using System;
using Coldsteel;
using Coldsteel.Scripting;
using MonoGameJamFeb2018.Scenes;

namespace MonoGameJamFeb2018.Entities
{
    class MainMenu : Entity
    {
        public MainMenu()
        {
            var mm = new MainMenuBehavior();
            AddComponent(mm);
            AddChild(new MenuController(
                new MenuOption("PLAY", mm.Play),
                new MenuOption("OPTIONS", mm.Options),
                new MenuOption("CREDITS", mm.Credits))
            );
            this.TranslateTo(1335, 400);
        }

        private class MainMenuBehavior : Behavior
        {
            internal void Credits()
            {
                throw new NotImplementedException();
            }

            internal void Options()
            {
                throw new NotImplementedException();
            }

            internal void Play()
            {
                SceneManager.Start(nameof(GameplayScene));
            }
        }
    }
}
