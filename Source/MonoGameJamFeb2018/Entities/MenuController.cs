// MIT License - Copyright (C) Shawn Rakowski
// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of this source code package.

using System;
using Coldsteel;
using Coldsteel.Scripting;

namespace MonoGameJamFeb2018.Entities
{
    class MenuController : Entity
    {
        public MenuController(params MenuOption[] options)
        {
            for (int y = 0; y < options.Length; y++)
                AddChild(options[y].TranslateTo(0, y * 60));

            AddComponent(new MenuControllerBehavior(options));
        }

        private class MenuControllerBehavior : Behavior
        {
            private int _selectedIdx;

            private MenuOption[] _options;

            public MenuControllerBehavior(MenuOption[] options)
            {
                _selectedIdx = 0;
                _options = options;
                _options[_selectedIdx].Select();
            }

            public override void OnUpdate()
            {
                if (Input.GetButton("MenuDown").WasPressed) UpdateSelectedIndex(_selectedIdx + 1);
                else if (Input.GetButton("MenuUp").WasPressed) UpdateSelectedIndex(_selectedIdx - 1);
                else if (Input.GetButton("MenuEnter").WasPressed) EnterSelectedIndex();
            }

            private void UpdateSelectedIndex(int newIdx)
            {
                _options[_selectedIdx].Deselect();
                if (newIdx < 0) newIdx = _options.Length - 1;
                if (newIdx >= _options.Length) newIdx = 0;
                _selectedIdx = newIdx;
                _options[_selectedIdx].Select();
            }

            private void EnterSelectedIndex()
            {
                _options[_selectedIdx].Enter();
            }
        }
    }
}
