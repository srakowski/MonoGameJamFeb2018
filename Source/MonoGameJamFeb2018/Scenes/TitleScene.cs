// MIT License - Copyright (C) Shawn Rakowski
// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of this source code package.

using Coldsteel;
using Microsoft.Xna.Framework;
using MonoGameJamFeb2018.Scripts;

namespace MonoGameJamFeb2018.Scenes
{
    static class TitleScene
    {
        public static Scene Create(object param)
        {
            var scene = new Scene();

            scene
                .AddEntity(
                    Entity.Empty
                        .AddSpriteRenderer("Textures/title")
                        .AddAudioSource("Songs/DarkTimes", autoPlay: true, loop: true)
                        .AddComponent(new FadeInAudio())
                )
                .AddEntity(
                    Entity.Empty
                        .ScaleTo(1920, 1080)
                        .AddSpriteRenderer("Textures/empty", color: Color.Black)
                        .AddComponent(new FadeInSprite())
                );

            return scene;
        }
    }
}
