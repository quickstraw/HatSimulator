using HatSimulator.Common.Players;
using HatSimulator.HatEffects;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using static Terraria.ModLoader.ModContent;

namespace HatSimulator.Content.Items.Hats.Halloween
{
    [AutoloadEquip(EquipType.Head)]
    class SirPumpkinton : AbnormalItem
    {
        public SirPumpkinton() : base()
        {
        }
        public SirPumpkinton(AbnormalEffect effect) : base(effect)
        {
        }
        public override bool? SafeIsLoadingEnabled(Mod mod) => true;
        public override string Texture => "HatSimulator/Content/Items/Hats/Halloween/SirPumpkinton";

        public override void SetStaticDefaults()
        {
            ArmorIDs.Head.Sets.DrawHatHair[Item.headSlot] = true;
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = 3;
            Item.vanity = true;
            base.SetDefaults();
        }

        public override void UpdateVanity(Player player)
        {
            HatSimulatorPlayer modPlayer = player.GetModPlayer<HatSimulatorPlayer>();
            modPlayer.tallHat = TallHat.SirPumpkinton;
        }

    }
}
