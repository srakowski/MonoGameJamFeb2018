// MIT License - Copyright (C) Shawn Rakowski
// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of this source code package.

using System.Collections.Generic;

namespace MonoGameJamFeb2018.Gameplay
{
    class RebelCommand
    {
        private List<Mission> _missions = new List<Mission>();

        public void AddMission(Mission mission)
        {
            _missions.Add(mission);
        }

        public void RemoveMission(Mission mission)
        {
            _missions.Remove(mission);
        }
    }
}
