// MIT License - Copyright (C) Shawn Rakowski
// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of this source code package.

namespace MonoGameJamFeb2018.Gameplay
{
    /// <summary>
    /// These are ships + captains that are added to your party...
    /// </summary>
    public class Character
    {
        public string ShipName { get; }

        public Character(string shipName)
        {
            ShipName = shipName;
        }
    }
}
