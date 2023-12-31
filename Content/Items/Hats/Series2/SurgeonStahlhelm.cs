﻿using Microsoft.Xna.Framework;
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

namespace HatSimulator.Content.Items.Hats.Series2
{
    [AutoloadEquip(EquipType.Head)]
    class SurgeonStahlhelm : AbnormalItem
    {
        public SurgeonStahlhelm() : base()
        {
        }
        public SurgeonStahlhelm(AbnormalEffect effect) : base(effect)
        {
        }
        public override bool? SafeIsLoadingEnabled(Mod mod) => true;
        public override string Texture => "HatSimulator/Content/Items/Hats/Series2/SurgeonStahlhelm";

        public override void SetStaticDefaults()
        {
            if (CurrentEffect != 0)
            {
                string name = "" + CurrentEffect;
                //name = Regex.Replace(name, "(?<!^)([A-Z][a-z]|(?<=[a-z])[A-Z])", " $1");
                name = "Unusual";
                name = name + " Surgeon's Stahlhelm";
                //DisplayName.SetDefault(name);
            }
            else
            {
                //DisplayName.SetDefault("Surgeon's Stahlhelm");
            }
            ArmorIDs.Head.Sets.DrawHatHair[Item.headSlot] = true;
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
