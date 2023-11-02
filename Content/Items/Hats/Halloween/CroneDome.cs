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
    class CroneDome : AbnormalItem
    {
        public CroneDome() : base()
        {
        }
        public CroneDome(AbnormalEffect effect) : base(effect)
        {
        }
        public override bool? SafeIsLoadingEnabled(Mod mod) => true;
        public override string Texture => "HatSimulator/Content/Items/Hats/Halloween/CroneDome";

        public override void SetStaticDefaults()
        {
            if (CurrentEffect != 0)
            {
                string name = "" + CurrentEffect;
                //name = Regex.Replace(name, "(?<!^)([A-Z][a-z]|(?<=[a-z])[A-Z])", " $1");
                name = "Unusual";
                name = name + " Crone's Dome";
                //DisplayName.SetDefault(name);
            }
            else
            {
                //DisplayName.SetDefault("Crone's Dome");
            }
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
            modPlayer.tallHat = TallHat.CroneDome;
        }
    }
}
