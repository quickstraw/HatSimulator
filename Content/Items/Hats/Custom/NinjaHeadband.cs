using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;
using HatSimulator.HatEffects;

namespace HatSimulator.Content.Items.Hats.Custom
{
    [AutoloadEquip(EquipType.Head)]
    class NinjaHeadband : AbnormalItem
    {
        public NinjaHeadband() : base()
        {
        }
        public NinjaHeadband(AbnormalEffect effect) : base(effect)
        {
        }
        public override bool? SafeIsLoadingEnabled(Mod mod) => true;
        public override string Texture => "HatSimulator/Content/Items/Hats/Custom/NinjaHeadband";

        public override void SetStaticDefaults()
        {
            ArmorIDs.Head.Sets.DrawFullHair[Item.headSlot] = true;
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.rare = ItemRarityID.Orange;
            Item.vanity = true;

            base.SetDefaults();
        }

    }
}
