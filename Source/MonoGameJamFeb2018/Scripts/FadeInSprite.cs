// MIT License - Copyright (C) Shawn Rakowski
// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of this source code package.

using Coldsteel.Rendering;
using Coldsteel.Scripting;
using Microsoft.Xna.Framework;
using System.Collections;

namespace MonoGameJamFeb2018.Scripts
{
    public class FadeInSprite : Behavior
    {
        private readonly int _delay;

        public FadeInSprite(int delay = 1000) =>
            _delay = delay;

        protected override void OnActivated() =>
            StartCoroutine(FadeIn(Entity.GetComponent<SpriteRenderer>()));

        private IEnumerator FadeIn(SpriteRenderer spriteRenderer)
        {
            int alpha = 255;
            spriteRenderer.Color = new Color(spriteRenderer.Color, alpha);
            yield return WaitYieldInstruction.Create(_delay);
            for (; alpha > 0; alpha--)
            {
                spriteRenderer.Color = new Color(spriteRenderer.Color, alpha);
                yield return null;
            }
        }
    }
}
