﻿using HatSimulator.HatEffects;
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

namespace HatSimulator.Content.Items.Hats.Custom
{
    [AutoloadEquip(EquipType.Head)]
    class AutonomousOrb : AbnormalItem
    {
        public AutonomousOrb() : base()
        {
        }
        public AutonomousOrb(AbnormalEffect effect) : base(effect)
        {
        }
        public override bool? SafeIsLoadingEnabled(Mod mod) => true;
        public override string Texture => "HatSimulator/Content/Items/Hats/Custom/AutonomousOrb";

        public override void SetStaticDefaults()
        {
            ArmorIDs.Head.Sets.DrawHead[Item.headSlot] = false;
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
