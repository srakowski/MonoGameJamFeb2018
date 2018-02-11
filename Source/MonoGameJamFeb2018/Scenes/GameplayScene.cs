// MIT License - Copyright (C) Shawn Rakowski
// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of this source code package.

using Coldsteel;
using Coldsteel.Content;
using Coldsteel.Rendering;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGameJamFeb2018.Scenes
{
    static class GameplayScene
    {
        public static Scene Create(object param)
        {
            var scene = new Scene();

            scene.AddEntity(
                new Entity()
                    .AddComponent(new SpriteRenderer
                    {
                        Texture = new ContentRef<Texture2D>("Sprites/ship"),
                    })
            );

            return scene;
        }
    }
}
