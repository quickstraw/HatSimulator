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

namespace HatSimulator.Content.Items.Hats.Series1
{
    [AutoloadEquip(EquipType.Head)]
    class LegendaryLid : AbnormalItem
    {
        public LegendaryLid() : base()
        {
        }
        public LegendaryLid(AbnormalEffect effect) : base(effect)
        {
        }
        public override bool? SafeIsLoadingEnabled(Mod mod) => true;
        public override string Texture => "HatSimulator/Content/Items/Hats/Series1/LegendaryLid";

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

    }
}
