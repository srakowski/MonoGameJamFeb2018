// MIT License - Copyright (C) Shawn Rakowski
// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of this source code package.

using System.Collections.Generic;

namespace MonoGameJamFeb2018.Gameplay
{
    /// <summary>
    /// A place where characters can live...
    /// </summary>
    class Outpost
    {
        private List<Character> _characters = new List<Character>();

        public IEnumerable<Character> Characters => _characters;

        public void AddCharacter(Character character)
        {
            _characters.Add(character);
        }

        public void RemoveCharacter(Character character)
        {
            _characters.Remove(character);
        }
    }
}
