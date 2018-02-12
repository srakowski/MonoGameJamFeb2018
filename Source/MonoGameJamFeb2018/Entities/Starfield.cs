// MIT License - Copyright (C) Shawn Rakowski
// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of this source code package.

using Coldsteel;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;

namespace MonoGameJamFeb2018.Entities
{
    class Starfield : Entity
    {
        public Starfield()
        {
            foreach (var star in CreateStars())
                this.AddChild(star);
        }

        private static IEnumerable<Entity> CreateStars()
        {
            var rand = new Random();
            foreach (var color in StarColors(rand))
            {
                yield return new Entity()
                    .TranslateTo(rand.Next(0, 1920), rand.Next(0, 1080))
                    .ScaleTo(rand.Next(100) / 40f)
                    .AddSpriteRenderer("Textures/star", color);
                    //.AddComponent(new StarBehavior(color.A));
            }
        }

        private static IEnumerable<Color> StarColors(Random rand)
        {
            for (var i = 0; i < 200; i++)
                yield return new Color(GameColors.Beige, rand.Next(56, 256));
        }
    }
}
