// MIT License - Copyright (C) Shawn Rakowski
// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of this source code package.

using Coldsteel.Rendering;
using Coldsteel.Scripting;
using Microsoft.Xna.Framework;
using System;
using System.Collections;

namespace MonoGameJamFeb2018.Scripts
{
    public class FadeOutSprite : Behavior
    {
        private Action _onComplete;

        public FadeOutSprite(Action onComplete) => _onComplete = onComplete;

        protected override void OnActivated() =>
            StartCoroutine(FadeIn(Entity.GetComponent<SpriteRenderer>()));

        private IEnumerator FadeIn(SpriteRenderer spriteRenderer)
        {
            int alpha = 0;
            spriteRenderer.Color = new Color(spriteRenderer.Color, alpha);
            for (; alpha < 256; alpha += 2)
            {
                spriteRenderer.Color = new Color(spriteRenderer.Color, alpha);
                yield return null;
            }
            _onComplete?.Invoke();
        }
    }
}
