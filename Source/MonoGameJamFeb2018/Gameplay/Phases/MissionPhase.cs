// MIT License - Copyright (C) Shawn Rakowski
// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of this source code package.

namespace MonoGameJamFeb2018.Gameplay.Phases
{
    class MissionPhase : GamePhase
    {
        private Party _party;

        public MissionPhase(Party party)
        {
            _party = party;
        }
    }
}
