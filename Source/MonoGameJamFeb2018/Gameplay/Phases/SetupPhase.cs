// MIT License - Copyright (C) Shawn Rakowski
// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of this source code package.

namespace MonoGameJamFeb2018.Gameplay.Phases
{
    class SetupPhase : GamePhase
    {
        public OuterRim OuterRim { get; }

        public Party Party { get; } = new Party();

        public Mission Mission { get; private set; }

        public SetupPhase(OuterRim outerRim)
        {
            OuterRim = outerRim;
        }

        public void ChooseMission(Mission mission)
        {
            if (Mission != null) OuterRim.RebelCommand.AddMission(Mission);
            OuterRim.RebelCommand.RemoveMission(mission);
            Mission = mission;
        }

        public void AddCharacterToParty(Character character)
        {
            Party.AddCharacter(character);
            OuterRim.HomePlanet.RemoveCharacter(character);
            OuterRim.RebelBase.AddCharacter(character);
        }

        public void RemoveCharacterFromPart(Character character)
        {
            OuterRim.RebelBase.RemoveCharacter(character);
            OuterRim.HomePlanet.AddCharacter(character);
            Party.RemoveCharacter(character);
        }

        public void BuyItem(Item item)
        {
            OuterRim.RebelBank.Debit(item.Price);
            Party.AddInventoryItem(item);
        }

        public void RefundItem(Item item)
        {
            Party.RemoveInventoryItem(item);
            OuterRim.RebelBank.Credit(item.Price);
        }

        public MissionPhase Jump()
        {
            return new MissionPhase(Party);
        }
    }
}
