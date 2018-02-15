// MIT License - Copyright (C) Shawn Rakowski
// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of this source code package.

using System.Collections.Generic;

namespace MonoGameJamFeb2018.Gameplay
{
    static class Characters
    {
        public static IEnumerable<Character> All { get; } = new[]
        {
            new Character("Oberon"),
            new Character("Angelica"),
            new Character("CS Syracuse"),
            new Character("SS Spitfire"),
            new Character("SC Starfall"),
        };
    }
}
