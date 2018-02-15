// MIT License - Copyright (C) Shawn Rakowski
// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of this source code package.

using Coldsteel.Rendering;
using Microsoft.Xna.Framework;
using System;

namespace MonoGameJamFeb2018.Entities
{
    class ListViewConfig<T>
    {
        public string Font { get; set; } = "Fonts/Default";

        public Color Color { get; set; } = Color.White;

        public Color SelectedColor { get; set; } = Color.Black;

        public Func<T, string> NameSelector { get; set; } = (t) => t.ToString();

        public Origin Origin { get; set; } = Origin.CenterMiddle;

        public Action<T> OnSelect { get; set; }
        public Action<T> OnDeselect { get; set; }
        public Action<T> OnChoose { get; set; }
    }
}
