using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ModLoader;

namespace HatSimulator.Common
{
    public class Crate2SpawnRule : IItemDropRuleCondition
    {
        public bool CanDrop(DropAttemptInfo info)
        {
            var npc = info.npc;
            bool passive = npc.aiStyle == 7 || npc.aiStyle == 24 || npc.aiStyle == 64 || npc.aiStyle == 65 || npc.aiStyle == 66 || npc.aiStyle == 67 || npc.aiStyle == 68;
            bool downedHatter = NPC.downedBoss2;//HighlanderWorld.downedHauntedHatter;
            bool downedIdol = NPC.downedMechBossAny;//HighlanderWorld.downedEnlightenmentIdol;
            bool boss = npc.boss;
            bool disabledDrops = ModContent.GetInstance<HatSimulatorConfig>().DisableLockBoxes;
            return !passive && downedHatter && downedIdol && !disabledDrops;
        }

        public bool CanShowItemDropInUI()
        {
            return false;
        }

        public string GetConditionDescription()
        {
            return "Spawns after defeating a Mech Boss.";
        }
    }
}
