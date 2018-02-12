// MIT License - Copyright (C) Shawn Rakowski
// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of this source code package.

using Coldsteel;
using Coldsteel.Rendering;
using System;

namespace MonoGameJamFeb2018.Entities
{
    class MenuOption : Entity
    {
        private Action _onEnter;

        private TextRenderer _textRenderer;

        public MenuOption(string text, Action onEnter)
        {
            _onEnter = onEnter;
            this.AddTextRenderer("Fonts/MainMenu", text: text, color: GameColors.Black);
            _textRenderer = GetComponent<TextRenderer>();
        }

        public void Select()
        {
            _textRenderer.Color = GameColors.DarkRed;
            _textRenderer.Text = $"- {_textRenderer.Text} -";
        }

        public void Enter()
        {
            _onEnter.Invoke();
        }

        public void Deselect()
        {
            _textRenderer.Text = _textRenderer.Text.TrimStart('-', ' ').TrimEnd('-', ' ');
            _textRenderer.Color = GameColors.Black;
        }
    }
}
