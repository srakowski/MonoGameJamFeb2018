// MIT License - Copyright (C) Shawn Rakowski
// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of this source code package.

using System.Collections.Generic;

namespace MonoGameJamFeb2018.Gameplay
{
    class Party
    {
        private List<Character> _characters = new List<Character>();

        private List<Item> _inventory = new List<Item>();

        public IEnumerable<Character> Characters => _characters;

        public IEnumerable<Item> Inventory => _inventory;

        public void AddCharacter(Character character)
        {
            _characters.Add(character);
        }

        public void RemoveCharacter(Character character)
        {
            _characters.Remove(character);
        }

        public void AddInventoryItem(Item item)
        {
            _inventory.Add(item);
        }

        public void RemoveInventoryItem(Item item)
        {
            _inventory.Remove(item);
        }
    }
}
