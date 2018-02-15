// MIT License - Copyright (C) Shawn Rakowski
// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of this source code package.

using Coldsteel;
using Coldsteel.Rendering;
using Microsoft.Xna.Framework;
using MonoGameJamFeb2018.Entities;
using MonoGameJamFeb2018.Gameplay;
using System.Collections.Generic;
using System.Linq;

namespace MonoGameJamFeb2018.Scenes
{
    static class SetupScene
    {
        public static Scene Create(object param)
        {
            var game = param as GameState;

            var scene = new Scene();

            scene.AddEntity(new Background("Textures/backdrop"));
            scene.AddEntity(new Starfield());

            var homePlanetPos = new Vector2(400, 360);
            scene.AddEntity(new Entity()
                .AddSpriteRenderer("Textures/homeplanet")
                .TranslateTo(homePlanetPos));

            scene.AddEntity(new Entity()
                .AddSpriteRenderer("Textures/rebelbase")
                .TranslateTo(960, 280));

            scene.AddEntity(new Entity()
                .AddSpriteRenderer("Textures/jumpgate")
                .TranslateTo(1460, 400)
                .ScaleTo(1.5f));

            var angle = 0f;
            var ships = new List<Ship>();
            foreach (var character in game.OuterRim.HomePlanet.Characters)
            {
                var ship = new Ship(character);
                ship.TranslateTo(homePlanetPos +
                    Vector2.Transform(new Vector2(200, 0),
                    Matrix.CreateRotationZ(MathHelper.ToRadians(angle))));
                scene.AddEntity(ship);
                angle += (360f/game.OuterRim.HomePlanet.Characters.Count());
                ships.Add(ship);
            }

            scene.AddEntity(new Background("Textures/bottomgradient")
                .TranslateTo(0, 580)
                .ScaleTo(1920, 1)
            );

            scene.AddEntity(
                new ListView<Ship>(ships, new ListViewConfig<Ship>
                {
                    Font = "Fonts/Propaganda24",
                    Color = GameColors.White,
                    SelectedColor = GameColors.Red,
                    NameSelector = s => s.Character.ShipName,
                    Origin = Origin.UpperLeft,
                    OnSelect = s => s.Select(),
                    OnDeselect = s => s.Deselect(),
                })
                .TranslateTo(200, 700)
            );

            return scene;
        }
    }
}
