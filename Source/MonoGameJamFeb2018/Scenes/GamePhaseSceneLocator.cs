// MIT License - Copyright (C) Shawn Rakowski
// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of this source code package.

using MonoGameJamFeb2018.Gameplay;
using MonoGameJamFeb2018.Gameplay.Phases;

namespace MonoGameJamFeb2018.Scenes
{
    static class GamePhaseSceneLocator
    {
        public static string Get(GamePhase phase)
        {
            if (phase is SetupPhase) return nameof(SetupScene);
            if (phase is MissionPhase) return nameof(MissionScene);
            return nameof(TitleScene);
        }
    }
}
