using HatSimulator.Common.Players;
using HatSimulator.Content.Projectiles;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace HatSimulator.Content.Items.LockBoxes
{
    class WinterHatSupplyLockBox : ModItem
    {

        public override void SetStaticDefaults()
        {
            //DisplayName.SetDefault("Winter Hat Lock Box");
            //Tooltip.SetDefault("Right Click to open\nRequires a Winter Hat Key");
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 22;
            Item.maxStack = 99;
            Item.rare = 3;
            Item.value = Item.buyPrice(0, 1, 0, 0);
        }

        public override bool CanRightClick()
        {
            Player player = Main.player[Main.myPlayer];

            bool hasKeys = false;

            for (int i = 0; i < 58; i++)
            {
                if (player.inventory[i].type == ItemType<WinterHatSupplyKey>() && player.inventory[i].stack >= 1)
                {
                    hasKeys = true;
                    break;
                }
            }
            return hasKeys;
        }

        public override void RightClick(Player player)
        {
            if (player.HasItem(ItemType<WinterHatSupplyKey>()))
            {
                for (int i = 0; i < 58; i++)
                {
                    if (player.inventory[i].type == ItemType<WinterHatSupplyKey>() && player.inventory[i].stack >= 1)
                    {
                        player.inventory[i].stack -= 1;
                        break;
                    }
                }
            }
            else
            {
                return;
            }

            var source = player.GetSource_OpenItem(Item.type);
            var projSource = player.GetSource_ItemUse(Item);

            bool isAbnormal = Main.rand.NextBool(50);

            string prefix = "";
            string itemName;

            List<string> names = new List<string>();
            names.Add("BrassBucket");
            names.Add("TartanTyrolean");
            names.Add("ColdfrontCommander");
            names.Add("SinnerShade");
            names.Add("MightyMitre");
            names.Add("CondorCap");
            names.Add("SurgeonShako");
            names.Add("ToySoldier");
            names.Add("PatriotPeak");
            names.Add("Globetrotter");

            int chance;
            chance = Main.rand.Next(0, names.Count);
            itemName = names[chance];

            if (isAbnormal)
            {
                prefix = "Unusual";
                string itemRead = Regex.Replace(itemName, "(?<!^)([A-Z][a-z]|(?<=[a-z])[A-Z])", " $1");
                string text = player.name + " unboxed an Unusual " + itemRead + "!";
                if (Main.netMode == NetmodeID.SinglePlayer)
                {
                    Main.NewText(text, Color.MediumPurple);
                }
                else
                {
                    var modPlayer = player.GetModPlayer<HatSimulatorPlayer>();
                    modPlayer.unboxed = Mod.Find<ModItem>(prefix + itemName).Type;
                }

                int type = ProjectileType<UnusualFireworkProjectile>();
                var projectile = Projectile.NewProjectile(projSource, new Vector2(player.position.X, player.position.Y - 20), new Vector2(), type, 0, 0.0f);
                if (Main.netMode != NetmodeID.SinglePlayer)
                {
                    NetMessage.SendData(MessageID.SyncProjectile, -1, -1, null, projectile);
                }
            }

            player.QuickSpawnItem(source, Mod.Find<ModItem>(prefix + itemName).Type);
        }

    }
}
