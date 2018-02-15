// MIT License - Copyright (C) Shawn Rakowski
// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of this source code package.

using Coldsteel;
using Microsoft.Xna.Framework;
using MonoGameJamFeb2018.Entities;
using MonoGameJamFeb2018.Scripts;

namespace MonoGameJamFeb2018.Scenes
{
    static class TitleScene
    {
        public static Scene Create(object param)
        { 
            var scene = new Scene();

            var fader = Entity.Empty
                .ScaleTo(1920, 1080)
                .AddSpriteRenderer("Textures/empty", color: Color.Black, origin: Vector2.Zero)
                .AddComponent(new FadeInSprite())
                .AddAudioSource("Songs/DarkTimes", autoPlay: true, loop: true)
                .AddComponent(new FadeInAudio());

            scene
                .AddEntity(new Background("Textures/title"))
                .AddEntity(new MainMenu(fader))
                .AddEntity(fader);

            return scene;
        }
    }
}
