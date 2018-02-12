// MIT License - Copyright (C) Shawn Rakowski
// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of this source code package.

using Coldsteel;
using MonoGameJamFeb2018.Entities;

namespace MonoGameJamFeb2018.Scenes
{
    static class GameplayScene
    {
        public static Scene Create(object param)
        {
            var scene = new Scene();

            scene.AddEntity(new Background("Textures/backdrop"));
            scene.AddEntity(new Starfield());

            scene.AddEntity(new Ship()
                .TranslateTo(100, 100)
            );

            return scene;
        }
    }
}
