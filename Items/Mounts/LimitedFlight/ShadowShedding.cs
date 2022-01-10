using CalValEX.Items.Pets;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CalValEX.Items.Mounts.LimitedFlight
{
    public class ShadowShedding : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Shadow Shedding");
            Tooltip.SetDefault("Infestation!\n" + "Summons a smaller Hive Mind that you can ride inside of");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 30;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.value = Item.sellPrice(0, 2, 0, 0);
            item.rare = 4;
            //item.UseSound = SoundID.Item23;
            item.noMelee = true;
            item.mountType = mod.MountType("HiveMount");
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            //rarity 12 (Turquoise) = new Color(0, 255, 200)
            //rarity 13 (Pure Green) = new Color(0, 255, 0)
            //rarity 14 (Dark Blue) = new Color(43, 96, 222)
            //rarity 15 (Violet) = new Color(108, 45, 199)
            //rarity 16 (Hot Pink/Developer) = new Color(255, 0, 255)
            //rarity rainbow (no expert tag on item) = new Color(Main.DiscoR, Main.DiscoG, Main.DiscoB)
            //rarity rare variant = new Color(255, 140, 0)
            //rarity dedicated(patron items) = new Color(139, 0, 0)
            //look at https://calamitymod.gamepedia.com/Rarity to know where to use the colors
            foreach (TooltipLine tooltipLine in tooltips)
            {
                if (tooltipLine.mod == "Terraria" && tooltipLine.Name == "ItemName")
                {
                    tooltipLine.overrideColor = new Color(107, 240, 255); //change the color accordingly to above
                }
            }
        }

        public override void AddRecipes()
        {
            Mod CalValEX = ModLoader.GetMod("CalamityMod");
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ModLoader.GetMod("CalamityMod").ItemType("TrueShadowScale"), 50);
                recipe.AddIngredient(ModLoader.GetMod("CalamityMod").ItemType("CorruptionEffigy"), 1);
                recipe.AddIngredient(ModContent.ItemType<MissingFang>(), 1);
                recipe.AddIngredient((ItemID.CursedFlame), 200);
                recipe.AddTile(TileID.MythrilAnvil);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }
}