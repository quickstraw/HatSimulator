using Terraria.ModLoader.Config;

namespace HatSimulator
{
    class HatSimulatorConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [Label("Disable Lock Box Drops")]
        [Tooltip("Stops Lock Boxes from dropping.")]
        public bool DisableLockBoxes { get; set; }

    }
}
