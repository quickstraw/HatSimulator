using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HatSimulator.HatEffects;
using Terraria.ID;
using Terraria.ModLoader;

namespace HatSimulator.Content.Items.Hats.Series1
{
    [AutoloadEquip(EquipType.Head)]
    class Hotrod : AbnormalItem
    {
        public Hotrod() : base()
        {
        }
        public Hotrod(AbnormalEffect effect) : base(effect)
        {
        }
        public override bool? SafeIsLoadingEnabled(Mod mod) => true;
        public override string Texture => "HatSimulator/Content/Items/Hats/Series1/Hotrod";

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
