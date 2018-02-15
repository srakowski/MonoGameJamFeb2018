// MIT License - Copyright (C) Shawn Rakowski
// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of this source code package.

using MonoGameJamFeb2018.Gameplay.Phases;

namespace MonoGameJamFeb2018.Gameplay
{
    class GameState
    {
        public OuterRim OuterRim { get; }

        public GamePhase Phase { get; }

        private GameState(OuterRim outerRim)
        {
            OuterRim = outerRim;
            Phase = new SetupPhase(outerRim);
        }

        public static GameState NewGame()
        {
            return new GameState(new OuterRim());
        }
    }
}
