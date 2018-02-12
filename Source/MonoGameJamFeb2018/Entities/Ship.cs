// MIT License - Copyright (C) Shawn Rakowski
// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of this source code package.

using Coldsteel;

namespace MonoGameJamFeb2018.Entities
{
    class Ship : Entity
    {
        public Ship()
        {
            this
                .AddSpriteRenderer("Textures/ship2")
                .RotateToDegrees(90);
        }
    }
}
