using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HatSimulator.HatEffects;
using Terraria.ModLoader;

namespace HatSimulator.Content.Items.Hats.Series1
{
    [AutoloadEquip(EquipType.Head)]
    class StainlessPot : AbnormalItem
    {

        public StainlessPot() : base()
        {
        }
        public StainlessPot(AbnormalEffect effect) : base(effect)
        {
        }
        public override bool? SafeIsLoadingEnabled(Mod mod) => true;
        public override string Texture => "HatSimulator/Content/Items/Hats/Series1/StainlessPot";

        public override void SetStaticDefaults()
        {
            //Tooltip.SetDefault("Your head will smell delicious.");
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
