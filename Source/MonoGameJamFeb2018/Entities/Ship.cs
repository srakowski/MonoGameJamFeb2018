// MIT License - Copyright (C) Shawn Rakowski
// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of this source code package.

using System;
using Coldsteel;
using MonoGameJamFeb2018.Gameplay;
using Coldsteel.Rendering;

namespace MonoGameJamFeb2018.Entities
{
    class Ship : Entity
    {
        private SpriteRenderer _spriteRenderer;

        public Character Character { get; private set; }

        public Ship(Character character)
        {
            Character = character;

            this
                .AddSpriteRenderer("Textures/ship0", color: GameColors.White)
                .RotateToDegrees(90);

            _spriteRenderer = this.GetComponent<SpriteRenderer>();
        }

        internal void Select()
        {
            _spriteRenderer.Color = GameColors.Red;
        }

        internal void Deselect()
        {
            _spriteRenderer.Color = GameColors.White;
        }
    }
}
