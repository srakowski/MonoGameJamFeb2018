// MIT License - Copyright (C) Shawn Rakowski
// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of this source code package.

using Coldsteel.Audio;
using Coldsteel.Scripting;
using System.Collections;

namespace MonoGameJamFeb2018.Scripts
{
    public class FadeInAudio : Behavior
    {
        private readonly int _delay;

        public FadeInAudio(int delay = 1000) =>
            _delay = delay;

        protected override void OnActivated() =>
            StartCoroutine(FadeIn(Entity.GetComponent<AudioSource>()));

        private IEnumerator FadeIn(AudioSource audioSource)
        {
            int volume = 0;
            audioSource.Volume = volume / 1000f;
            yield return WaitYieldInstruction.Create(_delay);
            for (; volume < 1000; volume++)
            {
                audioSource.Volume = volume / 1000f;
                yield return null;
            }
        }
    }
}
