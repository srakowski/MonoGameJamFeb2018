// MIT License - Copyright (C) Shawn Rakowski
// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of this source code package.

namespace MonoGameJamFeb2018.Gameplay
{
    /// <summary>
    /// Consists of CharacterCenters RebelBase, Outpost, and JumpGate where
    /// you assemble your party for a mission
    /// </summary>
    class OuterRim
    {
        /// <summary>
        /// This planet where the characters are selected from for your party.
        /// </summary>
        public Outpost HomePlanet { get; } = new Outpost();

        /// <summary>
        /// On the moon outside the home planet is the rebel base where your
        /// missions are selected.
        /// </summary>
        public Outpost RebelBase { get; } = new Outpost();

        /// <summary>
        /// Where missions come from.
        /// </summary>
        public RebelCommand RebelCommand { get; } = new RebelCommand();

        /// <summary>
        /// Where money for provisioning comes from.
        /// </summary>
        public RebelBank RebelBank { get; } = new RebelBank();

        /// <summary>
        /// What items are available to purchase.
        /// </summary>
        public Store Store { get; } = new Store();

        public OuterRim()
        {
            foreach (var character in Characters.All)
                HomePlanet.AddCharacter(character);
        }
    }
}
