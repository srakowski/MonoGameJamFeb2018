// MIT License - Copyright (C) Shawn Rakowski
// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of this source code package.

using Coldsteel;
using Microsoft.Xna.Framework;

namespace MonoGameJamFeb2018.Entities
{
    class Background : Entity
    {
        public Background(string textureRefKey)
        {
            this.AddSpriteRenderer(textureRefKey, origin: Vector2.Zero);
        }
    }
}
